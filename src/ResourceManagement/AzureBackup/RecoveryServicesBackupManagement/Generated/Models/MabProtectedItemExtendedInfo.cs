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
    /// The definition of a MabProtectedItemExtendedInfo object.
    /// </summary>
    public partial class MabProtectedItemExtendedInfo : ProtectedItemExtendedInfo
    {
        private System.DateTime? _oldestRecoveryPoint;
        
        /// <summary>
        /// Optional. OldestRecoveryPoint for the protected item
        /// </summary>
        public System.DateTime? OldestRecoveryPoint
        {
            get { return this._oldestRecoveryPoint; }
            set { this._oldestRecoveryPoint = value; }
        }
        
        private int _recoveryPointCount;
        
        /// <summary>
        /// Optional. RecoveryPointCount for the protected item
        /// </summary>
        public int RecoveryPointCount
        {
            get { return this._recoveryPointCount; }
            set { this._recoveryPointCount = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MabProtectedItemExtendedInfo
        /// class.
        /// </summary>
        public MabProtectedItemExtendedInfo()
        {
        }
    }
}
