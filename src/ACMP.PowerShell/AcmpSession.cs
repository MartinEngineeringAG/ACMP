using System;
using System.Collections.Concurrent;
using System.Management.Automation.Runspaces;

namespace ACMP
{
    internal static class AcmpSession
    {
        private static readonly ConcurrentDictionary<Guid, AcmpClient> Clients = new ConcurrentDictionary<Guid, AcmpClient>();

        public static void SetCurrent(AcmpClient client)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            ClearCurrent(dispose: true);
            Clients[GetRunspaceId()] = client;
        }

        public static AcmpClient GetCurrent()
        {
            if (Clients.TryGetValue(GetRunspaceId(), out var client))
            {
                return client;
            }

            throw new InvalidOperationException("No ALSO Marketplace connection is active. Run Connect-ACMP first.");
        }

        public static bool TryGetCurrent(out AcmpClient? client)
        {
            return Clients.TryGetValue(GetRunspaceId(), out client);
        }

        public static void ClearCurrent(bool dispose)
        {
            if (!Clients.TryRemove(GetRunspaceId(), out var client))
            {
                return;
            }

            if (dispose)
            {
                client.Dispose();
            }
        }

        private static Guid GetRunspaceId()
        {
            return Runspace.DefaultRunspace?.InstanceId ?? Guid.Empty;
        }
    }
}
