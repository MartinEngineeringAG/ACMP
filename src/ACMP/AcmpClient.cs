using System;
using System.Reflection;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using ACMP.Models;

namespace ACMP
{
    public partial class AcmpClient : IDisposable
    {
        private const string SessionHeaderName = "Authenticate";
        private const string SessionHeaderScheme = "CCPSessionId";
        private readonly HttpClient _httpClient;
        private readonly bool _disposeHttpClient;
        private string? _sessionToken;
        private bool _disposed;

        public AcmpClient(Uri baseUri)
            : this(baseUri, new HttpClient(), disposeHttpClient: true)
        {
        }

        public AcmpClient(Uri baseUri, HttpMessageHandler messageHandler)
            : this(baseUri, new HttpClient(messageHandler, disposeHandler: false), disposeHttpClient: true)
        {
        }

        public AcmpClient(Uri baseUri, HttpClient httpClient)
            : this(baseUri, httpClient, disposeHttpClient: false)
        {
        }

        private AcmpClient(Uri baseUri, HttpClient httpClient, bool disposeHttpClient)
        {
            BaseUri = baseUri ?? throw new ArgumentNullException(nameof(baseUri));
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _disposeHttpClient = disposeHttpClient;
        }

        public Uri BaseUri { get; }

        public bool IsAuthenticated => !string.IsNullOrWhiteSpace(_sessionToken);

        public static JsonSerializerOptions JsonSerializerOptions { get; } = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            PropertyNameCaseInsensitive = false
        };

        public async Task ConnectAsync(string username, string password, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username cannot be empty.", nameof(username));
            }

            if (password is null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            await ConnectAsync(new AuthenticateRequest
            {
                Username = username,
                Password = password
            }, cancellationToken).ConfigureAwait(false);
        }

        public async Task ConnectAsync(AuthenticateRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using (var response = await SendPostAsync("/GetSessionToken", request, includeSessionToken: false, sendBody: true, cancellationToken).ConfigureAwait(false))
            {
                var content = await ReadContentAsync(response).ConfigureAwait(false);
                await EnsureSuccessAsync(response, content).ConfigureAwait(false);
                _sessionToken = DeserializeSessionToken(content);
            }
        }

        public async Task DisconnectAsync(CancellationToken cancellationToken = default)
        {
            if (!IsAuthenticated)
            {
                return;
            }

            try
            {
                using (var response = await SendPostAsync("/TerminateSessionToken", new { }, includeSessionToken: true, sendBody: true, cancellationToken).ConfigureAwait(false))
                {
                    var content = await ReadContentAsync(response).ConfigureAwait(false);
                    await EnsureSuccessAsync(response, content).ConfigureAwait(false);
                }
            }
            finally
            {
                _sessionToken = null;
            }
        }

        public async Task TestConnectionAsync(CancellationToken cancellationToken = default)
        {
            using (var response = await SendPostAsync("/PingPong", new { }, includeSessionToken: true, sendBody: true, cancellationToken).ConfigureAwait(false))
            {
                var content = await ReadContentAsync(response).ConfigureAwait(false);
                await EnsureSuccessAsync(response, content).ConfigureAwait(false);
            }
        }

        public async Task<TResponse?> PostAsync<TResponse>(string path, object? body = null, CancellationToken cancellationToken = default)
        {
            var response = await PostAsync(path, body, typeof(TResponse), cancellationToken).ConfigureAwait(false);
            return (TResponse?)response;
        }

        public async Task<object?> PostAsync(string path, object? body = null, Type? responseType = null, CancellationToken cancellationToken = default)
        {
            using (var response = await SendPostAsync(path, body, includeSessionToken: true, sendBody: true, cancellationToken).ConfigureAwait(false))
            {
                var content = await ReadContentAsync(response).ConfigureAwait(false);
                await EnsureSuccessAsync(response, content).ConfigureAwait(false);

                var responseContent = content ?? string.Empty;
                if (string.IsNullOrWhiteSpace(responseContent))
                {
                    return null;
                }

                if (responseType is null || responseType == typeof(string))
                {
                    return responseContent;
                }

                return DeserializeResponse(responseContent, responseType);
            }
        }

        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }

            if (_disposeHttpClient)
            {
                _httpClient.Dispose();
            }

            _sessionToken = null;
            _disposed = true;
            GC.SuppressFinalize(this);
        }

        private async Task<HttpResponseMessage> SendPostAsync(
            string path,
            object? body,
            bool includeSessionToken,
            bool sendBody,
            CancellationToken cancellationToken)
        {
            if (includeSessionToken && !IsAuthenticated)
            {
                throw new InvalidOperationException("The client is not connected. Run Connect-ACMP first.");
            }

            var requestUri = BuildRequestUri(path);
            using (var request = new HttpRequestMessage(HttpMethod.Post, requestUri))
            {
                if (includeSessionToken)
                {
                    request.Headers.TryAddWithoutValidation(SessionHeaderName, $"{SessionHeaderScheme} {_sessionToken}");
                }

                if (sendBody)
                {
                    var json = JsonSerializer.Serialize(body ?? new { }, JsonSerializerOptions);
                    request.Content = new StringContent(json, Encoding.UTF8, "application/json");
                }

                return await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
            }
        }

        private Uri BuildRequestUri(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Path cannot be empty.", nameof(path));
            }

            var relativePath = path.TrimStart('/');
            if (Uri.TryCreate(relativePath, UriKind.Absolute, out _))
            {
                throw new ArgumentException("Path must be relative to the configured base URI.", nameof(path));
            }

            var baseText = BaseUri.ToString().TrimEnd('/') + "/";
            return new Uri(new Uri(baseText), relativePath);
        }

        private static async Task<string?> ReadContentAsync(HttpResponseMessage response)
        {
            if (response.Content is null)
            {
                return null;
            }

            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        private static object? DeserializeResponse(string content, Type responseType)
        {
            var trimmed = content.TrimStart();
            if (trimmed.StartsWith("[", StringComparison.Ordinal))
            {
                var itemsProperty = responseType.GetProperty("Items", BindingFlags.Instance | BindingFlags.Public);
                if (itemsProperty?.CanWrite == true && itemsProperty.PropertyType.IsGenericType)
                {
                    var result = Activator.CreateInstance(responseType);
                    var items = JsonSerializer.Deserialize(content, itemsProperty.PropertyType, JsonSerializerOptions);
                    itemsProperty.SetValue(result, items);
                    return result;
                }
            }

            if (trimmed.StartsWith("\"", StringComparison.Ordinal))
            {
                var valueProperty = responseType.GetProperty("Value", BindingFlags.Instance | BindingFlags.Public);
                if (valueProperty?.CanWrite == true && valueProperty.PropertyType == typeof(string))
                {
                    var result = Activator.CreateInstance(responseType);
                    var value = JsonSerializer.Deserialize<string>(content, JsonSerializerOptions);
                    valueProperty.SetValue(result, value);
                    return result;
                }
            }

            return JsonSerializer.Deserialize(content, responseType, JsonSerializerOptions);
        }

        private static Task EnsureSuccessAsync(HttpResponseMessage response, string? responseBody)
        {
            if (response.IsSuccessStatusCode)
            {
                return Task.CompletedTask;
            }

            var contentType = response.Content?.Headers.ContentType?.ToString();
            var message = $"ALSO Marketplace API request to '{response.RequestMessage?.RequestUri}' failed with status {(int)response.StatusCode} ({response.ReasonPhrase}).";
            throw new AcmpApiException(
                message,
                response.StatusCode,
                response.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                responseBody,
                contentType);
        }

        private static string DeserializeSessionToken(string? content)
        {
            if (content is null)
            {
                throw new InvalidOperationException("The session token response was empty.");
            }

            var trimmed = content.Trim();
            if (trimmed.Length == 0)
            {
                throw new InvalidOperationException("The session token response was empty.");
            }

            if (trimmed.StartsWith("\"", StringComparison.Ordinal))
            {
                var token = JsonSerializer.Deserialize<string>(trimmed, JsonSerializerOptions);
                if (!string.IsNullOrWhiteSpace(token))
                {
                    return token!;
                }
            }

            if (trimmed.StartsWith("{", StringComparison.Ordinal))
            {
                var wrappedToken = JsonSerializer.Deserialize<GetSessionTokenResponse>(trimmed, JsonSerializerOptions);
                var wrappedTokenValue = wrappedToken?.Value;
                if (!string.IsNullOrWhiteSpace(wrappedTokenValue))
                {
                    return wrappedTokenValue!;
                }
            }

            return trimmed;
        }
    }
}
