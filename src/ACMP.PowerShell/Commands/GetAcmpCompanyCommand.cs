using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPCompany", DefaultParameterSetName = "ByAccountId")]
    [OutputType(typeof(CompanyGetResponse))]
    public class GetAcmpCompanyCommand : AcmpCmdlet
    {
        [Parameter(ParameterSetName = "ByAccountId", Position = 0)]
        public long? AccountId { get; set; }

        [Parameter(ParameterSetName = "ByRequest", Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetCompanyRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var request = ParameterSetName == "ByRequest"
                    ? Request
                    : new GetCompanyRequest { AccountId = AccountId };

                var response = client.GetCompanyAsync(request, CancellationToken).GetAwaiter().GetResult();
                if (response?.Items == null)
                {
                    return;
                }

                foreach (var company in response.Items)
                {
                    WriteObject(company);
                }
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpCompanyFailed");
            }
        }
    }
}
