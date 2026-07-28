using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetRemoteEnumsRequest
    {
        [JsonPropertyName("remoteEnumRequest")]
        public GetRemoteEnumsRequestRemoteEnumRequest RemoteEnumRequest { get; set; } = default!;
    }
}
