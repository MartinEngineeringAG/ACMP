using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using ACMP.Models;

namespace ACMP.Commands
{
    [Cmdlet(VerbsCommon.New, "ACMPSubscription", DefaultParameterSetName = "ByParameter")]
    [OutputType(typeof(Subscription))]
    public class NewAcmpSubscriptionCommand : AcmpCmdlet
    {
        [Parameter(ParameterSetName = "ByRequest", Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNull]
        public CreateSubscription Request { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        public long ParentAccountId { get; set; }

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ServiceName { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter", Mandatory = true)]
        [ValidateNotNull]
        public Hashtable Fields { get; set; } = default!;

        [Parameter(ParameterSetName = "ByParameter")]
        public string? ContractId { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? PurchaseOrderNumber { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public long? DependencyAccountId { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? QuoteId { get; set; }

        [Parameter(ParameterSetName = "ByParameter")]
        public string? ScheduledDate { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                var client = AcmpSession.GetCurrent();
                var request = ParameterSetName == "ByRequest" ? Request : BuildRequest();
                var response = client.CreateSubscriptionAsync(request, CancellationToken).GetAwaiter().GetResult();
                WriteResponseObject(response);
            }
            catch (Exception exception)
            {
                ThrowApiError(exception, "NewAcmpSubscriptionFailed");
            }
        }

        private CreateSubscription BuildRequest()
        {
            return new CreateSubscription
            {
                SubscriptionAccount = new CreateSubscriptionSubscriptionAccount
                {
                    ParentAccountId = ParentAccountId,
                    ServiceName = ServiceName,
                    Fields = ConvertToDictionary(Fields),
                    ContractId = ContractId,
                    PurchaseOrderNumber = PurchaseOrderNumber,
                    DependencyAccountId = DependencyAccountId,
                    QuoteId = QuoteId,
                    ScheduledDate = ScheduledDate
                }
            };
        }

        private static Dictionary<string, object?> ConvertToDictionary(Hashtable hashtable)
        {
            var dictionary = new Dictionary<string, object?>(StringComparer.Ordinal);
            foreach (DictionaryEntry entry in hashtable)
            {
                dictionary.Add(entry.Key.ToString() ?? string.Empty, entry.Value);
            }

            return dictionary;
        }
    }
}
