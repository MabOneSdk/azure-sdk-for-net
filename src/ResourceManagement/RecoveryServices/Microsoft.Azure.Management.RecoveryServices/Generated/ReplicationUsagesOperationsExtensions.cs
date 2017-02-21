// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices
{
    using Azure;
    using Management;
    using Rest;
   using Rest.Azure;
   using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReplicationUsagesOperations.
    /// </summary>
    public static partial class ReplicationUsagesOperationsExtensions
    {
            /// <summary>
            /// Fetches the replication usages of the vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            public static IEnumerable<ReplicationUsage> List(this IReplicationUsagesOperations operations, string vaultName, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IReplicationUsagesOperations)s).ListAsync(vaultName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Fetches the replication usages of the vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ReplicationUsage>> ListAsync(this IReplicationUsagesOperations operations, string vaultName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(vaultName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

