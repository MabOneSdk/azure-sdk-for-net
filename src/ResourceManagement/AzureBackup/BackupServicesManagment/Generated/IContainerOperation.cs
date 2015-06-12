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
using Microsoft.Azure.Management.BackupServices;
using Microsoft.Azure.Management.BackupServices.Models;

namespace Microsoft.Azure.Management.BackupServices
{
    /// <summary>
    /// Definition of Container operations for the Azure Backup extension.
    /// </summary>
    public partial interface IContainerOperation
    {
        /// <summary>
        /// Get the list of all container based on the given query filter
        /// string.
        /// </summary>
        /// <param name='queryFilterString'>
        /// Job query parameter string.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a ListContainerResponse.
        /// </returns>
        Task<ListContainerResponse> ListAsync(string queryFilterString, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Trigger the Discovery.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        Task<OperationResponse> RefreshAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Register the container.
        /// </summary>
        /// <param name='parameters'>
        /// Container to be register.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        Task<OperationResponse> RegisterAsync(RegisterContainerRequestInput parameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Unregister the container.
        /// </summary>
        /// <param name='parameters'>
        /// Container which we want to unregister.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        Task<OperationResponse> UnregisterAsync(UnregisterContainerRequestInput parameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
