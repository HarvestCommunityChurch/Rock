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
    /// Base client model for AttributeQualifier that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class AttributeQualifierEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public int AttributeId { get; set; }

        /// <summary />
        public bool IsSystem { get; set; }

        /// <summary />
        public string Key { get; set; }

        /// <summary />
        public string Value { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public string ForeignId { get; set; }

    }

    /// <summary>
    /// Client model for AttributeQualifier that includes all the fields that are available for GETs. Use this for GETs (use AttributeQualifierEntity for POST/PUTs)
    /// </summary>
    public partial class AttributeQualifier : AttributeQualifierEntity
    {

        /// <summary>
        /// Copies the base properties from a source AttributeQualifier object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( AttributeQualifier source )
        {
            this.Id = source.Id;
            this.AttributeId = source.AttributeId;
            this.IsSystem = source.IsSystem;
            this.Key = source.Key;
            this.Value = source.Value;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }
}
