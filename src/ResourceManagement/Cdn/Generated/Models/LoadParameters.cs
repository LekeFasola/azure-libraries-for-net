// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters required for content load.
    /// </summary>
    public partial class LoadParameters
    {
        /// <summary>
        /// Initializes a new instance of the LoadParameters class.
        /// </summary>
        public LoadParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LoadParameters class.
        /// </summary>
        /// <param name="contentPaths">The path to the content to be loaded.
        /// Path should be a relative file URL of the origin.</param>
        public LoadParameters(IList<string> contentPaths)
        {
            ContentPaths = contentPaths;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the path to the content to be loaded. Path should be a
        /// relative file URL of the origin.
        /// </summary>
        [JsonProperty(PropertyName = "contentPaths")]
        public IList<string> ContentPaths { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContentPaths == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContentPaths");
            }
        }
    }
}
