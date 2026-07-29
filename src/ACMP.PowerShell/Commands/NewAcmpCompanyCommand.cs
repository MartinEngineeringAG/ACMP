using System;
using System.Management.Automation;
using ACMP.Enums;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.New, "ACMPCompany", DefaultParameterSetName = "ByParameter")]
    [OutputType(typeof(CompanyGetResponse))]
    public class NewAcmpCompanyCommand : AcmpCmdlet
    {
        [Parameter(ParameterSetName = "ByRequest", Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public CompanyCreateRequest Request { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        public long ParentAccountId { get; set; }

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Address { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string City { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string CompanyName { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Country { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string[] Domain { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Email { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public long[] Marketplaces { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Zip { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter")]
        public string? ContractId { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? PurchaseOrderNumber { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? CrefoNumber { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? CustomerId { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public BankDetails? BankDetails { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? CompanyContractEndDate { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? VATID { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? TechnicalEmail { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? ContactPhone { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? TehnicalAccountManager { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? ReferenceNumber { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? State { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? TechnicalContact { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? ContactPerson { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public long? Marketplace { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public SwitchParameter CreateDefaultAdminUser { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public long[]? ParentRoleList { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public Industry? Industry { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var request = ParameterSetName == "ByRequest" ? Request : BuildRequest();
                var response = client.CreateCompanyAsync(request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "NewAcmpCompanyFailed");
            }
        }

        private CompanyCreateRequest BuildRequest()
        {
            var company = new CompanyCreateRequestCompanyAccount
            {
                ParentAccountId = ParentAccountId,
                Address = Address,
                City = City,
                CompanyName = CompanyName,
                Country = Country,
                Email = Email,
                Zip = Zip,
                ContractId = ContractId,
                PurchaseOrderNumber = PurchaseOrderNumber,
                CrefoNumber = CrefoNumber,
                CustomerId = CustomerId,
                BankDetails = BankDetails,
                CompanyContractEndDate = CompanyContractEndDate,
                VATID = VATID,
                TechnicalEmail = TechnicalEmail,
                ContactPhone = ContactPhone,
                TehnicalAccountManager = TehnicalAccountManager,
                ReferenceNumber = ReferenceNumber,
                State = State,
                TechnicalContact = TechnicalContact,
                ContactPerson = ContactPerson,
                Marketplace = Marketplace,
                ParentRoleList = ParentRoleList is null ? null : new System.Collections.Generic.List<long>(ParentRoleList),
                Industry = Industry
            };

            company.Domain.AddRange(Domain);
            company.Marketplaces.AddRange(Marketplaces);

            if (MyInvocation.BoundParameters.ContainsKey(nameof(CreateDefaultAdminUser)))
            {
                company.CreateDefaultAdminUser = CreateDefaultAdminUser.ToBool();
            }

            return new CompanyCreateRequest { CompanyAccount = company };
        }
    }
}
