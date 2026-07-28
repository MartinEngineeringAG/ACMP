using System;
using System.Management.Automation;
using System.Net;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommunications.Connect, "ACMP")]
    [OutputType(typeof(AcmpClient))]
    public class ConnectAcmpCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNull]
        public Uri BaseUri { get; set; } = default!;

        [Parameter(Mandatory = true)]
        [Credential]
        [ValidateNotNull]
        public PSCredential Credential { get; set; } = default!;

        protected override void ProcessRecord()
        {
            var client = new AcmpClient(BaseUri);

            try
            {
                NetworkCredential networkCredential = Credential.GetNetworkCredential();
                client.ConnectAsync(networkCredential.UserName, networkCredential.Password, CancellationToken).GetAwaiter().GetResult();
                AcmpSession.SetCurrent(client);
                WriteObject(client);
            }
            catch (Exception exception)
            {
                client.Dispose();
                ThrowApiError(exception, "ConnectAcmpFailed");
            }
        }
    }
}
