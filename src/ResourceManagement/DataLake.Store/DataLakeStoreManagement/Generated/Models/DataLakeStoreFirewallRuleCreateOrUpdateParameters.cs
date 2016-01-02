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
using Microsoft.Azure.Management.DataLake.Store.Models;

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    /// <summary>
    /// Data Lake Store firewall rule parameters for creation and updates to
    /// the firewall rules.
    /// </summary>
    public partial class DataLakeStoreFirewallRuleCreateOrUpdateParameters
    {
        private FirewallRule _firewallRule;
        
        /// <summary>
        /// Required. Gets or sets the firewall rules that are being added or
        /// updated.
        /// </summary>
        public FirewallRule FirewallRule
        {
            get { return this._firewallRule; }
            set { this._firewallRule = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeStoreFirewallRuleCreateOrUpdateParameters class.
        /// </summary>
        public DataLakeStoreFirewallRuleCreateOrUpdateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeStoreFirewallRuleCreateOrUpdateParameters class with
        /// required arguments.
        /// </summary>
        public DataLakeStoreFirewallRuleCreateOrUpdateParameters(FirewallRule firewallRule)
            : this()
        {
            if (firewallRule == null)
            {
                throw new ArgumentNullException("firewallRule");
            }
            this.FirewallRule = firewallRule;
        }
    }
}
