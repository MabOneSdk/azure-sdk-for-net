// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ProtectedItemOperationStatusesOperations operations.
    /// </summary>
    public partial interface IProtectedItemOperationStatusesOperations
    {
        /// <summary>
        /// Fetches the status of an operation such as triggering a backup,
        /// restore. The status can be in progress, completed or failed. You
        /// can refer to the OperationStatus enum for all the possible states
        /// of the operation. Some operations create jobs. This method returns
        /// the list of jobs associated with the operation.
        /// </summary>
        /// <param name='vaultName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name associated with the backup item.
        /// </param>
        /// <param name='containerName'>
        /// Container name associated with the backup item.
        /// </param>
        /// <param name='protectedItemName'>
        /// Backup item name whose details are to be fetched.
        /// </param>
        /// <param name='operationId'>
        /// OperationID represents the operation whose status needs to be
        /// fetched.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<OperationStatus>> GetWithHttpMessagesAsync(string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, string operationId, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
