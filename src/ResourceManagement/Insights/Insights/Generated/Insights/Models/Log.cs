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
using Microsoft.Azure.Insights.Models;

namespace Microsoft.Azure.Insights.Models
{
    /// <summary>
    /// The log.
    /// </summary>
    public partial class Log
    {
        private LocalizableString _category;
        
        /// <summary>
        /// Optional. Gets or sets the category.
        /// </summary>
        public LocalizableString Category
        {
            get { return this._category; }
            set { this._category = value; }
        }
        
        private DateTime _endTime;
        
        /// <summary>
        /// Optional. Gets or sets the end time.
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private DateTime _startTime;
        
        /// <summary>
        /// Optional. Gets or sets the start time.
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private IList<LogValue> _value;
        
        /// <summary>
        /// Optional. Gets or sets the value of the collection.
        /// </summary>
        public IList<LogValue> Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Log class.
        /// </summary>
        public Log()
        {
            this.Value = new LazyList<LogValue>();
        }
    }
}
