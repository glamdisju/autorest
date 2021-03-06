// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureParameterGrouping.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Additional parameters for the postOptional operation.
    /// </summary>
    public partial class ParameterGroupingPostOptionalParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ParameterGroupingPostOptionalParameters class.
        /// </summary>
        public ParameterGroupingPostOptionalParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ParameterGroupingPostOptionalParameters class.
        /// </summary>
        public ParameterGroupingPostOptionalParameters(string customHeader = default(string), int? query = default(int?))
        {
            CustomHeader = customHeader;
            Query = query;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public string CustomHeader { get; set; }

        /// <summary>
        /// Query parameter with default
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public int? Query { get; set; }

    }
}
