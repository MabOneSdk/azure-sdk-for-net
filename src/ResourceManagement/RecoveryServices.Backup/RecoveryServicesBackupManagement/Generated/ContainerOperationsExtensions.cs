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
using Microsoft.Azure.Management.RecoveryServices.Backup;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    public static partial class ContainerOperationsExtensions
    {
        /// <summary>
        /// The Begin Refresh Operation triggers an operation in the service
        /// which would discover all the containers in the subscription that
        /// are ready to be protected by your Recovery Services Vault. This is
        /// an asynchronous operation. To determine whether the backend
        /// service has finished processing the request, call Get Refresh
        /// Operation Result APIs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Nme of your recovery services vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <param name='fabricName'>
        /// Optional. Fabric name for the protection containers.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        public static BaseRecoveryServicesJobResponse BeginRefresh(this IContainerOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string fabricName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContainerOperations)s).BeginRefreshAsync(resourceGroupName, resourceName, customRequestHeaders, fabricName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Begin Refresh Operation triggers an operation in the service
        /// which would discover all the containers in the subscription that
        /// are ready to be protected by your Recovery Services Vault. This is
        /// an asynchronous operation. To determine whether the backend
        /// service has finished processing the request, call Get Refresh
        /// Operation Result APIs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Nme of your recovery services vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <param name='fabricName'>
        /// Optional. Fabric name for the protection containers.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        public static Task<BaseRecoveryServicesJobResponse> BeginRefreshAsync(this IContainerOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string fabricName)
        {
            return operations.BeginRefreshAsync(resourceGroupName, resourceName, customRequestHeaders, fabricName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets details of the specific container registered to your Recovery
        /// Services Vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of your recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric name of the protected item.
        /// </param>
        /// <param name='containerName'>
        /// Required. Name of the container.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <returns>
        /// Protection container returned as a response by the get protection
        /// container API.
        /// </returns>
        public static ProtectionContainerResponse Get(this IContainerOperations operations, string resourceGroupName, string resourceName, string fabricName, string containerName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContainerOperations)s).GetAsync(resourceGroupName, resourceName, fabricName, containerName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets details of the specific container registered to your Recovery
        /// Services Vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of your recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Required. Fabric name of the protected item.
        /// </param>
        /// <param name='containerName'>
        /// Required. Name of the container.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <returns>
        /// Protection container returned as a response by the get protection
        /// container API.
        /// </returns>
        public static Task<ProtectionContainerResponse> GetAsync(this IContainerOperations operations, string resourceGroupName, string resourceName, string fabricName, string containerName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(resourceGroupName, resourceName, fabricName, containerName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Fetches the result of any operation on the container given the ID
        /// of operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of your recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Optional. Fabric name of the protected item.
        /// </param>
        /// <param name='containerName'>
        /// Required. Name of the container where the protected item belongs to.
        /// </param>
        /// <param name='operationId'>
        /// Required. ID of the container operation whose result has to be
        /// fetched.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Protection container returned as a response by the get protection
        /// container API.
        /// </returns>
        public static ProtectionContainerResponse GetContainerOperationResult(this IContainerOperations operations, string resourceGroupName, string resourceName, string fabricName, string containerName, string operationId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContainerOperations)s).GetContainerOperationResultAsync(resourceGroupName, resourceName, fabricName, containerName, operationId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Fetches the result of any operation on the container given the ID
        /// of operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of your recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Optional. Fabric name of the protected item.
        /// </param>
        /// <param name='containerName'>
        /// Required. Name of the container where the protected item belongs to.
        /// </param>
        /// <param name='operationId'>
        /// Required. ID of the container operation whose result has to be
        /// fetched.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Protection container returned as a response by the get protection
        /// container API.
        /// </returns>
        public static Task<ProtectionContainerResponse> GetContainerOperationResultAsync(this IContainerOperations operations, string resourceGroupName, string resourceName, string fabricName, string containerName, string operationId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetContainerOperationResultAsync(resourceGroupName, resourceName, fabricName, containerName, operationId, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Fetches the result of any operation on the container given the URL
        /// for tracking the operation as returned by APIs such as Unregister
        /// etc.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='operationResultLink'>
        /// Required. Location value returned by operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Protection container returned as a response by the get protection
        /// container API.
        /// </returns>
        public static ProtectionContainerResponse GetContainerOperationResultByURL(this IContainerOperations operations, string operationResultLink, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContainerOperations)s).GetContainerOperationResultByURLAsync(operationResultLink, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Fetches the result of any operation on the container given the URL
        /// for tracking the operation as returned by APIs such as Unregister
        /// etc.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='operationResultLink'>
        /// Required. Location value returned by operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Protection container returned as a response by the get protection
        /// container API.
        /// </returns>
        public static Task<ProtectionContainerResponse> GetContainerOperationResultByURLAsync(this IContainerOperations operations, string operationResultLink, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetContainerOperationResultByURLAsync(operationResultLink, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Fetches the result of the refresh operation triggered by the Begin
        /// Refresh API given the ID of the operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of your recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Optional. Fabric name of the protected item.
        /// </param>
        /// <param name='operationId'>
        /// Required. ID of the container operation whose result has to be
        /// fetched.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        public static BaseRecoveryServicesJobResponse GetRefreshOperationResult(this IContainerOperations operations, string resourceGroupName, string resourceName, string fabricName, string operationId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContainerOperations)s).GetRefreshOperationResultAsync(resourceGroupName, resourceName, fabricName, operationId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Fetches the result of the refresh operation triggered by the Begin
        /// Refresh API given the ID of the operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of your recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Optional. Fabric name of the protected item.
        /// </param>
        /// <param name='operationId'>
        /// Required. ID of the container operation whose result has to be
        /// fetched.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        public static Task<BaseRecoveryServicesJobResponse> GetRefreshOperationResultAsync(this IContainerOperations operations, string resourceGroupName, string resourceName, string fabricName, string operationId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetRefreshOperationResultAsync(resourceGroupName, resourceName, fabricName, operationId, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Fetches the result of the refresh operation triggered by the Begin
        /// Refresh operation given the URL for tracking the operation as
        /// returned by the Begin Refresh operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='operationResultLink'>
        /// Required. Location value returned by operation.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        public static BaseRecoveryServicesJobResponse GetRefreshOperationResultByURL(this IContainerOperations operations, string operationResultLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContainerOperations)s).GetRefreshOperationResultByURLAsync(operationResultLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Fetches the result of the refresh operation triggered by the Begin
        /// Refresh operation given the URL for tracking the operation as
        /// returned by the Begin Refresh operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='operationResultLink'>
        /// Required. Location value returned by operation.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        public static Task<BaseRecoveryServicesJobResponse> GetRefreshOperationResultByURLAsync(this IContainerOperations operations, string operationResultLink)
        {
            return operations.GetRefreshOperationResultByURLAsync(operationResultLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Lists all the containers registered to your Recovery Services Vault
        /// according to the query parameters supplied in the arguments.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of your recovery services vault.
        /// </param>
        /// <param name='queryParams'>
        /// Required. Query parameters for listing protection containers.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <returns>
        /// List of protection containers returned as a response by the list
        /// protection containers API.
        /// </returns>
        public static ProtectionContainerListResponse List(this IContainerOperations operations, string resourceGroupName, string resourceName, ProtectionContainerListQueryParams queryParams, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContainerOperations)s).ListAsync(resourceGroupName, resourceName, queryParams, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Lists all the containers registered to your Recovery Services Vault
        /// according to the query parameters supplied in the arguments.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of your recovery services vault.
        /// </param>
        /// <param name='queryParams'>
        /// Required. Query parameters for listing protection containers.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <returns>
        /// List of protection containers returned as a response by the list
        /// protection containers API.
        /// </returns>
        public static Task<ProtectionContainerListResponse> ListAsync(this IContainerOperations operations, string resourceGroupName, string resourceName, ProtectionContainerListQueryParams queryParams, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(resourceGroupName, resourceName, queryParams, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// The Refresh Operation triggers an operation in the service which
        /// would discover all the containers in the subscription that are
        /// ready to be protected by your Recovery Services Vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of your recovery services vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <param name='fabricName'>
        /// Optional. Fabric name for the protection containers.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        public static BaseRecoveryServicesJobResponse Refresh(this IContainerOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string fabricName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContainerOperations)s).RefreshAsync(resourceGroupName, resourceName, customRequestHeaders, fabricName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Refresh Operation triggers an operation in the service which
        /// would discover all the containers in the subscription that are
        /// ready to be protected by your Recovery Services Vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of your recovery services vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <param name='fabricName'>
        /// Optional. Fabric name for the protection containers.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        public static Task<BaseRecoveryServicesJobResponse> RefreshAsync(this IContainerOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string fabricName)
        {
            return operations.RefreshAsync(resourceGroupName, resourceName, customRequestHeaders, fabricName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Begin Unregister Operation unregisters the given container from
        /// your Recovery Services Vault. This is an asynchronous operation.
        /// To determine whether the backend service has finished processing
        /// the request, call Get Container Operation Result API.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of your recovery services vault.
        /// </param>
        /// <param name='identityName'>
        /// Required. Name of the protection container to unregister.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Unregister(this IContainerOperations operations, string resourceGroupName, string resourceName, string identityName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContainerOperations)s).UnregisterAsync(resourceGroupName, resourceName, identityName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Begin Unregister Operation unregisters the given container from
        /// your Recovery Services Vault. This is an asynchronous operation.
        /// To determine whether the backend service has finished processing
        /// the request, call Get Container Operation Result API.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of your recovery services vault.
        /// </param>
        /// <param name='identityName'>
        /// Required. Name of the protection container to unregister.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> UnregisterAsync(this IContainerOperations operations, string resourceGroupName, string resourceName, string identityName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.UnregisterAsync(resourceGroupName, resourceName, identityName, customRequestHeaders, CancellationToken.None);
        }
    }
}
