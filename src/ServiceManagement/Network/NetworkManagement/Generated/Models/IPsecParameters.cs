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

namespace Microsoft.WindowsAzure.Management.Network.Models
{
    public partial class IPsecParameters
    {
        private string _encryptionType;
        
        /// <summary>
        /// Optional. The encryption type that will be used on the connection.
        /// </summary>
        public string EncryptionType
        {
            get { return this._encryptionType; }
            set { this._encryptionType = value; }
        }
        
        private string _hashAlgorithm;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string HashAlgorithm
        {
            get { return this._hashAlgorithm; }
            set { this._hashAlgorithm = value; }
        }
        
        private string _pfsGroup;
        
        /// <summary>
        /// Optional. The PfsGroup type that will be used on the connection.
        /// </summary>
        public string PfsGroup
        {
            get { return this._pfsGroup; }
            set { this._pfsGroup = value; }
        }
        
        private int _sADataSizeKilobytes;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int SADataSizeKilobytes
        {
            get { return this._sADataSizeKilobytes; }
            set { this._sADataSizeKilobytes = value; }
        }
        
        private int _sALifeTimeSeconds;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int SALifeTimeSeconds
        {
            get { return this._sALifeTimeSeconds; }
            set { this._sALifeTimeSeconds = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the IPsecParameters class.
        /// </summary>
        public IPsecParameters()
        {
        }
    }
}
