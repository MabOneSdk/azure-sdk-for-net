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
using Microsoft.WindowsAzure.Scheduler.Models;

namespace Microsoft.WindowsAzure.Scheduler.Models
{
    /// <summary>
    /// Action to invoke for the job.
    /// </summary>
    public partial class JobAction
    {
        private JobErrorAction _errorAction;
        
        /// <summary>
        /// Optional. Error Action for the job.
        /// </summary>
        public JobErrorAction ErrorAction
        {
            get { return this._errorAction; }
            set { this._errorAction = value; }
        }
        
        private JobQueueMessage _queueMessage;
        
        /// <summary>
        /// Optional. Queue and content for a queue message action type.
        /// </summary>
        public JobQueueMessage QueueMessage
        {
            get { return this._queueMessage; }
            set { this._queueMessage = value; }
        }
        
        private JobHttpRequest _request;
        
        /// <summary>
        /// Optional. Request for a http or https action type.
        /// </summary>
        public JobHttpRequest Request
        {
            get { return this._request; }
            set { this._request = value; }
        }
        
        private RetryPolicy _retryPolicy;
        
        /// <summary>
        /// Optional. Retry Policy for the job action.
        /// </summary>
        public RetryPolicy RetryPolicy
        {
            get { return this._retryPolicy; }
            set { this._retryPolicy = value; }
        }
        
        private JobServiceBusQueueMessage _serviceBusQueueMessage;
        
        /// <summary>
        /// Optional. Queue and content for a service bus topic message action
        /// type.
        /// </summary>
        public JobServiceBusQueueMessage ServiceBusQueueMessage
        {
            get { return this._serviceBusQueueMessage; }
            set { this._serviceBusQueueMessage = value; }
        }
        
        private JobServiceBusTopicMessage _serviceBusTopicMessage;
        
        /// <summary>
        /// Optional. Topic and content for a service bus topic message action
        /// type.
        /// </summary>
        public JobServiceBusTopicMessage ServiceBusTopicMessage
        {
            get { return this._serviceBusTopicMessage; }
            set { this._serviceBusTopicMessage = value; }
        }
        
        private JobActionType _type;
        
        /// <summary>
        /// Required. Type of action. Can be one of http, https, storageQueue.
        /// </summary>
        public JobActionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobAction class.
        /// </summary>
        public JobAction()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the JobAction class with required
        /// arguments.
        /// </summary>
        public JobAction(JobActionType type)
            : this()
        {
            this.Type = type;
        }
    }
}
