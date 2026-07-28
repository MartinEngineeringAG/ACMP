using System.Text.Json.Serialization;

namespace ACMP.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AccountType
    {
        User,
        Company,
        Reseller,
        Product,
        Department
    }
}
