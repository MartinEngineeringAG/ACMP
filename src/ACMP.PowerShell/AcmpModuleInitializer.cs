using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Management.Automation;

namespace ACMP
{
    public sealed class AcmpModuleInitializer : IModuleAssemblyInitializer
    {
        public void OnImport()
        {
            if (AppDomain.CurrentDomain.GetAssemblies().Any(assembly => assembly.GetName().Name == "ACMP"))
            {
                return;
            }

            var moduleDirectory = Path.GetDirectoryName(typeof(AcmpModuleInitializer).Assembly.Location);
            if (string.IsNullOrWhiteSpace(moduleDirectory))
            {
                return;
            }

            var clientAssemblyPath = Path.Combine(moduleDirectory, "ACMP.dll");
            if (File.Exists(clientAssemblyPath))
            {
                Assembly.LoadFrom(clientAssemblyPath);
            }
        }
    }
}
