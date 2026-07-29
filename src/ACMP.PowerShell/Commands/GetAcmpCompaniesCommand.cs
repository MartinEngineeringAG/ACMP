using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPCompanies", DefaultParameterSetName = "All")]
    [OutputType(typeof(CompanyGetResponse))]
    public class GetAcmpCompaniesCommand : AcmpCmdlet
    {
        [Parameter(ParameterSetName = "ByParentAccountId", Mandatory = true, Position = 0)]
        public long ParentAccountId { get; set; }

        [Parameter(ParameterSetName = "ByRequest", Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetCompaniesRequest Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = ParameterSetName == "All"
                    ? client.GetCompaniesAsync(CancellationToken).GetAwaiter().GetResult()
                    : ParameterSetName == "ByRequest"
                        ? client.GetCompaniesAsync(Request, CancellationToken).GetAwaiter().GetResult()
                        : client.GetCompaniesAsync(ParentAccountId, CancellationToken).GetAwaiter().GetResult();

                if (response?.Items is null)
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
                ThrowApiError(exception, "GetAcmpCompaniesFailed");
            }
        }
    }
}
