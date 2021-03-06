// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The registry node that generated the event. Put differently, while the
    /// actor initiates the event, the source generates it.
    /// </summary>
    public partial class Source
    {
        /// <summary>
        /// Initializes a new instance of the Source class.
        /// </summary>
        public Source()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Source class.
        /// </summary>
        /// <param name="addr">The IP or hostname and the port of the registry
        /// node that generated the event. Generally, this will be resolved by
        /// os.Hostname() along with the running port.</param>
        /// <param name="instanceID">The running instance of an application.
        /// Changes after each restart.</param>
        public Source(string addr = default(string), string instanceID = default(string))
        {
            Addr = addr;
            InstanceID = instanceID;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the IP or hostname and the port of the registry node
        /// that generated the event. Generally, this will be resolved by
        /// os.Hostname() along with the running port.
        /// </summary>
        [JsonProperty(PropertyName = "addr")]
        public string Addr { get; set; }

        /// <summary>
        /// Gets or sets the running instance of an application. Changes after
        /// each restart.
        /// </summary>
        [JsonProperty(PropertyName = "instanceID")]
        public string InstanceID { get; set; }

    }
}
