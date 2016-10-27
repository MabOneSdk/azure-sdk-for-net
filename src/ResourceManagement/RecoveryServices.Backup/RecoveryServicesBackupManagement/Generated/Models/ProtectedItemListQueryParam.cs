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

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    /// <summary>
    /// The query filters that can be used with the list protected items API.
    /// </summary>
    public partial class ProtectedItemListQueryParam
    {
        private string _backupManagementType;
        
        /// <summary>
        /// Optional. Backup management type of this protected item. Possible
        /// values: AzureIaasVM, MAB, DPM.
        /// </summary>
        public string BackupManagementType
        {
            get { return this._backupManagementType; }
            set { this._backupManagementType = value; }
        }
        
        private string _containerName;
        
        /// <summary>
        /// Optional. Name of the container.
        /// </summary>
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }
        
        private string _datasourceType;
        
        /// <summary>
        /// Optional. Type of workload this item represents. Possible values:
        /// VM, FileFolder.
        /// </summary>
        public string DatasourceType
        {
            get { return this._datasourceType; }
            set { this._datasourceType = value; }
        }
        
        private string _policyName;
        
        /// <summary>
        /// Optional. Name of the protection policy which is associated with
        /// the protection of this item.
        /// </summary>
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProtectedItemListQueryParam class.
        /// </summary>
        public ProtectedItemListQueryParam()
        {
        }
    }
}
