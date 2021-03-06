// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Get Storage Account ManagementPolicies operation response.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagementPolicyInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ManagementPolicyInner class.
        /// </summary>
        public ManagementPolicyInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagementPolicyInner class.
        /// </summary>
        /// <param name="policy">The Storage Account ManagementPolicy, in JSON
        /// format. See more details in:
        /// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.</param>
        /// <param name="lastModifiedTime">Returns the date and time the
        /// ManagementPolicies was last modified.</param>
        public ManagementPolicyInner(ManagementPolicySchema policy, string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.DateTime? lastModifiedTime = default(System.DateTime?))
            : base(location, id, name, type, tags)
        {
            LastModifiedTime = lastModifiedTime;
            Policy = policy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets returns the date and time the ManagementPolicies was last
        /// modified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets or sets the Storage Account ManagementPolicy, in JSON format.
        /// See more details in:
        /// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
        /// </summary>
        [JsonProperty(PropertyName = "properties.policy")]
        public ManagementPolicySchema Policy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Policy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Policy");
            }
            if (Policy != null)
            {
                Policy.Validate();
            }
        }
    }
}
