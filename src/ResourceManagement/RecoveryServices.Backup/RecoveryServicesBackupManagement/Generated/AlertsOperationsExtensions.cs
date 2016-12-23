// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for AlertsOperations.
    /// </summary>
    public static partial class AlertsOperationsExtensions
    {
            /// <summary>
            /// Returns all Alerts for the given resource.
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
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<AlertResponsePropertiesResource> List(this IAlertsOperations operations, string vaultName, string resourceGroupName, Microsoft.Rest.Azure.OData.ODataQuery<AlertsQueryRequest> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<AlertsQueryRequest>))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAlertsOperations)s).ListAsync(vaultName, resourceGroupName, odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns all Alerts for the given resource.
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
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<AlertResponsePropertiesResource>> ListAsync(this IAlertsOperations operations, string vaultName, string resourceGroupName, Microsoft.Rest.Azure.OData.ODataQuery<AlertsQueryRequest> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<AlertsQueryRequest>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(vaultName, resourceGroupName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns details of specific Alert.
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
            /// <param name='uniqueAlertId'>
            /// Unique identifier for the alert.
            /// </param>
            public static AlertResponsePropertiesResource Get(this IAlertsOperations operations, string vaultName, string resourceGroupName, string uniqueAlertId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAlertsOperations)s).GetAsync(vaultName, resourceGroupName, uniqueAlertId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns details of specific Alert.
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
            /// <param name='uniqueAlertId'>
            /// Unique identifier for the alert.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<AlertResponsePropertiesResource> GetAsync(this IAlertsOperations operations, string vaultName, string resourceGroupName, string uniqueAlertId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(vaultName, resourceGroupName, uniqueAlertId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Resolve the specific Alert.
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
            /// <param name='uniqueAlertId'>
            /// Unique identifier for the alert.
            /// </param>
            /// <param name='resolveAlertRequest'>
            /// Alert resolution request options.
            /// </param>
            public static AlertResponsePropertiesResource Resolve(this IAlertsOperations operations, string vaultName, string resourceGroupName, string uniqueAlertId, ResolveAlertRequest resolveAlertRequest)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAlertsOperations)s).ResolveAsync(vaultName, resourceGroupName, uniqueAlertId, resolveAlertRequest), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resolve the specific Alert.
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
            /// <param name='uniqueAlertId'>
            /// Unique identifier for the alert.
            /// </param>
            /// <param name='resolveAlertRequest'>
            /// Alert resolution request options.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<AlertResponsePropertiesResource> ResolveAsync(this IAlertsOperations operations, string vaultName, string resourceGroupName, string uniqueAlertId, ResolveAlertRequest resolveAlertRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ResolveWithHttpMessagesAsync(vaultName, resourceGroupName, uniqueAlertId, resolveAlertRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns all Alerts for the given resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<AlertResponsePropertiesResource> ListNext(this IAlertsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAlertsOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns all Alerts for the given resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<AlertResponsePropertiesResource>> ListNextAsync(this IAlertsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
