using System;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.Set, "ACMPSecurityRolesUsers")]
    [OutputType(typeof(SimpleRole))]
    public class SetAcmpSecurityRolesUsersCommand : AcmpCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public SimpleUpdateRoleUsers Request { get; set; } = default!;

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var response = client.UpdateSecurityRolesUsersAsync(Request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "SetAcmpSecurityRolesUsersFailed");
            }
        }
    }
}
