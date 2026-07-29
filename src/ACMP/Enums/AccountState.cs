using System.Text.Json.Serialization;

namespace ACMP.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AccountState
    {
        Active,
        Terminated
    }
}
