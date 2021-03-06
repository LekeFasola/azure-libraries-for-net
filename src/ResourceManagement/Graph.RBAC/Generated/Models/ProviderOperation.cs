// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Operation
    /// </summary>
    public partial class ProviderOperation
    {
        /// <summary>
        /// Initializes a new instance of the ProviderOperation class.
        /// </summary>
        public ProviderOperation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProviderOperation class.
        /// </summary>
        /// <param name="name">The operation name.</param>
        /// <param name="displayName">The operation display name.</param>
        /// <param name="description">The operation description.</param>
        /// <param name="origin">The operation origin.</param>
        /// <param name="properties">The operation properties.</param>
        /// <param name="isDataAction">The dataAction flag to specify the
        /// operation type.</param>
        public ProviderOperation(string name = default(string), string displayName = default(string), string description = default(string), string origin = default(string), object properties = default(object), bool? isDataAction = default(bool?))
        {
            Name = name;
            DisplayName = displayName;
            Description = description;
            Origin = origin;
            Properties = properties;
            IsDataAction = isDataAction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the operation name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the operation display name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the operation description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the operation origin.
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets the operation properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

        /// <summary>
        /// Gets or sets the dataAction flag to specify the operation type.
        /// </summary>
        [JsonProperty(PropertyName = "isDataAction")]
        public bool? IsDataAction { get; set; }

    }
}
