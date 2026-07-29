using System.Text.Json.Serialization;

namespace ACMP.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AdvancePeriodEndAction
    {
        Renew,
        Terminate
    }
}
