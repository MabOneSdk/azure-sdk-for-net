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

namespace Microsoft.Azure.Graph.RBAC.Models
{
    /// <summary>
    /// Request parameters for GetMemberGroups API call
    /// </summary>
    public partial class UserGetMemberGroupsParameters
    {
        private string _objectId;
        
        /// <summary>
        /// Required. User object Id
        /// </summary>
        public string ObjectId
        {
            get { return this._objectId; }
            set { this._objectId = value; }
        }
        
        private bool _securityEnabledOnly;
        
        /// <summary>
        /// Required. If true only membership in security enabled groups should
        /// be checked. Otherwise membership in all groups should be checked
        /// </summary>
        public bool SecurityEnabledOnly
        {
            get { return this._securityEnabledOnly; }
            set { this._securityEnabledOnly = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the UserGetMemberGroupsParameters
        /// class.
        /// </summary>
        public UserGetMemberGroupsParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the UserGetMemberGroupsParameters
        /// class with required arguments.
        /// </summary>
        public UserGetMemberGroupsParameters(string objectId, bool securityEnabledOnly)
            : this()
        {
            if (objectId == null)
            {
                throw new ArgumentNullException("objectId");
            }
            this.ObjectId = objectId;
            this.SecurityEnabledOnly = securityEnabledOnly;
        }
    }
}
