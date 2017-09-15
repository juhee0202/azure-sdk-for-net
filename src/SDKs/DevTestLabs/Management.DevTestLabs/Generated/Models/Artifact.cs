// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// An artifact.
    /// </summary>
    [JsonTransformation]
    public partial class Artifact : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Artifact class.
        /// </summary>
        public Artifact() { }

        /// <summary>
        /// Initializes a new instance of the Artifact class.
        /// </summary>
        public Artifact(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string title = default(string), string description = default(string), string publisher = default(string), string filePath = default(string), string icon = default(string), string targetOsType = default(string), object parameters = default(object), DateTime? createdDate = default(DateTime?))
            : base(id, name, type, location, tags)
        {
            Title = title;
            Description = description;
            Publisher = publisher;
            FilePath = filePath;
            Icon = icon;
            TargetOsType = targetOsType;
            Parameters = parameters;
            CreatedDate = createdDate;
        }

        /// <summary>
        /// The artifact's title.
        /// </summary>
        [JsonProperty(PropertyName = "properties.title")]
        public string Title { get; private set; }

        /// <summary>
        /// The artifact's description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// The artifact's publisher.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisher")]
        public string Publisher { get; private set; }

        /// <summary>
        /// The file path to the artifact.
        /// </summary>
        [JsonProperty(PropertyName = "properties.filePath")]
        public string FilePath { get; private set; }

        /// <summary>
        /// The URI to the artifact icon.
        /// </summary>
        [JsonProperty(PropertyName = "properties.icon")]
        public string Icon { get; private set; }

        /// <summary>
        /// The artifact's target OS.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetOsType")]
        public string TargetOsType { get; private set; }

        /// <summary>
        /// The artifact's parameters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public object Parameters { get; private set; }

        /// <summary>
        /// The artifact's creation date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public DateTime? CreatedDate { get; private set; }

    }
}