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

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    /// <summary>
    /// Description of a NotificationHub BaiduCredential.
    /// </summary>
    public partial class BaiduCredentialProperties
    {
        private string _baiduApiKey;
        
        /// <summary>
        /// Optional. Get or Set Baidu Api Key.
        /// </summary>
        public string BaiduApiKey
        {
            get { return this._baiduApiKey; }
            set { this._baiduApiKey = value; }
        }
        
        private string _baiduEndPoint;
        
        /// <summary>
        /// Optional. Get or Set Baidu Endpoint.
        /// </summary>
        public string BaiduEndPoint
        {
            get { return this._baiduEndPoint; }
            set { this._baiduEndPoint = value; }
        }
        
        private string _baiduSecretKey;
        
        /// <summary>
        /// Optional. Get or Set Baidu Secret Key
        /// </summary>
        public string BaiduSecretKey
        {
            get { return this._baiduSecretKey; }
            set { this._baiduSecretKey = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BaiduCredentialProperties class.
        /// </summary>
        public BaiduCredentialProperties()
        {
        }
    }
}
