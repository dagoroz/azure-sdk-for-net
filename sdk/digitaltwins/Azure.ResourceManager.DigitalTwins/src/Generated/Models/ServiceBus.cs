// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> properties related to servicebus. </summary>
    public partial class ServiceBus : DigitalTwinsEndpointResourceProperties
    {
        /// <summary> Initializes a new instance of ServiceBus. </summary>
        /// <param name="primaryConnectionString"> PrimaryConnectionString of the endpoint. Will be obfuscated during read. </param>
        /// <param name="secondaryConnectionString"> SecondaryConnectionString of the endpoint. Will be obfuscated during read. </param>
        public ServiceBus(string primaryConnectionString, string secondaryConnectionString)
        {
            if (primaryConnectionString == null)
            {
                throw new ArgumentNullException(nameof(primaryConnectionString));
            }
            if (secondaryConnectionString == null)
            {
                throw new ArgumentNullException(nameof(secondaryConnectionString));
            }

            PrimaryConnectionString = primaryConnectionString;
            SecondaryConnectionString = secondaryConnectionString;
            EndpointType = "ServiceBus";
        }

        /// <summary> Initializes a new instance of ServiceBus. </summary>
        /// <param name="endpointType"> The type of Digital Twins endpoint. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="createdTime"> Time when the Endpoint was added to DigitalTwinsInstance. </param>
        /// <param name="tags"> The resource tags. </param>
        /// <param name="primaryConnectionString"> PrimaryConnectionString of the endpoint. Will be obfuscated during read. </param>
        /// <param name="secondaryConnectionString"> SecondaryConnectionString of the endpoint. Will be obfuscated during read. </param>
        internal ServiceBus(EndpointType endpointType, EndpointProvisioningState? provisioningState, DateTimeOffset? createdTime, IDictionary<string, string> tags, string primaryConnectionString, string secondaryConnectionString) : base(endpointType, provisioningState, createdTime, tags)
        {
            PrimaryConnectionString = primaryConnectionString;
            SecondaryConnectionString = secondaryConnectionString;
            EndpointType = endpointType;
        }

        /// <summary> PrimaryConnectionString of the endpoint. Will be obfuscated during read. </summary>
        public string PrimaryConnectionString { get; set; }
        /// <summary> SecondaryConnectionString of the endpoint. Will be obfuscated during read. </summary>
        public string SecondaryConnectionString { get; set; }
    }
}
