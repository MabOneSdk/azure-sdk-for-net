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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The Protection profile dissociation input object.
    /// </summary>
    public partial class DisassociateProtectionProfileInput
    {
        private string _name;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _primaryProtectionContainerId;
        
        /// <summary>
        /// Required.
        /// </summary>
        public string PrimaryProtectionContainerId
        {
            get { return this._primaryProtectionContainerId; }
            set { this._primaryProtectionContainerId = value; }
        }
        
        private string _recoveryProtectionContainerId;
        
        /// <summary>
        /// Required.
        /// </summary>
        public string RecoveryProtectionContainerId
        {
            get { return this._recoveryProtectionContainerId; }
            set { this._recoveryProtectionContainerId = value; }
        }
        
        private ProtectionProfileProviderSpecificInput _replicationProviderSettings;
        
        /// <summary>
        /// Optional. the replication provider settings.
        /// </summary>
        public ProtectionProfileProviderSpecificInput ReplicationProviderSettings
        {
            get { return this._replicationProviderSettings; }
            set { this._replicationProviderSettings = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DisassociateProtectionProfileInput class.
        /// </summary>
        public DisassociateProtectionProfileInput()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DisassociateProtectionProfileInput class with required arguments.
        /// </summary>
        public DisassociateProtectionProfileInput(string primaryProtectionContainerId, string recoveryProtectionContainerId)
            : this()
        {
            if (primaryProtectionContainerId == null)
            {
                throw new ArgumentNullException("primaryProtectionContainerId");
            }
            if (recoveryProtectionContainerId == null)
            {
                throw new ArgumentNullException("recoveryProtectionContainerId");
            }
            this.PrimaryProtectionContainerId = primaryProtectionContainerId;
            this.RecoveryProtectionContainerId = recoveryProtectionContainerId;
        }
    }
}
