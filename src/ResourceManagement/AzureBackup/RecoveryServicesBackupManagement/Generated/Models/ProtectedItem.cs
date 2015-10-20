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
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    /// <summary>
    /// The definition of a ProtectedItem object.
    /// </summary>
    public partial class ProtectedItem : ProtectedItemBase
    {
        private string _containerId;
        
        /// <summary>
        /// Optional. Container Id
        /// </summary>
        public string ContainerId
        {
            get { return this._containerId; }
            set { this._containerId = value; }
        }
        
        private string _friendlyName;
        
        /// <summary>
        /// Optional. Friendly Name
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }
        
        private string _policyName;
        
        /// <summary>
        /// Optional. Policy Name
        /// </summary>
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }
        
        private string _protectionStatus;
        
        /// <summary>
        /// Optional. Protection Status
        /// </summary>
        public string ProtectionStatus
        {
            get { return this._protectionStatus; }
            set { this._protectionStatus = value; }
        }
        
        private string _registrationStatus;
        
        /// <summary>
        /// Optional. Registration Status
        /// </summary>
        public string RegistrationStatus
        {
            get { return this._registrationStatus; }
            set { this._registrationStatus = value; }
        }
        
        private string _storageRedundancy;
        
        /// <summary>
        /// Optional. Storage Redundancy
        /// </summary>
        public string StorageRedundancy
        {
            get { return this._storageRedundancy; }
            set { this._storageRedundancy = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProtectedItem class.
        /// </summary>
        public ProtectedItem()
        {
        }
    }
}
