using System;

namespace ACMP
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class UndocumentedApiPropertyAttribute : Attribute
    {
        public UndocumentedApiPropertyAttribute(string reason)
        {
            Reason = reason ?? throw new ArgumentNullException(nameof(reason));
        }

        public string Reason { get; }
    }
}
