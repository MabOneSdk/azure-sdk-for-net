// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    /// <summary>
    /// The Resource Manager API includes operations for managing the
    /// containers registered to your Recovery Services Vault.
    /// </summary>
    public partial interface IContainerOperations
    {
        /// <summary>
        /// The Begin Refresh Operation triggers an operation in the service
        /// which would discover all the containers in the subscription that
        /// are ready to be protected by your Recovery Services Vault. This is
        /// an asynchronous operation. To determine whether the backend
        /// service has finished processing the request, call Get Refresh
        /// Operation Result APIs.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Nme of your recovery services vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name for the protection containers.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        Task<BaseRecoveryServicesJobResponse> BeginRefreshAsync(string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string fabricName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets details of the specific container registered to your Recovery
        /// Services Vault.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Name of your recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name of the protected item.
        /// </param>
        /// <param name='containerName'>
        /// Name of the container.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Protection container returned as a response by the get protection
        /// container API.
        /// </returns>
        Task<ProtectionContainerResponse> GetAsync(string resourceGroupName, string resourceName, string fabricName, string containerName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Fetches the result of any operation on the container given the ID
        /// of operation.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Name of your recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name of the protected item.
        /// </param>
        /// <param name='containerName'>
        /// Name of the container where the protected item belongs to.
        /// </param>
        /// <param name='operationId'>
        /// ID of the container operation whose result has to be fetched.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Protection container returned as a response by the get protection
        /// container API.
        /// </returns>
        Task<ProtectionContainerResponse> GetContainerOperationResultAsync(string resourceGroupName, string resourceName, string fabricName, string containerName, string operationId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Fetches the result of any operation on the container given the URL
        /// for tracking the operation as returned by APIs such as Unregister
        /// etc.
        /// </summary>
        /// <param name='operationResultLink'>
        /// Location value returned by operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Protection container returned as a response by the get protection
        /// container API.
        /// </returns>
        Task<ProtectionContainerResponse> GetContainerOperationResultByURLAsync(string operationResultLink, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Fetches the result of the refresh operation triggered by the Begin
        /// Refresh API given the ID of the operation.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Name of your recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name of the protected item.
        /// </param>
        /// <param name='operationId'>
        /// ID of the container operation whose result has to be fetched.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        Task<BaseRecoveryServicesJobResponse> GetRefreshOperationResultAsync(string resourceGroupName, string resourceName, string fabricName, string operationId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Fetches the result of the refresh operation triggered by the Begin
        /// Refresh operation given the URL for tracking the operation as
        /// returned by the Begin Refresh operation.
        /// </summary>
        /// <param name='operationResultLink'>
        /// Location value returned by operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        Task<BaseRecoveryServicesJobResponse> GetRefreshOperationResultByURLAsync(string operationResultLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Lists all the containers registered to your Recovery Services Vault
        /// according to the query parameters supplied in the arguments.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Name of your recovery services vault.
        /// </param>
        /// <param name='queryParams'>
        /// Query parameters for listing protection containers.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// List of protection containers returned as a response by the list
        /// protection containers API.
        /// </returns>
        Task<ProtectionContainerListResponse> ListAsync(string resourceGroupName, string resourceName, ProtectionContainerListQueryParams queryParams, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Refresh Operation triggers an operation in the service which
        /// would discover all the containers in the subscription that are
        /// ready to be protected by your Recovery Services Vault.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Name of your recovery services vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name for the protection containers.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        Task<BaseRecoveryServicesJobResponse> RefreshAsync(string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string fabricName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Begin Unregister Operation unregisters the given container from
        /// your Recovery Services Vault. This is an asynchronous operation.
        /// To determine whether the backend service has finished processing
        /// the request, call Get Container Operation Result API.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Name of your recovery services vault.
        /// </param>
        /// <param name='identityName'>
        /// Name of the protection container to unregister.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> UnregisterAsync(string resourceGroupName, string resourceName, string identityName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
