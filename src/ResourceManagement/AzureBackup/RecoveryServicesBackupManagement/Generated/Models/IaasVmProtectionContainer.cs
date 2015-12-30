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
    /// The definition of a IaasVmProtectionContainer object.
    /// </summary>
    public partial class IaasVmProtectionContainer : ProtectionContainer
    {
        private string _resourceGroup;
        
        /// <summary>
        /// Optional. Resource Group
        /// </summary>
        public string ResourceGroup
        {
            get { return this._resourceGroup; }
            set { this._resourceGroup = value; }
        }
        
        private string _virtualMachineId;
        
        /// <summary>
        /// Optional. VirtualMachine Id
        /// </summary>
        public string VirtualMachineId
        {
            get { return this._virtualMachineId; }
            set { this._virtualMachineId = value; }
        }
        
        private string _virtualMachineVersion;
        
        /// <summary>
        /// Optional. Virtual Machine Version
        /// </summary>
        public string VirtualMachineVersion
        {
            get { return this._virtualMachineVersion; }
            set { this._virtualMachineVersion = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the IaasVmProtectionContainer class.
        /// </summary>
        public IaasVmProtectionContainer()
        {
        }
    }
}
