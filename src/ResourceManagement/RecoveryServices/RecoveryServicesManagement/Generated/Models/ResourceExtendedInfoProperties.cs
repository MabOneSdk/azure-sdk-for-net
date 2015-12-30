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

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    /// <summary>
    /// Resource Extended info properties.
    /// </summary>
    public partial class ResourceExtendedInfoProperties
    {
        private string _algorithm;
        
        /// <summary>
        /// Optional. Algorithm.
        /// </summary>
        public string Algorithm
        {
            get { return this._algorithm; }
            set { this._algorithm = value; }
        }
        
        private string _encryptionKey;
        
        /// <summary>
        /// Optional. Encryption  key.
        /// </summary>
        public string EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }
        
        private string _encryptionKeyThumbprint;
        
        /// <summary>
        /// Optional. Encryption key thumbprint.
        /// </summary>
        public string EncryptionKeyThumbprint
        {
            get { return this._encryptionKeyThumbprint; }
            set { this._encryptionKeyThumbprint = value; }
        }
        
        private string _integrityKey;
        
        /// <summary>
        /// Optional. Integrity key.
        /// </summary>
        public string IntegrityKey
        {
            get { return this._integrityKey; }
            set { this._integrityKey = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ResourceExtendedInfoProperties
        /// class.
        /// </summary>
        public ResourceExtendedInfoProperties()
        {
        }
    }
}
