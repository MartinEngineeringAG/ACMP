using System;
using System.Threading;
using System.Threading.Tasks;
using ACMP.Models;

namespace ACMP
{
    public partial class AcmpClient
    {
        public Task<ResellerGetResponse?> CreateResellerAsync(ResellerCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<ResellerGetResponse>("/CreateReseller", request, cancellationToken);
        }

        public async Task UpdateResellerAsync(ResellerUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/UpdateReseller", request, null, cancellationToken).ConfigureAwait(false);
        }

        public Task<CompanyGetResponse?> CreateCompanyAsync(CompanyCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<CompanyGetResponse>("/CreateCompany", request, cancellationToken);
        }

        public async Task UpdateCompanyAsync(CompanyUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/UpdateCompany", request, null, cancellationToken).ConfigureAwait(false);
        }

        public Task<GetCompanyResponse?> GetCompanyAsync(long? accountId = null, CancellationToken cancellationToken = default)
        {
            return GetCompanyAsync(new GetCompanyRequest { AccountId = accountId }, cancellationToken);
        }

        public Task<GetCompanyResponse?> GetCompanyAsync(GetCompanyRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetCompanyResponse>("/GetCompany", request, cancellationToken);
        }

        public Task<GetCompaniesResponse?> GetCompaniesAsync(long parentAccountId, CancellationToken cancellationToken = default)
        {
            return GetCompaniesAsync(new GetCompaniesRequest { ParentAccountId = parentAccountId }, cancellationToken);
        }

        public Task<GetCompaniesResponse?> GetCompaniesAsync(CancellationToken cancellationToken = default)
        {
            return PostAsync<GetCompaniesResponse>("/GetCompanies", new { }, cancellationToken);
        }

        public Task<GetCompaniesResponse?> GetCompaniesAsync(GetCompaniesRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetCompaniesResponse>("/GetCompanies", request, cancellationToken);
        }

        public Task<Subscription?> GetSubscriptionAsync(GetSubscriptionRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<Subscription>("/GetSubscription", request, cancellationToken);
        }

        public Task<Subscription?> GetSubscriptionWithAddonsAsync(GetSubscriptionRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<Subscription>("/GetSubscriptionWithAddons", request, cancellationToken);
        }

        public Task<GetSubscriptionsResponse?> GetSubscriptionsAsync(long parentAccountId, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionsAsync(new GetSubscriptionsRequest { ParentAccountId = parentAccountId }, cancellationToken);
        }

        public Task<GetSubscriptionsResponse?> GetSubscriptionsAsync(GetSubscriptionsRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetSubscriptionsResponse>("/GetSubscriptions", request, cancellationToken);
        }

        public Task<GetSubscriptionDependenciesResponse?> GetSubscriptionDependenciesAsync(GetSubscriptionDependenciesRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetSubscriptionDependenciesResponse>("/GetSubscriptionDependencies", request, cancellationToken);
        }

        public Task<GetPossibleServicesForParentResponse?> GetPossibleServicesForParentAsync(GetPossibleServicesForParentRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetPossibleServicesForParentResponse>("/GetPossibleServicesForParent", request, cancellationToken);
        }

        public Task<SubscriptionInputDefinition?> GetFieldsForServiceAsync(GetFieldsForServiceRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<SubscriptionInputDefinition>("/GetFieldsForService", request, cancellationToken);
        }

        public Task<ValidationResult?> ValidateFieldsAsync(ValidateFields request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<ValidationResult>("/ValidateFields", request, cancellationToken);
        }

        public Task<GetRemoteEnumsResponse?> GetRemoteEnumsAsync(GetRemoteEnumsRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetRemoteEnumsResponse>("/GetRemoteEnums", request, cancellationToken);
        }

        public Task<Subscription?> CreateSubscriptionAsync(CreateSubscription request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<Subscription>("/CreateSubscription", request, cancellationToken);
        }

        public async Task UpdateSubscriptionAsync(UpdateSubscription request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/UpdateSubscription", request, null, cancellationToken).ConfigureAwait(false);
        }

        public async Task SetCreditLimitAsync(SetCreditLimitRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/SetCreditLimit", request, null, cancellationToken).ConfigureAwait(false);
        }

        public Task<SimpleCreditLimitRecord?> GetCreditLimitAsync(GetCreditLimitRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<SimpleCreditLimitRecord>("/GetCreditLimit", request, cancellationToken);
        }

        public Task<ListCreditCheckOrdersForApprovalResponse?> ListCreditCheckOrdersForApprovalAsync(CancellationToken cancellationToken = default)
        {
            return PostAsync<ListCreditCheckOrdersForApprovalResponse>("/ListCreditCheckOrdersForApproval", new { }, cancellationToken);
        }

        public async Task ApproveCreditCheckOrderAsync(CreditCheckInfo request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/ApproveCreditCheckOrder", request, null, cancellationToken).ConfigureAwait(false);
        }

        public async Task DeclineCreditCheckOrderAsync(CreditCheckInfo request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/DeclineCreditCheckOrder", request, null, cancellationToken).ConfigureAwait(false);
        }

        public Task<GetAccountCustomActionsWithFieldsResponse?> GetAccountCustomActionsWithFieldsAsync(GetAccountCustomActionsWithFieldsRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetAccountCustomActionsWithFieldsResponse>("/GetAccountCustomActionsWithFields", request, cancellationToken);
        }

        public Task<GetRemoteEnumValuesForCustomActionResponse?> GetRemoteEnumValuesForCustomActionAsync(GetRemoteEnumValuesForCustomActionBody request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetRemoteEnumValuesForCustomActionResponse>("/GetRemoteEnumValuesForCustomAction", request, cancellationToken);
        }

        public async Task ExecuteAccountCustomActionAsync(ExecuteAccountCustomActionRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/ExecuteAccountCustomAction", request, null, cancellationToken).ConfigureAwait(false);
        }

        public Task<User?> GetUserAsync(GetUserRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<User>("/GetUser", request, cancellationToken);
        }

        public Task<Users?> GetUsersAsync(GetUsersRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<Users>("/GetUsers", request, cancellationToken);
        }

        public Task<User?> CreateUserAsync(CreateUserRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<User>("/CreateUser", request, cancellationToken);
        }

        public async Task TerminateAccountAsync(TerminateAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/TerminateAccount", request, null, cancellationToken).ConfigureAwait(false);
        }

        public Task<GetReportsResponse?> GetReportsAsync(CancellationToken cancellationToken = default)
        {
            return PostAsync<GetReportsResponse>("/GetReports", new { }, cancellationToken);
        }

        public Task<ReportResult?> ExecuteReportAsync(ExecuteReportRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<ReportResult>("/ExecuteReport", request, cancellationToken);
        }

        public Task<GetMarketplacesResponse?> GetMarketplacesAsync(CancellationToken cancellationToken = default)
        {
            return PostAsync<GetMarketplacesResponse>("/GetMarketplaces", new { }, cancellationToken);
        }

        public Task<GetAvailableServicesForMarketplaceResponse?> GetAvailableServicesForMarketplaceAsync(GetAvailableServicesForMarketplaceRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetAvailableServicesForMarketplaceResponse>("/GetAvailableServicesForMarketplace", request, cancellationToken);
        }

        public Task<AddMarketplaceServicesResponse?> AddMarketplaceServicesAsync(AddMarketplaceServicesRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<AddMarketplaceServicesResponse>("/AddMarketplaceServices", request, cancellationToken);
        }

        public Task<DeleteMarketplaceServicesResponse?> DeleteMarketplaceServicesAsync(DeleteMarketplaceServicesRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<DeleteMarketplaceServicesResponse>("/DeleteMarketplaceServices", request, cancellationToken);
        }

        public Task<DeleteMarketplaceServiceResponse?> DeleteMarketplaceServiceAsync(DeleteMarketplaceServiceRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<DeleteMarketplaceServiceResponse>("/DeleteMarketplaceService", request, cancellationToken);
        }

        public Task<GetMarketplaceServiceChargesResponse?> GetMarketplaceServiceChargesAsync(GetMarketplaceServiceChargesRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetMarketplaceServiceChargesResponse>("/GetMarketplaceServiceCharges", request, cancellationToken);
        }

        public Task<UpdateMarketplaceServiceChargesResponse?> UpdateMarketplaceServiceChargesAsync(UpdateMarketplaceServiceChargesRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<UpdateMarketplaceServiceChargesResponse>("/UpdateMarketplaceServiceCharges", request, cancellationToken);
        }

        public Task<MarketplaceInfo?> CreateMarketplaceAsync(CreateMarketplaceRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<MarketplaceInfo>("/CreateMarketplace", request, cancellationToken);
        }

        public async Task DeleteMarketplaceAsync(DeleteMarketplaceRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/DeleteMarketplace", request, null, cancellationToken).ConfigureAwait(false);
        }

        public Task<GetSpecialProductTermsForServiceResponse?> GetSpecialProductTermsForServiceAsync(GetSpecialProductTermsForServiceRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetSpecialProductTermsForServiceResponse>("/GetSpecialProductTermsForService", request, cancellationToken);
        }

        public async Task AcceptTermsForMarketplaceServiceAsync(AcceptTermsForMarketplaceServiceRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/AcceptTermsForMarketplaceService", request, null, cancellationToken).ConfigureAwait(false);
        }

        public Task<ListMarketplaceServicesResponse?> ListMarketplaceServicesAsync(ListMarketplaceServicesRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<ListMarketplaceServicesResponse>("/ListMarketplaceServices", request, cancellationToken);
        }

        public Task<UpdateMarketplaceServicesResponse?> UpdateMarketplaceServicesAsync(UpdateMarketplaceServicesRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<UpdateMarketplaceServicesResponse>("/UpdateMarketplaceServices", request, cancellationToken);
        }

        public Task<GetResellerResponse?> GetResellerAsync(GetResellerRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetResellerResponse>("/GetReseller", request, cancellationToken);
        }

        public Task<GetResellersResponse?> GetResellersAsync(GetResellersRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetResellersResponse>("/GetResellers", request, cancellationToken);
        }

        public Task<Departments?> CreateDepartmentAsync(CreateDepartmentRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<Departments>("/CreateDepartment", request, cancellationToken);
        }

        public async Task UpdateDepartmentAsync(UpdateDepartmentRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/UpdateDepartment", request, null, cancellationToken).ConfigureAwait(false);
        }

        public Task<Departments?> GetDepartmentAsync(GetDepartmentRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<Departments>("/GetDepartment", request, cancellationToken);
        }

        public Task<GetDepartmentsResponse?> GetDepartmentsAsync(GetCompaniesRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetDepartmentsResponse>("/GetDepartments", request, cancellationToken);
        }

        public Task<GetResellerByVatIdResponse?> GetResellerByVatIdAsync(GetResellerByVatIdRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetResellerByVatIdResponse>("/GetResellerByVatId", request, cancellationToken);
        }

        public Task<GetCompanyByVatIdResponse?> GetCompanyByVatIdAsync(GetCompanyByVatIdRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetCompanyByVatIdResponse>("/GetCompanyByVatId", request, cancellationToken);
        }

        public Task<GetLatestInvoicesResponse?> GetLatestInvoicesAsync(GetLatestInvoicesRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetLatestInvoicesResponse>("/GetLatestInvoices", request, cancellationToken);
        }

        public Task<InvoiceAggregationResponse?> GetInvoiceAggregationReportAsync(GetInvoiceAggregationReportRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<InvoiceAggregationResponse>("/GetInvoiceAggregationReport", request, cancellationToken);
        }

        public Task<AllProductAccountsWithFieldsReportResponse?> GetAllProductAccountsWithFieldsReportAsync(AllProductAccountsWithFieldsReportRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<AllProductAccountsWithFieldsReportResponse>("/GetAllProductAccountsWithFieldsReport", request, cancellationToken);
        }

        public Task<GetLatestInvoicesForPeriodResponse?> GetLatestInvoicesForPeriodAsync(GetLatestInvoicesForPeriodRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetLatestInvoicesForPeriodResponse>("/GetLatestInvoicesForPeriod", request, cancellationToken);
        }

        public Task<GetSecurityRolesResponse?> GetSecurityRolesAsync(GetSecurityRolesRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetSecurityRolesResponse>("/GetSecurityRoles", request, cancellationToken);
        }

        public Task<SimpleRole?> UpdateSecurityRolesUsersAsync(SimpleUpdateRoleUsers request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<SimpleRole>("/UpdateSecurityRolesUsers", request, cancellationToken);
        }

        public async Task RetryLastFailedProvisioningAsync(RetryLastFailedProvisioningRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/RetryLastFailedProvisioning", request, null, cancellationToken).ConfigureAwait(false);
        }

        public Task<GetPreviewInvoicesResponse?> GetPreviewInvoicesAsync(GetPreviewInvoicesRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetPreviewInvoicesResponse>("/GetPreviewInvoices", request, cancellationToken);
        }

        public async Task UpdateUserAsync(UpdateUser request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/UpdateUser", request, null, cancellationToken).ConfigureAwait(false);
        }

        public Task<ServiceInformation?> GetServiceInformationAsync(GetServiceInformationRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<ServiceInformation>("/GetServiceInformation", request, cancellationToken);
        }

        public Task<PossibleUpgradeServices?> GetPossibleServicesForUpgradeAsync(GetPossibleServicesForUpgradeRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<PossibleUpgradeServices>("/GetPossibleServicesForUpgrade", request, cancellationToken);
        }

        public Task<PossibleUpgradeRenewFields?> GetSubscriptionFieldsForUpgradeAsync(GetProductFieldsForUpgradeRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<PossibleUpgradeRenewFields>("/GetSubscriptionFieldsForUpgrade", request, cancellationToken);
        }

        public Task<ExecuteSubscriptionUpgradeResponse?> ExecuteSubscriptionUpgradeAsync(ExecuteProductUpgradeRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<ExecuteSubscriptionUpgradeResponse>("/ExecuteSubscriptionUpgrade", request, cancellationToken);
        }

        public Task<PossibleUpgradeRenewFields?> GetSubscriptionFieldsForRenewAsync(GetSubscriptionFieldsForRenewRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<PossibleUpgradeRenewFields>("/GetSubscriptionFieldsForRenew", request, cancellationToken);
        }

        public async Task ConfigureSubscriptionRenewAsync(ConfigureSubscriptionRenewRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/ConfigureSubscriptionRenew", request, null, cancellationToken).ConfigureAwait(false);
        }

        public async Task ResetDefaultRenewValuesAsync(ResetDefaultRenewValuesRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/ResetDefaultRenewValues", request, null, cancellationToken).ConfigureAwait(false);
        }

        public Task<GetSpecialDealResponse?> GetSpecialDealAsync(GetSpecialDealRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<GetSpecialDealResponse>("/GetSpecialDeal", request, cancellationToken);
        }

        public Task<SimpleSpecialDealResponse?> SetSpecialDealAsync(SetSpecialDealRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return PostAsync<SimpleSpecialDealResponse>("/SetSpecialDeal", request, cancellationToken);
        }

        public async Task DeleteSpecialDealAsync(DeleteSpecialDealRequest request, CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            await PostAsync("/DeleteSpecialDeal", request, null, cancellationToken).ConfigureAwait(false);
        }

    }
}
