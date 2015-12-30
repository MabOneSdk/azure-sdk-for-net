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

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.DataFactories.Common.Models;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories
{
    /// <summary>
    /// Operations for managing hubs.
    /// </summary>
    public partial interface IHubOperations
    {
        /// <summary>
        /// Create a new hub instance or update an existing instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// The name of the data factory.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update a hub.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create or update hub operation response.
        /// </returns>
        Task<HubCreateOrUpdateResponse> BeginCreateOrUpdateAsync(string resourceGroupName, string dataFactoryName, HubCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete a hub instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// The name of the data factory.
        /// </param>
        /// <param name='hubName'>
        /// The name of the hub.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginDeleteAsync(string resourceGroupName, string dataFactoryName, string hubName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Create a new hub instance or update an existing instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// The name of the data factory.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update a hub.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create or update hub operation response.
        /// </returns>
        Task<HubCreateOrUpdateResponse> CreateOrUpdateAsync(string resourceGroupName, string dataFactoryName, HubCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Create a new hub instance or update an existing instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// The name of the data factory.
        /// </param>
        /// <param name='hubName'>
        /// The name of the data factory hub to be created or updated.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update a hub.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create or update hub operation response.
        /// </returns>
        Task<HubCreateOrUpdateResponse> CreateOrUpdateWithRawJsonContentAsync(string resourceGroupName, string dataFactoryName, string hubName, HubCreateOrUpdateWithRawJsonContentParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete a hub instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// The name of the data factory.
        /// </param>
        /// <param name='hubName'>
        /// The name of the hub.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> DeleteAsync(string resourceGroupName, string dataFactoryName, string hubName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets a hub instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// The name of the data factory.
        /// </param>
        /// <param name='hubName'>
        /// The name of the hub.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The get hub operation response.
        /// </returns>
        Task<HubGetResponse> GetAsync(string resourceGroupName, string dataFactoryName, string hubName, CancellationToken cancellationToken);
        
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create or update hub operation response.
        /// </returns>
        Task<HubCreateOrUpdateResponse> GetCreateOrUpdateStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the first page of data factory hub instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// The name of the data factory.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The list hub operation response.
        /// </returns>
        Task<HubListResponse> ListAsync(string resourceGroupName, string dataFactoryName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the next page of data factory hub instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next data factory hubs page.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The list hub operation response.
        /// </returns>
        Task<HubListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
    }
}
