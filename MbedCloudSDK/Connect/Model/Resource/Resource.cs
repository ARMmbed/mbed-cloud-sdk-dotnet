﻿// <copyright file="Resource.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>

namespace MbedCloudSDK.Connect.Model.Resource
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MbedCloudSDK.Connect.Api;
    using MbedCloudSDK.Connect.Model.ConnectedDevice;
    using Newtonsoft.Json;

    /// <summary>
    /// Resource.
    /// </summary>
    public class Resource
    {
        private Connect.Api.ConnectApi api;

        /// <summary>
        /// Initializes a new instance of the <see cref="Resource"/> class.
        /// Initializes new Resource.
        /// </summary>
        /// <param name="deviceID">Id of the device that the resource belongs to.</param>
        /// <param name="options">Dictionary used to initialize Resource.</param>
        /// <param name="api">DeviceDirectory API.</param>
        public Resource(string deviceID, IDictionary<string, object> options = null, ConnectApi api = null)
        {
            this.api = api;
            DeviceId = deviceID;
            if (options != null)
            {
                foreach (KeyValuePair<string, object> item in options)
                {
                    var property = GetType().GetProperty(item.Key);
                    if (property != null)
                    {
                        property.SetValue(this, item.Value, null);
                    }
                }
            }
        }

        /// <summary>
        /// Gets ID of the device this resource belongs to.
        /// </summary>
        [JsonProperty]
        public string DeviceId { get; private set; }

        /// <summary>
        /// Gets resource&#39;s type
        /// </summary>
        [JsonProperty]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the content type of the resource. You are encouraged to use the resource types listed in the LWM2M specification: http://technical.openmobilealliance.org/Technical/technical-information/omna/lightweight-m2m-lwm2m-object-registry
        /// </summary>
        [JsonProperty]
        public string ConentType { get; private set; }

        /// <summary>
        /// Gets resource URL.
        /// </summary>
        /// <value>Resource&#39;s url.</value>
        [JsonProperty]
        public string Path { get; private set; }

        /// <summary>
        /// Gets observable determines whether you can subscribe to changes for this resource.
        /// </summary>
        [JsonProperty]
        public bool? Observable { get; private set; }

        /// <summary>
        /// Gets or sets the queue values.
        /// </summary>
        public AsyncProducerConsumerCollection<string> Queue { get; set; }

        /// <summary>
        /// Map to Resource object.
        /// </summary>
        /// <param name="deviceID">Id of the devi</param>
        /// <param name="res">resource</param>
        /// <param name="api">Api</param>
        /// <returns>Resource</returns>
        public static Resource Map(string deviceID, mds.Model.Resource res, ConnectApi api)
        {
            var resource = new Resource(deviceID, null, api)
            {
                Type = res.Rt,
                ConentType = res.Type,
                Path = res.Uri,
                Observable = res.Obs,
                Queue = new AsyncProducerConsumerCollection<string>()
            };
            return resource;
        }

        /// <summary>
        /// Gets the value of the resource.
        /// </summary>
        /// <returns>Resource value</returns>
        public string GetResourceValue()
        {
            return api.GetResourceValue(DeviceId, Path);
        }

        /// <summary>
        /// Set value of the resource.
        /// </summary>
        /// <param name="resourceValue">Value to set.</param>
        /// <param name="noResponse">Don't get a response.</param>
        /// <returns>Async consumer with string</returns>
        public AsyncConsumer<string> SetResourceValue(string resourceValue, bool? noResponse = null)
        {
            return api.SetResourceValue(DeviceId, Path, resourceValue, noResponse);
        }

        /// <summary>
        /// Subscribe to this resource.
        /// </summary>
        /// <returns>Async consumer with string</returns>
        public AsyncConsumer<string> Subscribe()
        {
            return api.AddResourceSubscription(DeviceId, Path);
        }

        /// <summary>
        /// Unsubscribe this resource.
        /// </summary>
        public void Unsubscribe()
        {
            api.DeleteResourceSubscription(DeviceId, Path);
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Resource {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Conent Type: ").Append(ConentType).Append("\n");
            sb.Append("  Uri: ").Append(Path).Append("\n");
            sb.Append("  Obs: ").Append(Observable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
