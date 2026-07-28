using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class AuthenticateRequest
    {
        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>johndoe@example.com</example>
        [JsonPropertyName("username")]
        public string Username { get; set; } = default!;

        /// <summary>
        /// OpenAPI schema property.
        /// </summary>
        /// <example>0yaddPqnuO</example>
        [JsonPropertyName("password")]
        public string Password { get; set; } = default!;
    }
}
