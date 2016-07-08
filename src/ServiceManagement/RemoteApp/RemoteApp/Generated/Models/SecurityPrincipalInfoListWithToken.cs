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
using Microsoft.WindowsAzure.Management.RemoteApp.Models;

namespace Microsoft.WindowsAzure.Management.RemoteApp.Models
{
    /// <summary>
    /// The list of principals with consent status and continuation token.
    /// </summary>
    public partial class SecurityPrincipalInfoListWithToken
    {
        private string _newContinuationToken;
        
        /// <summary>
        /// Required. New continuation token.
        /// </summary>
        public string NewContinuationToken
        {
            get { return this._newContinuationToken; }
            set { this._newContinuationToken = value; }
        }
        
        private IList<SecurityPrincipalInfo> _securityPrincipalInfoList;
        
        /// <summary>
        /// Optional. The list of users and their consent status for this
        /// collection.
        /// </summary>
        public IList<SecurityPrincipalInfo> SecurityPrincipalInfoList
        {
            get { return this._securityPrincipalInfoList; }
            set { this._securityPrincipalInfoList = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// SecurityPrincipalInfoListWithToken class.
        /// </summary>
        public SecurityPrincipalInfoListWithToken()
        {
            this.SecurityPrincipalInfoList = new LazyList<SecurityPrincipalInfo>();
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// SecurityPrincipalInfoListWithToken class with required arguments.
        /// </summary>
        public SecurityPrincipalInfoListWithToken(string newContinuationToken)
            : this()
        {
            if (newContinuationToken == null)
            {
                throw new ArgumentNullException("newContinuationToken");
            }
            this.NewContinuationToken = newContinuationToken;
        }
    }
}
