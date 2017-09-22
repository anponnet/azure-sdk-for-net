// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An error that occurred when resizing a pool.
    /// </summary>
    public partial class ResizeError
    {
        /// <summary>
        /// Initializes a new instance of the ResizeError class.
        /// </summary>
        public ResizeError()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResizeError class.
        /// </summary>
        /// <param name="code">An identifier for the pool resize error. Codes
        /// are invariant and are intended to be consumed
        /// programmatically.</param>
        /// <param name="message">A message describing the pool resize error,
        /// intended to be suitable for display in a user interface.</param>
        /// <param name="values">A list of additional error details related to
        /// the pool resize error.</param>
        public ResizeError(string code = default(string), string message = default(string), IList<NameValuePair> values = default(IList<NameValuePair>))
        {
            Code = code;
            Message = message;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an identifier for the pool resize error. Codes are
        /// invariant and are intended to be consumed programmatically.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a message describing the pool resize error, intended
        /// to be suitable for display in a user interface.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a list of additional error details related to the pool
        /// resize error.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<NameValuePair> Values { get; set; }

    }
}