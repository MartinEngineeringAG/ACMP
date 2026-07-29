using System;
using System.Net;

namespace ACMP
{
    public class AcmpApiException : Exception
    {
        public AcmpApiException(
            string message,
            HttpStatusCode statusCode,
            Uri requestUri,
            string? responseBody,
            string? contentType)
            : base(message)
        {
            StatusCode = statusCode;
            RequestUri = requestUri;
            ResponseBody = responseBody;
            ContentType = contentType;
        }

        public HttpStatusCode StatusCode { get; }

        public Uri RequestUri { get; }

        public string? ResponseBody { get; }

        public string? ContentType { get; }
    }
}
