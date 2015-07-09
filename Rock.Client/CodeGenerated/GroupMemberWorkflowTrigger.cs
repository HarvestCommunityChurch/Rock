//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright 2013 by the Spark Development Network
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Base client model for GroupMemberWorkflowTrigger that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class GroupMemberWorkflowTriggerEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public int? GroupId { get; set; }

        /// <summary />
        public int? GroupTypeId { get; set; }

        /// <summary />
        public bool IsActive { get; set; }

        /// <summary />
        public string Name { get; set; }

        /// <summary />
        public int Order { get; set; }

        /// <summary />
        public Rock.Client.Enums.GroupMemberWorkflowTriggerType TriggerType { get; set; }

        /// <summary />
        public string TypeQualifier { get; set; }

        /// <summary />
        public string WorkflowName { get; set; }

        /// <summary />
        public int WorkflowTypeId { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public string ForeignId { get; set; }

    }

    /// <summary>
    /// Client model for GroupMemberWorkflowTrigger that includes all the fields that are available for GETs. Use this for GETs (use GroupMemberWorkflowTriggerEntity for POST/PUTs)
    /// </summary>
    public partial class GroupMemberWorkflowTrigger : GroupMemberWorkflowTriggerEntity
    {
        /// <summary />
        public Group Group { get; set; }

        /// <summary />
        public GroupType GroupType { get; set; }

        /// <summary />
        public WorkflowType WorkflowType { get; set; }


        /// <summary>
        /// Copies the base properties from a source GroupMemberWorkflowTrigger object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( GroupMemberWorkflowTrigger source )
        {
            this.Id = source.Id;
            this.GroupId = source.GroupId;
            this.GroupTypeId = source.GroupTypeId;
            this.IsActive = source.IsActive;
            this.Name = source.Name;
            this.Order = source.Order;
            this.TriggerType = source.TriggerType;
            this.TypeQualifier = source.TypeQualifier;
            this.WorkflowName = source.WorkflowName;
            this.WorkflowTypeId = source.WorkflowTypeId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }
}
