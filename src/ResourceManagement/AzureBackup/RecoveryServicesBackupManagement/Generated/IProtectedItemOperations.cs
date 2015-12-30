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
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    /// <summary>
    /// Definition of ProtectedItem operations for the Azure Backup extension.
    /// </summary>
    public partial interface IProtectedItemOperations
    {
        /// <summary>
        /// Create Or Update ProtectedItem.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='fabricName'>
        /// Backup Fabric name for the backup item
        /// </param>
        /// <param name='containerName'>
        /// Container Name of protectionContainers
        /// </param>
        /// <param name='protectedItemName'>
        /// Name of ProtectedItem
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a BaseRecoveryServicesJobResponse for Async
        /// operations.
        /// </returns>
        Task<BaseRecoveryServicesJobResponse> CreateOrUpdateProtectedItemAsync(string resourceGroupName, string resourceName, string fabricName, string containerName, string protectedItemName, ProtectedItemCreateOrUpdateRequest request, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete the specified protected item.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='fabricName'>
        /// Backup Fabric name for the backup item
        /// </param>
        /// <param name='containerName'>
        /// Container Name of protectionContainers
        /// </param>
        /// <param name='protectedItemName'>
        /// Name of ProtectedItem
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a BaseRecoveryServicesJobResponse for Async
        /// operations.
        /// </returns>
        Task<BaseRecoveryServicesJobResponse> DeleteProtectedItemAsync(string resourceGroupName, string resourceName, string fabricName, string containerName, string protectedItemName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the details of specific protected Objects.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        Task<ProtectedItemResponse> GetAsync(string resourceGroupName, string resourceName, string fabricName, string containerName, string protectedItemName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the details of specific protected Objects.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        Task<ProtectedItemResponse> GetOperationResultAsync(string resourceGroupName, string resourceName, string fabricName, string containerName, string protectedItemName, string operationId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the operation stauts of specific operationId.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a OperationStatusResponse.
        /// </returns>
        Task<BackUpOperationStatusResponse> GetOperationStatusAsync(string resourceGroupName, string resourceName, string fabricName, string containerName, string protectedItemName, string operationId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list of all protected Objects.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemsListResponse.
        /// </returns>
        Task<ProtectedItemListResponse> ListAsync(string resourceGroupName, string resourceName, ProtectedItemListQueryParam queryFilter, PaginationRequest paginationParams, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
