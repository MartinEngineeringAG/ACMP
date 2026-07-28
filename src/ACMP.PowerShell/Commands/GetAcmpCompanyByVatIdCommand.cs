using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Get, "ACMPCompanyByVatId", DefaultParameterSetName = "ByVatId")]
    [OutputType(typeof(CompanyGetResponse))]
    public class GetAcmpCompanyByVatIdCommand : AcmpCmdlet
    {
        [Parameter(ParameterSetName = "ByRequest", Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public GetCompanyByVatIdRequest Request { get; set; } = default!;

        [Parameter(ParameterSetName = "ByVatId", Mandatory = true, Position = 0)]
        [ValidateNotNullOrEmpty]
        public string VatId { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var request = ParameterSetName == "ByRequest"
                    ? Request
                    : new GetCompanyByVatIdRequest { VatId = VatId };

                var response = client.GetCompanyByVatIdAsync(request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "GetAcmpCompanyByVatIdFailed");
            }
        }
    }
}
