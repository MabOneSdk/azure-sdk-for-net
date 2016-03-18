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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Authorization.Models;

namespace Microsoft.Azure.Management.Authorization.Models
{
    /// <summary>
    /// Role definition properties.
    /// </summary>
    public partial class RoleDefinitionProperties
    {
        private IList<string> _assignableScopes;
        
        /// <summary>
        /// Optional. Gets or sets role definition assignable scopes.
        /// </summary>
        public IList<string> AssignableScopes
        {
            get { return this._assignableScopes; }
            set { this._assignableScopes = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets role definition description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private IList<Permission> _permissions;
        
        /// <summary>
        /// Optional. Gets or sets role definition permissions.
        /// </summary>
        public IList<Permission> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }
        
        private string _roleName;
        
        /// <summary>
        /// Optional. Gets or sets role name.
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. Gets or sets role type.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RoleDefinitionProperties class.
        /// </summary>
        public RoleDefinitionProperties()
        {
            this.AssignableScopes = new LazyList<string>();
            this.Permissions = new LazyList<Permission>();
        }
    }
}
