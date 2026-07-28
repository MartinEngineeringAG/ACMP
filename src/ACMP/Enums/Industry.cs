using System.Text.Json.Serialization;

namespace ACMP.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Industry
    {
        [JsonStringEnumMemberName("Accommodation and Food Services")]
        AccommodationAndFoodServices,

        [JsonStringEnumMemberName("Administrative and Support and Waste Management and Remediation Services")]
        AdministrativeAndSupportAndWasteManagementAndRemediationServices,

        [JsonStringEnumMemberName("Agriculture, Forestry, Fishing and Hunting")]
        AgricultureForestryFishingAndHunting,

        [JsonStringEnumMemberName("Arts, Entertainment, and Recreation")]
        ArtsEntertainmentAndRecreation,

        Construction,

        [JsonStringEnumMemberName("Educational Services")]
        EducationalServices,

        [JsonStringEnumMemberName("Finance and Insurance")]
        FinanceAndInsurance,

        [JsonStringEnumMemberName("Health Care and Social Assistance")]
        HealthCareAndSocialAssistance,

        Information,

        [JsonStringEnumMemberName("Management of Companies and Enterprises")]
        ManagementOfCompaniesAndEnterprises,

        Manufacturing,

        [JsonStringEnumMemberName("Mining, Quarrying, and Oil and Gas Extraction")]
        MiningQuarryingAndOilAndGasExtraction,

        [JsonStringEnumMemberName("Other Services (except Public Administration")]
        OtherServicesExceptPublicAdministration,

        [JsonStringEnumMemberName("Professional, Scientific, and Technical Service")]
        ProfessionalScientificAndTechnicalService,

        [JsonStringEnumMemberName("Public Administration")]
        PublicAdministration,

        [JsonStringEnumMemberName("Real Estate and Rental and Leasing")]
        RealEstateAndRentalAndLeasing,

        [JsonStringEnumMemberName("Retail Trade")]
        RetailTrade,

        [JsonStringEnumMemberName("Transportation and Warehousing")]
        TransportationAndWarehousing,

        Utilities,

        [JsonStringEnumMemberName("Wholesale Trade")]
        WholesaleTrade
    }
}
