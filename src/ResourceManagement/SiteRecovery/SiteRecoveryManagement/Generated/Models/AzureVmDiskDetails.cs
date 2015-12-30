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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// Virtual Machine disk details.
    /// </summary>
    public partial class AzureVmDiskDetails
    {
        private IList<VirtualHardDisk> _disks;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<VirtualHardDisk> Disks
        {
            get { return this._disks; }
            set { this._disks = value; }
        }
        
        private ulong _maxSizeMB;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public ulong MaxSizeMB
        {
            get { return this._maxSizeMB; }
            set { this._maxSizeMB = value; }
        }
        
        private string _osDisk;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string OsDisk
        {
            get { return this._osDisk; }
            set { this._osDisk = value; }
        }
        
        private string _osType;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string OsType
        {
            get { return this._osType; }
            set { this._osType = value; }
        }
        
        private string _vHDId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string VHDId
        {
            get { return this._vHDId; }
            set { this._vHDId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureVmDiskDetails class.
        /// </summary>
        public AzureVmDiskDetails()
        {
            this.Disks = new LazyList<VirtualHardDisk>();
        }
    }
}
