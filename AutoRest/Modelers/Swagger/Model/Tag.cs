﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Rest.Modeler.Swagger.Model
{
    /// <summary>
    /// Represents a Swagger Tag
    /// </summary>
    public class Tag
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ExternalDoc ExternalDoc { get; set; }
    }
}