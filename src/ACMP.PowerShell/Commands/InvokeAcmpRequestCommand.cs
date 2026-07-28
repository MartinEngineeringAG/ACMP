using System;
using System.Management.Automation;

namespace ACMP.Commands
{
    [Cmdlet(VerbsLifecycle.Invoke, "ACMPRequest")]
    [OutputType(typeof(object))]
    public class InvokeAcmpRequestCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        [ValidateNotNullOrEmpty]
        public string Path { get; set; } = default!;

        [Parameter(Position = 1)]
        public object? Body { get; set; }

        [Parameter]
        public Type? ResponseType { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.PostAsync(Path, Body, ResponseType, CancellationToken).GetAwaiter().GetResult();
                if (response != null)
                {
                    WriteObject(response);
                }
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "InvokeAcmpRequestFailed");
            }
        }
    }
}
