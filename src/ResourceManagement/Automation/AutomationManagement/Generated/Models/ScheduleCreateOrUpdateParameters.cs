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
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The parameters supplied to the create or update schedule operation.
    /// </summary>
    public partial class ScheduleCreateOrUpdateParameters
    {
        private bool _convertTimesFromTimeZone;
        
        /// <summary>
        /// Optional. True if times provided are specified in the provided time
        /// zone. False if times are in UTC.
        /// </summary>
        public bool ConvertTimesFromTimeZone
        {
            get { return this._convertTimesFromTimeZone; }
            set { this._convertTimesFromTimeZone = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the name of the schedule.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private ScheduleCreateOrUpdateProperties _properties;
        
        /// <summary>
        /// Required. Gets or sets the list of schedule properties.
        /// </summary>
        public ScheduleCreateOrUpdateProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ScheduleCreateOrUpdateParameters
        /// class.
        /// </summary>
        public ScheduleCreateOrUpdateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the ScheduleCreateOrUpdateParameters
        /// class with required arguments.
        /// </summary>
        public ScheduleCreateOrUpdateParameters(string name, ScheduleCreateOrUpdateProperties properties)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (properties == null)
            {
                throw new ArgumentNullException("properties");
            }
            this.Name = name;
            this.Properties = properties;
        }
    }
}