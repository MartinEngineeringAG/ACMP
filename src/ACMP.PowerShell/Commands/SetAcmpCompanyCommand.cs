using System;
using System.Management.Automation;
using ACMP.Enums;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Set, "ACMPCompany", DefaultParameterSetName = "ByParameter")]
    public class SetAcmpCompanyCommand : AcmpCmdlet
    {
        [Parameter(ParameterSetName = "ByRequest", Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public CompanyUpdateRequest Request { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        public long AccountId { get; set; }

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
        public string[] Domain { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Email { get; set; } = default!;

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
        public long[]? Marketplaces { get; set; }

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
        public string? Salesman { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public Industry? Industry { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var request = ParameterSetName == "ByRequest" ? Request : BuildRequest();
                client.UpdateCompanyAsync(request, CancellationToken).GetAwaiter().GetResult();
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "SetAcmpCompanyFailed");
            }
        }

        private CompanyUpdateRequest BuildRequest()
        {
            var company = new CompanyUpdateRequestCompany
            {
                AccountId = AccountId,
                Address = Address,
                City = City,
                CompanyName = CompanyName,
                Email = Email,
                Zip = Zip,
                ContractId = ContractId,
                PurchaseOrderNumber = PurchaseOrderNumber,
                CrefoNumber = CrefoNumber,
                CustomerId = CustomerId,
                BankDetails = BankDetails,
                CompanyContractEndDate = CompanyContractEndDate,
                Marketplaces = Marketplaces is null ? null : new System.Collections.Generic.List<long>(Marketplaces),
                VATID = VATID,
                TechnicalEmail = TechnicalEmail,
                ContactPhone = ContactPhone,
                TehnicalAccountManager = TehnicalAccountManager,
                ReferenceNumber = ReferenceNumber,
                State = State,
                TechnicalContact = TechnicalContact,
                ContactPerson = ContactPerson,
                Salesman = Salesman,
                Industry = Industry
            };

            company.Domain.AddRange(Domain);

            return new CompanyUpdateRequest { Company = company };
        }
    }
}
