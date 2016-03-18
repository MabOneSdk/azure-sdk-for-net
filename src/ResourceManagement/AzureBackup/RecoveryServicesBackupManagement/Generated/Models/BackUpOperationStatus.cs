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
    /// The definition for OperationStatus class.
    /// </summary>
    public partial class BackUpOperationStatus
    {
        private string _endTime;
        
        /// <summary>
        /// Optional. EndTime for OperationStatus
        /// </summary>
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. OperationStatus Id
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Name for OperationStatus
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private OperationStatusError _operationStatusError;
        
        /// <summary>
        /// Optional. OperationStatusError for OperationStatus
        /// </summary>
        public OperationStatusError OperationStatusError
        {
            get { return this._operationStatusError; }
            set { this._operationStatusError = value; }
        }
        
        private OperationStatusExtendedInfo _properties;
        
        /// <summary>
        /// Optional. Properties for the OperationStatus
        /// </summary>
        public OperationStatusExtendedInfo Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private string _startTime;
        
        /// <summary>
        /// Optional. StartTime for OperationStatus
        /// </summary>
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Status for OperationStatus
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BackUpOperationStatus class.
        /// </summary>
        public BackUpOperationStatus()
        {
        }
    }
}
