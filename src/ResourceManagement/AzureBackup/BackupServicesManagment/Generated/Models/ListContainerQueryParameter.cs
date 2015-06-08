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

namespace Microsoft.Azure.Management.BackupServices.Models
{
    /// <summary>
    /// The definition of a ListContainerQueryParameter object.
    /// </summary>
    public partial class ListContainerQueryParameter
    {
        private string _containerFriendlyNameField;
        
        /// <summary>
        /// Optional. Friendly name of container
        /// </summary>
        public string ContainerFriendlyNameField
        {
            get { return this._containerFriendlyNameField; }
            set { this._containerFriendlyNameField = value; }
        }
        
        private string _containerStatusField;
        
        /// <summary>
        /// Optional. Status of container
        /// </summary>
        public string ContainerStatusField
        {
            get { return this._containerStatusField; }
            set { this._containerStatusField = value; }
        }
        
        private string _containerTypeField;
        
        /// <summary>
        /// Required. Type of Container
        /// </summary>
        public string ContainerTypeField
        {
            get { return this._containerTypeField; }
            set { this._containerTypeField = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ListContainerQueryParameter class.
        /// </summary>
        public ListContainerQueryParameter()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the ListContainerQueryParameter class
        /// with required arguments.
        /// </summary>
        public ListContainerQueryParameter(string containerTypeField)
            : this()
        {
            if (containerTypeField == null)
            {
                throw new ArgumentNullException("containerTypeField");
            }
            this.ContainerTypeField = containerTypeField;
        }
    }
}