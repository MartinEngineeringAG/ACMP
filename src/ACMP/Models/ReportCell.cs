using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public class ReportCell
    {
        public ReportColumn Column { get; set; } = default!;

        [JsonConverter(typeof(InferredObjectJsonConverter))]
        public object? Value { get; set; }
    }
}
