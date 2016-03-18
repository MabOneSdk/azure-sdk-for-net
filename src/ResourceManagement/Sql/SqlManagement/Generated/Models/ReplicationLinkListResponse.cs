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
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Represents the response to a List Azure Sql Database Replication Link
    /// request.
    /// </summary>
    public partial class ReplicationLinkListResponse : AzureOperationResponse, IEnumerable<ReplicationLink>
    {
        private IList<ReplicationLink> _replicationLinks;
        
        /// <summary>
        /// Optional. Gets or sets the list of Azure Sql Database Replication
        /// Links housed in the database.
        /// </summary>
        public IList<ReplicationLink> ReplicationLinks
        {
            get { return this._replicationLinks; }
            set { this._replicationLinks = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ReplicationLinkListResponse class.
        /// </summary>
        public ReplicationLinkListResponse()
        {
            this.ReplicationLinks = new LazyList<ReplicationLink>();
        }
        
        /// <summary>
        /// Gets the sequence of ReplicationLinks.
        /// </summary>
        public IEnumerator<ReplicationLink> GetEnumerator()
        {
            return this.ReplicationLinks.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of ReplicationLinks.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
