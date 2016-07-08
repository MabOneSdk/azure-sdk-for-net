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
using Microsoft.Azure.Management.Batch;
using Microsoft.Azure.Management.Batch.Models;

namespace Microsoft.Azure.Management.Batch
{
    public static partial class AccountOperationsExtensions
    {
        /// <summary>
        /// Begin creating the batch account.To determine whether the operation
        /// has finished processing the request, call
        /// GetLongRunningOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the new
        /// Batch account.
        /// </param>
        /// <param name='accountName'>
        /// Required. A name for the Batch account which must be unique within
        /// Azure. Batch account names must be between 3 and 24 characters in
        /// length and must use only numbers and lower-case letters. This name
        /// is used as part of the DNS name that is used to access the batch
        /// service in the region in which the account is created. For
        /// example: http://AccountName.batch.core.windows.net/.
        /// </param>
        /// <param name='parameters'>
        /// Required. Additional parameters for account creation
        /// </param>
        /// <returns>
        /// Values returned by the Create operation.
        /// </returns>
        public static BatchAccountCreateResponse BeginCreating(this IAccountOperations operations, string resourceGroupName, string accountName, BatchAccountCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAccountOperations)s).BeginCreatingAsync(resourceGroupName, accountName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Begin creating the batch account.To determine whether the operation
        /// has finished processing the request, call
        /// GetLongRunningOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the new
        /// Batch account.
        /// </param>
        /// <param name='accountName'>
        /// Required. A name for the Batch account which must be unique within
        /// Azure. Batch account names must be between 3 and 24 characters in
        /// length and must use only numbers and lower-case letters. This name
        /// is used as part of the DNS name that is used to access the batch
        /// service in the region in which the account is created. For
        /// example: http://AccountName.batch.core.windows.net/.
        /// </param>
        /// <param name='parameters'>
        /// Required. Additional parameters for account creation
        /// </param>
        /// <returns>
        /// Values returned by the Create operation.
        /// </returns>
        public static Task<BatchAccountCreateResponse> BeginCreatingAsync(this IAccountOperations operations, string resourceGroupName, string accountName, BatchAccountCreateParameters parameters)
        {
            return operations.BeginCreatingAsync(resourceGroupName, accountName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Begin deleting the batch account.To determine whether the operation
        /// has finished processing the request, call
        /// GetLongRunningOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the Batch
        /// account to be deleted.
        /// </param>
        /// <param name='accountName'>
        /// Required. The name of the account to be deleted.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse BeginDeleting(this IAccountOperations operations, string resourceGroupName, string accountName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAccountOperations)s).BeginDeletingAsync(resourceGroupName, accountName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Begin deleting the batch account.To determine whether the operation
        /// has finished processing the request, call
        /// GetLongRunningOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the Batch
        /// account to be deleted.
        /// </param>
        /// <param name='accountName'>
        /// Required. The name of the account to be deleted.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> BeginDeletingAsync(this IAccountOperations operations, string resourceGroupName, string accountName)
        {
            return operations.BeginDeletingAsync(resourceGroupName, accountName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Create operation creates a new Batch account in the specified
        /// resource group and datacenter location.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the new
        /// Batch account.
        /// </param>
        /// <param name='accountName'>
        /// Required. A name for the Batch account which must be unique within
        /// Azure. Batch account names must be between 3 and 24 characters in
        /// length and must use only numbers and lower-case letters. This name
        /// is used as part of the DNS name that is used to access the batch
        /// service in the region in which the account is created. For
        /// example: http://AccountName.batch.core.windows.net/.
        /// </param>
        /// <param name='parameters'>
        /// Required. Additional parameters for account creation
        /// </param>
        /// <returns>
        /// Values returned by the Create operation.
        /// </returns>
        public static BatchAccountCreateResponse Create(this IAccountOperations operations, string resourceGroupName, string accountName, BatchAccountCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAccountOperations)s).CreateAsync(resourceGroupName, accountName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Create operation creates a new Batch account in the specified
        /// resource group and datacenter location.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the new
        /// Batch account.
        /// </param>
        /// <param name='accountName'>
        /// Required. A name for the Batch account which must be unique within
        /// Azure. Batch account names must be between 3 and 24 characters in
        /// length and must use only numbers and lower-case letters. This name
        /// is used as part of the DNS name that is used to access the batch
        /// service in the region in which the account is created. For
        /// example: http://AccountName.batch.core.windows.net/.
        /// </param>
        /// <param name='parameters'>
        /// Required. Additional parameters for account creation
        /// </param>
        /// <returns>
        /// Values returned by the Create operation.
        /// </returns>
        public static Task<BatchAccountCreateResponse> CreateAsync(this IAccountOperations operations, string resourceGroupName, string accountName, BatchAccountCreateParameters parameters)
        {
            return operations.CreateAsync(resourceGroupName, accountName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Delete operation deletes an existing Batch account. The
        /// operation will return NoContent if the requested account does not
        /// exist.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the Batch
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// Required. The name of the account to be deleted.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse Delete(this IAccountOperations operations, string resourceGroupName, string accountName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAccountOperations)s).DeleteAsync(resourceGroupName, accountName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Delete operation deletes an existing Batch account. The
        /// operation will return NoContent if the requested account does not
        /// exist.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the Batch
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// Required. The name of the account to be deleted.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> DeleteAsync(this IAccountOperations operations, string resourceGroupName, string accountName)
        {
            return operations.DeleteAsync(resourceGroupName, accountName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get operation gets detailed information about the specified
        /// Batch account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the Batch
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// Required. The name of the account.
        /// </param>
        /// <returns>
        /// Values returned by the Get operation.
        /// </returns>
        public static BatchAccountGetResponse Get(this IAccountOperations operations, string resourceGroupName, string accountName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAccountOperations)s).GetAsync(resourceGroupName, accountName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get operation gets detailed information about the specified
        /// Batch account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the Batch
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// Required. The name of the account.
        /// </param>
        /// <returns>
        /// Values returned by the Get operation.
        /// </returns>
        public static Task<BatchAccountGetResponse> GetAsync(this IAccountOperations operations, string resourceGroupName, string accountName)
        {
            return operations.GetAsync(resourceGroupName, accountName, CancellationToken.None);
        }
        
        /// <summary>
        /// The List operation gets information about the Batch accounts
        /// associated either with the subscription if no resource group is
        /// specified or within the specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional. An optional argument which specifies the name of the
        /// resource group that constrains the set of accounts that are
        /// returned.
        /// </param>
        /// <returns>
        /// Values returned by the List operation.
        /// </returns>
        public static BatchAccountListResponse List(this IAccountOperations operations, AccountListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAccountOperations)s).ListAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List operation gets information about the Batch accounts
        /// associated either with the subscription if no resource group is
        /// specified or within the specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional. An optional argument which specifies the name of the
        /// resource group that constrains the set of accounts that are
        /// returned.
        /// </param>
        /// <returns>
        /// Values returned by the List operation.
        /// </returns>
        public static Task<BatchAccountListResponse> ListAsync(this IAccountOperations operations, AccountListParameters parameters)
        {
            return operations.ListAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The ListActions operation gets information about non-standard
        /// actions for the provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <returns>
        /// Values returned by the ListActions operation.
        /// </returns>
        public static BatchAccountListActionsResponse ListActions(this IAccountOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAccountOperations)s).ListActionsAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The ListActions operation gets information about non-standard
        /// actions for the provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <returns>
        /// Values returned by the ListActions operation.
        /// </returns>
        public static Task<BatchAccountListActionsResponse> ListActionsAsync(this IAccountOperations operations)
        {
            return operations.ListActionsAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// The ListKeys operation gets the account keys for the given Batch
        /// account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the Batch
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// Required. The name of the account.
        /// </param>
        /// <returns>
        /// Values returned by the GetKeys operation.
        /// </returns>
        public static BatchAccountListKeyResponse ListKeys(this IAccountOperations operations, string resourceGroupName, string accountName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAccountOperations)s).ListKeysAsync(resourceGroupName, accountName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The ListKeys operation gets the account keys for the given Batch
        /// account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the Batch
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// Required. The name of the account.
        /// </param>
        /// <returns>
        /// Values returned by the GetKeys operation.
        /// </returns>
        public static Task<BatchAccountListKeyResponse> ListKeysAsync(this IAccountOperations operations, string resourceGroupName, string accountName)
        {
            return operations.ListKeysAsync(resourceGroupName, accountName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the next set of accounts based on the previously returned
        /// NextLink value.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// Values returned by the List operation.
        /// </returns>
        public static BatchAccountListResponse ListNext(this IAccountOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAccountOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the next set of accounts based on the previously returned
        /// NextLink value.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// Values returned by the List operation.
        /// </returns>
        public static Task<BatchAccountListResponse> ListNextAsync(this IAccountOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// The RegenerateKey operation regenerates the specified account key
        /// for the given Batch account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the Batch
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// Required. The name of the account.
        /// </param>
        /// <param name='parameters'>
        /// Required. The type of key to regenerate
        /// </param>
        /// <returns>
        /// Values returned by the RegenerateKey operation.
        /// </returns>
        public static BatchAccountRegenerateKeyResponse RegenerateKey(this IAccountOperations operations, string resourceGroupName, string accountName, BatchAccountRegenerateKeyParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAccountOperations)s).RegenerateKeyAsync(resourceGroupName, accountName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The RegenerateKey operation regenerates the specified account key
        /// for the given Batch account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the Batch
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// Required. The name of the account.
        /// </param>
        /// <param name='parameters'>
        /// Required. The type of key to regenerate
        /// </param>
        /// <returns>
        /// Values returned by the RegenerateKey operation.
        /// </returns>
        public static Task<BatchAccountRegenerateKeyResponse> RegenerateKeyAsync(this IAccountOperations operations, string resourceGroupName, string accountName, BatchAccountRegenerateKeyParameters parameters)
        {
            return operations.RegenerateKeyAsync(resourceGroupName, accountName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The SyncAutoStorageKeys operation synchronizes access keys for the
        /// auto storage account configured for the specified Batch account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the Batch
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// Required. The name of the Batch account.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse SyncAutoStorageKeys(this IAccountOperations operations, string resourceGroupName, string accountName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAccountOperations)s).SyncAutoStorageKeysAsync(resourceGroupName, accountName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The SyncAutoStorageKeys operation synchronizes access keys for the
        /// auto storage account configured for the specified Batch account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the Batch
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// Required. The name of the Batch account.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> SyncAutoStorageKeysAsync(this IAccountOperations operations, string resourceGroupName, string accountName)
        {
            return operations.SyncAutoStorageKeysAsync(resourceGroupName, accountName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Update operation updates the properties of an existing Batch
        /// account in the specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the Batch
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// Required. The name of the account.
        /// </param>
        /// <param name='parameters'>
        /// Required. Additional parameters for account update
        /// </param>
        /// <returns>
        /// Values returned by the Update operation.
        /// </returns>
        public static BatchAccountUpdateResponse Update(this IAccountOperations operations, string resourceGroupName, string accountName, BatchAccountUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAccountOperations)s).UpdateAsync(resourceGroupName, accountName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Update operation updates the properties of an existing Batch
        /// account in the specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Batch.IAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group that contains the Batch
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// Required. The name of the account.
        /// </param>
        /// <param name='parameters'>
        /// Required. Additional parameters for account update
        /// </param>
        /// <returns>
        /// Values returned by the Update operation.
        /// </returns>
        public static Task<BatchAccountUpdateResponse> UpdateAsync(this IAccountOperations operations, string resourceGroupName, string accountName, BatchAccountUpdateParameters parameters)
        {
            return operations.UpdateAsync(resourceGroupName, accountName, parameters, CancellationToken.None);
        }
    }
}
