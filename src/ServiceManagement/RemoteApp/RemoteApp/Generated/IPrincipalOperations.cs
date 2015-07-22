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
using Microsoft.WindowsAzure.Management.RemoteApp.Models;

namespace Microsoft.WindowsAzure.Management.RemoteApp
{
    /// <summary>
    /// RemoteApp principal operations.
    /// </summary>
    public partial interface IPrincipalOperations
    {
        /// <summary>
        /// Adds a list of principals to the given collection.
        /// </summary>
        /// <param name='collectionName'>
        /// The RemoteApp collection name.
        /// </param>
        /// <param name='securityPrincipalList'>
        /// A list of RemoteApp principals to add.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response for the collection user operation.
        /// </returns>
        Task<SecurityPrincipalOperationsResult> AddAsync(string collectionName, SecurityPrincipalList securityPrincipalList, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a list of principals from the given collection.
        /// </summary>
        /// <param name='collectionName'>
        /// The RemoteApp collection name.
        /// </param>
        /// <param name='securityPrincipalList'>
        /// A list of RemoteApp principals to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response for the collection user operation.
        /// </returns>
        Task<SecurityPrincipalOperationsResult> DeleteAsync(string collectionName, SecurityPrincipalList securityPrincipalList, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets a list of all RemoteApp principals associated with the given
        /// collection.
        /// </summary>
        /// <param name='collectionName'>
        /// The RemoteApp collection name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The list of principals with consent status.
        /// </returns>
        Task<SecurityPrincipalInfoListResult> ListAsync(string collectionName, CancellationToken cancellationToken);
    }
}
