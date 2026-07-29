using System;
using System.Collections;
using System.Management.Automation;
using System.Threading;

namespace ACMP.Commands
{
    public abstract class AcmpCmdlet : PSCmdlet
    {
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        protected CancellationToken CancellationToken => _cancellationTokenSource.Token;

        protected override void StopProcessing()
        {
            _cancellationTokenSource.Cancel();
            base.StopProcessing();
        }

        protected void ThrowApiError(Exception exception, string errorId)
        {
            var category = exception is InvalidOperationException
                ? ErrorCategory.InvalidOperation
                : ErrorCategory.NotSpecified;

            if (exception is AcmpApiException apiException)
            {
                category = ErrorCategory.InvalidOperation;
                var errorRecord = new ErrorRecord(apiException, errorId, category, apiException.RequestUri);
                errorRecord.ErrorDetails = new ErrorDetails(BuildApiErrorDetails(apiException));
                ThrowTerminatingError(errorRecord);
                return;
            }

            ThrowTerminatingError(new ErrorRecord(exception, errorId, category, null));
        }

        protected void WriteResponseObject(object? response)
        {
            if (response is null)
            {
                return;
            }

            var itemsProperty = response.GetType().GetProperty("Items");
            if (itemsProperty?.GetValue(response) is IEnumerable items && !(response is string))
            {
                foreach (var item in items)
                {
                    WriteObject(item);
                }

                return;
            }

            WriteObject(response);
        }

        private static string BuildApiErrorDetails(AcmpApiException exception)
        {
            var details = $"RequestUri: {exception.RequestUri}; StatusCode: {(int)exception.StatusCode}; ContentType: {exception.ContentType ?? "<none>"}";
            if (!string.IsNullOrWhiteSpace(exception.ResponseBody))
            {
                details += $"; ResponseBody: {exception.ResponseBody}";
            }

            return details;
        }
    }
}
