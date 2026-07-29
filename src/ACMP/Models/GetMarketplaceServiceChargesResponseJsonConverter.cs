using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class GetMarketplaceServiceChargesResponseJsonConverter : JsonConverter<GetMarketplaceServiceChargesResponse>
    {
        public override GetMarketplaceServiceChargesResponse? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var response = new GetMarketplaceServiceChargesResponse();

            if (reader.TokenType == JsonTokenType.StartArray)
            {
                var items = JsonSerializer.Deserialize<List<MarketplaceServiceInfo>>(ref reader, options);
                response.Items = items ?? new List<MarketplaceServiceInfo>();
                return response;
            }

            if (reader.TokenType == JsonTokenType.StartObject)
            {
                // The OpenAPI spec declares this response as an array, but the live API can return a single object.
                var item = JsonSerializer.Deserialize<MarketplaceServiceInfo>(ref reader, options);
                if (item is not null)
                {
                    response.Items.Add(item);
                }

                return response;
            }

            throw new JsonException($"Unexpected token {reader.TokenType} while reading marketplace service charges.");
        }

        public override void Write(Utf8JsonWriter writer, GetMarketplaceServiceChargesResponse value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.Items, options);
        }
    }
}
