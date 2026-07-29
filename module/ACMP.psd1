@{
    RootModule             = 'ACMP.PowerShell.dll'
    ModuleVersion          = '0.0.0'
    GUID                   = '2e502246-c898-4813-bb81-310cc18acd2e'
    Author                 = 'Martin Engineering AG'
    CompanyName            = 'Martin Engineering AG'
    Copyright              = 'Copyright (c) 2026 Martin Engineering AG'
    Description            = 'PowerShell client for the ALSO Cloud Marketplace Simple API.'
    PowerShellVersion      = '5.1'
    CompatiblePSEditions   = @('Desktop', 'Core')
    CmdletsToExport        = @(
        'Add-ACMPMarketplaceServices',
        'Connect-ACMP',
        'Disconnect-ACMP',
        'Get-ACMPAccountCustomActionsWithFields',
        'Get-ACMPAllProductAccountsWithFieldsReport',
        'Get-ACMPAvailableServicesForMarketplace',
        'Get-ACMPCompanies',
        'Get-ACMPCompany',
        'Get-ACMPCompanyByVatId',
        'Get-ACMPCreditCheckOrdersForApproval',
        'Get-ACMPCreditLimit',
        'Get-ACMPDepartment',
        'Get-ACMPDepartments',
        'Get-ACMPFieldsForService',
        'Get-ACMPInvoiceAggregationReport',
        'Get-ACMPLatestInvoices',
        'Get-ACMPLatestInvoicesForPeriod',
        'Get-ACMPMarketplaces',
        'Get-ACMPMarketplaceServiceCharges',
        'Get-ACMPMarketplaceServices',
        'Get-ACMPPossibleServicesForParent',
        'Get-ACMPPossibleServicesForUpgrade',
        'Get-ACMPPreviewInvoices',
        'Get-ACMPRemoteEnums',
        'Get-ACMPRemoteEnumValuesForCustomAction',
        'Get-ACMPReports',
        'Get-ACMPReseller',
        'Get-ACMPResellerByVatId',
        'Get-ACMPResellers',
        'Get-ACMPSecurityRoles',
        'Get-ACMPServiceInformation',
        'Get-ACMPSpecialDeal',
        'Get-ACMPSpecialProductTermsForService',
        'Get-ACMPSubscription',
        'Get-ACMPSubscriptionDependencies',
        'Get-ACMPSubscriptionFieldsForRenew',
        'Get-ACMPSubscriptionFieldsForUpgrade',
        'Get-ACMPSubscriptions',
        'Get-ACMPSubscriptionWithAddons',
        'Get-ACMPUser',
        'Get-ACMPUsers',
        'Invoke-ACMPAcceptTermsForMarketplaceService',
        'Invoke-ACMPAccountCustomAction',
        'Invoke-ACMPApproveCreditCheckOrder',
        'Invoke-ACMPDeclineCreditCheckOrder',
        'Invoke-ACMPReport',
        'Invoke-ACMPRequest',
        'Invoke-ACMPRetryLastFailedProvisioning',
        'Invoke-ACMPSubscriptionUpgrade',
        'New-ACMPCompany',
        'New-ACMPDepartment',
        'New-ACMPMarketplace',
        'New-ACMPReseller',
        'New-ACMPSubscription',
        'New-ACMPUser',
        'Remove-ACMPMarketplace',
        'Remove-ACMPMarketplaceService',
        'Remove-ACMPMarketplaceServices',
        'Remove-ACMPSpecialDeal',
        'Reset-ACMPDefaultRenewValues',
        'Set-ACMPCompany',
        'Set-ACMPCreditLimit',
        'Set-ACMPDepartment',
        'Set-ACMPMarketplaceServiceCharges',
        'Set-ACMPMarketplaceServices',
        'Set-ACMPReseller',
        'Set-ACMPSecurityRolesUsers',
        'Set-ACMPSpecialDeal',
        'Set-ACMPSubscription',
        'Set-ACMPSubscriptionRenew',
        'Set-ACMPUser',
        'Stop-ACMPAccount',
        'Test-ACMPConnection',
        'Test-ACMPFields'
    )
    FunctionsToExport      = @()
    VariablesToExport      = @()
    AliasesToExport        = @()

    PrivateData = @{
        PSData = @{
            Tags                     = @('ALSO', 'ALSOMarketplace', 'ALSOCloudMarketplace')
            LicenseUri               = 'https://github.com/MartinEngineeringAG/ACMP/blob/main/LICENSE'
            ProjectUri               = 'https://github.com/MartinEngineeringAG/ACMP'
            RequireLicenseAcceptance = $false
        }
    }
}
