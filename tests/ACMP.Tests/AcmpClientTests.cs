using System.Net;
using System.Text;
using System.Text.Json;
using ACMP.Models;

namespace ACMP.Tests;

public sealed class AcmpClientTests
{
    [Fact]
    public async Task LoginStoresAndAppliesSessionHeader()
    {
        var cancellationToken = TestContext.Current.CancellationToken;
        var handler = new RecordingHandler(
            request => request.RequestUri.AbsolutePath == "/GetSessionToken"
                ? JsonResponse("\"session-token\"")
                : JsonResponse("{}"));

        using (var client = new AcmpClient(new Uri("https://marketplace.example.com"), handler))
        {
            await client.ConnectAsync("user@example.com", "secret", cancellationToken);
            await client.PostAsync<object>(
                "/GetCompanies",
                new GetCompaniesRequest { ParentAccountId = 100001 },
                cancellationToken);
        }

        var authenticatedRequest = handler.Requests.Single(request => request.RequestUri.AbsolutePath == "/GetCompanies");
        Assert.Equal("CCPSessionId session-token", authenticatedRequest.AuthenticateHeader);
    }

    [Fact]
    public async Task LoginAcceptsPlainTokenResponse()
    {
        var cancellationToken = TestContext.Current.CancellationToken;
        var handler = new RecordingHandler(
            request => request.RequestUri.AbsolutePath == "/GetSessionToken"
                ? TextResponse("plain-session-token")
                : JsonResponse("{}"));

        using (var client = new AcmpClient(new Uri("https://marketplace.example.com"), handler))
        {
            await client.ConnectAsync("user@example.com", "secret", cancellationToken);
            await client.PostAsync<object>(
                "/GetCompanies",
                new GetCompaniesRequest { ParentAccountId = 100001 },
                cancellationToken);
        }

        var authenticatedRequest = handler.Requests.Single(request => request.RequestUri.AbsolutePath == "/GetCompanies");
        Assert.Equal("CCPSessionId plain-session-token", authenticatedRequest.AuthenticateHeader);
    }

    [Fact]
    public async Task DisconnectTerminatesSession()
    {
        var cancellationToken = TestContext.Current.CancellationToken;
        var handler = new RecordingHandler(
            request => request.RequestUri.AbsolutePath == "/GetSessionToken"
                ? JsonResponse("\"session-token\"")
                : new HttpResponseMessage(HttpStatusCode.OK));

        using (var client = new AcmpClient(new Uri("https://marketplace.example.com"), handler))
        {
            await client.ConnectAsync("user@example.com", "secret", cancellationToken);
            await client.DisconnectAsync(cancellationToken);
        }

        var terminateRequest = handler.Requests.Single(request => request.RequestUri.AbsolutePath == "/TerminateSessionToken");
        Assert.Equal("CCPSessionId session-token", terminateRequest.AuthenticateHeader);
    }

    [Fact]
    public async Task PingPostsEmptyJsonBody()
    {
        var cancellationToken = TestContext.Current.CancellationToken;
        var handler = new RecordingHandler(
            request => request.RequestUri.AbsolutePath == "/GetSessionToken"
                ? JsonResponse("\"session-token\"")
                : new HttpResponseMessage(HttpStatusCode.OK));

        using (var client = new AcmpClient(new Uri("https://marketplace.example.com"), handler))
        {
            await client.ConnectAsync("user@example.com", "secret", cancellationToken);
            await client.TestConnectionAsync(cancellationToken);
        }

        var pingRequest = handler.Requests.Single(request => request.RequestUri.AbsolutePath == "/PingPong");
        Assert.Equal("{}", pingRequest.Body);
    }

    [Fact]
    public async Task GetCompanyPostsAccountIdAndWrapsResponse()
    {
        var cancellationToken = TestContext.Current.CancellationToken;
        var handler = new RecordingHandler(
            request => request.RequestUri.AbsolutePath == "/GetSessionToken"
                ? JsonResponse("\"session-token\"")
                : JsonResponse("[{\"accountId\":100006}]"));

        GetCompanyResponse? response;
        using (var client = new AcmpClient(new Uri("https://marketplace.example.com"), handler))
        {
            await client.ConnectAsync("user@example.com", "secret", cancellationToken);
            response = await client.GetCompanyAsync(100006, cancellationToken);
        }

        var getCompanyRequest = handler.Requests.Single(request => request.RequestUri.AbsolutePath == "/GetCompany");
        Assert.Equal("CCPSessionId session-token", getCompanyRequest.AuthenticateHeader);
        Assert.Contains("\"accountId\":100006", getCompanyRequest.Body);
        Assert.Single(response!.Items);
    }

    [Fact]
    public async Task GetCompaniesPostsParentAccountIdAndWrapsResponse()
    {
        var cancellationToken = TestContext.Current.CancellationToken;
        var handler = new RecordingHandler(
            request => request.RequestUri.AbsolutePath == "/GetSessionToken"
                ? JsonResponse("\"session-token\"")
                : JsonResponse("[{\"accountId\":100006},{\"accountId\":100007}]"));

        GetCompaniesResponse? response;
        using (var client = new AcmpClient(new Uri("https://marketplace.example.com"), handler))
        {
            await client.ConnectAsync("user@example.com", "secret", cancellationToken);
            response = await client.GetCompaniesAsync(100001, cancellationToken);
        }

        var getCompaniesRequest = handler.Requests.Single(request => request.RequestUri.AbsolutePath == "/GetCompanies");
        Assert.Equal("CCPSessionId session-token", getCompaniesRequest.AuthenticateHeader);
        Assert.Contains("\"parentAccountId\":100001", getCompaniesRequest.Body);
        Assert.Equal(2, response!.Items.Count);
    }

    [Fact]
    public async Task SerializationUsesJsonPropertyNames()
    {
        var cancellationToken = TestContext.Current.CancellationToken;
        var handler = new RecordingHandler(
            request => request.RequestUri.AbsolutePath == "/GetSessionToken"
                ? JsonResponse("\"session-token\"")
                : JsonResponse("{}"));

        using (var client = new AcmpClient(new Uri("https://marketplace.example.com"), handler))
        {
            await client.ConnectAsync("user@example.com", "secret", cancellationToken);
            await client.PostAsync<object>(
                "/GetCompanies",
                new GetCompaniesRequest { ParentAccountId = 100001 },
                cancellationToken);
        }

        var companiesRequest = handler.Requests.Single(request => request.RequestUri.AbsolutePath == "/GetCompanies");
        Assert.Contains("\"parentAccountId\":100001", companiesRequest.Body);
        Assert.DoesNotContain("ParentAccountId", companiesRequest.Body);
    }

    [Fact]
    public void FieldValuesDeserializeToClrTypes()
    {
        const string json = "{\"Fields\":[" +
            "{\"Name\":\"Text\",\"Value\":\"hello\"}," +
            "{\"Name\":\"Number\",\"Value\":3}," +
            "{\"Name\":\"Boolean\",\"Value\":true}," +
            "{\"Name\":\"Null\",\"Value\":null}," +
            "{\"Name\":\"Missing\"}," +
            "{\"Name\":\"Object\",\"Value\":{\"settings\":{\"mode\":{\"retry\":true,\"delay\":5}}}}," +
            "{\"Name\":\"Array\",\"Value\":[1,\"two\",false,{\"nested\":4}]}" +
            "]}";

        var subscription = JsonSerializer.Deserialize<Subscription>(json, AcmpClient.JsonSerializerOptions);
        Assert.NotNull(subscription);
        Assert.NotNull(subscription.Fields);

        var fields = subscription.Fields;
        Assert.Equal("hello", fields.Single(field => field.Name == "Text").Value);
        Assert.Equal(3m, fields.Single(field => field.Name == "Number").Value);
        Assert.Equal(true, fields.Single(field => field.Name == "Boolean").Value);
        Assert.Null(fields.Single(field => field.Name == "Null").Value);
        Assert.Null(fields.Single(field => field.Name == "Missing").Value);

        var root = Assert.IsType<Dictionary<string, object?>>(fields.Single(field => field.Name == "Object").Value);
        var settings = Assert.IsType<Dictionary<string, object?>>(root["settings"]);
        var mode = Assert.IsType<Dictionary<string, object?>>(settings["mode"]);
        Assert.Equal(true, mode["retry"]);
        Assert.Equal(5m, mode["delay"]);

        var array = Assert.IsType<object?[]>(fields.Single(field => field.Name == "Array").Value);
        Assert.Equal(1m, array[0]);
        Assert.Equal("two", array[1]);
        Assert.Equal(false, array[2]);
        Assert.Equal(4m, Assert.IsType<Dictionary<string, object?>>(array[3])["nested"]);

        var serialized = JsonSerializer.Serialize(subscription, AcmpClient.JsonSerializerOptions);
        Assert.Contains("\"retry\":true", serialized);
        Assert.Contains("\"delay\":5", serialized);
    }

    [Fact]
    public void SubscriptionProvisioningStatusDeserializes()
    {
        const string json = "{\"ProvisioningStatus\":\"Pending\"}";

        var subscription = JsonSerializer.Deserialize<Subscription>(json, AcmpClient.JsonSerializerOptions);

        Assert.NotNull(subscription);
        Assert.Equal("Pending", subscription.ProvisioningStatus);
    }

    [Fact]
    public async Task ApiErrorsIncludeResponseDetails()
    {
        var cancellationToken = TestContext.Current.CancellationToken;
        var handler = new RecordingHandler(
            request => request.RequestUri.AbsolutePath == "/GetSessionToken"
                ? JsonResponse("\"session-token\"")
                : new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("<error>invalid</error>", Encoding.UTF8, "application/xml"),
                    ReasonPhrase = "Bad Request"
                });

        using var client = new AcmpClient(new Uri("https://marketplace.example.com"), handler);
        await client.ConnectAsync("user@example.com", "secret", cancellationToken);

        var exception = await Assert.ThrowsAsync<AcmpApiException>(
            () => client.PostAsync<object>("/Fail", new { }, cancellationToken));

        Assert.Equal(HttpStatusCode.BadRequest, exception.StatusCode);
        Assert.Contains("<error>invalid</error>", exception.ResponseBody);
        Assert.Contains("application/xml", exception.ContentType);
        Assert.Equal("/Fail", exception.RequestUri.AbsolutePath);
    }

    private static HttpResponseMessage JsonResponse(string json)
    {
        return new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(json, Encoding.UTF8, "application/json")
        };
    }

    private static HttpResponseMessage TextResponse(string text)
    {
        return new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(text, Encoding.UTF8, "text/plain")
        };
    }
}

internal sealed class RecordingHandler : HttpMessageHandler
{
    private readonly Func<RecordedRequest, HttpResponseMessage> _createResponse;

    public RecordingHandler(Func<RecordedRequest, HttpResponseMessage> createResponse)
    {
        _createResponse = createResponse;
    }

    public List<RecordedRequest> Requests { get; } = new();

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var recordedRequest = new RecordedRequest
        {
            RequestUri = request.RequestUri!,
            AuthenticateHeader = request.Headers.TryGetValues("Authenticate", out var values)
                ? values.Single()
                : null,
            Body = request.Content == null
                ? null
                : await request.Content.ReadAsStringAsync(cancellationToken)
        };

        Requests.Add(recordedRequest);
        var response = _createResponse(recordedRequest);
        response.RequestMessage = request;
        return response;
    }
}

internal sealed class RecordedRequest
{
    public Uri RequestUri { get; init; } = default!;

    public string? AuthenticateHeader { get; init; }

    public string? Body { get; init; }
}
