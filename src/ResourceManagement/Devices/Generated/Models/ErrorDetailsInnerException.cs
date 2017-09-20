// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Devices.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Devices;
    using Microsoft.Azure.Management.Devices.Fluent;
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with ErrorDetailsInner
    /// information.
    /// </summary>
    public class ErrorDetailsInnerException : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public ErrorDetailsInner Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the ErrorDetailsInnerException class.
        /// </summary>
        public ErrorDetailsInnerException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorDetailsInnerException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public ErrorDetailsInnerException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorDetailsInnerException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public ErrorDetailsInnerException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}