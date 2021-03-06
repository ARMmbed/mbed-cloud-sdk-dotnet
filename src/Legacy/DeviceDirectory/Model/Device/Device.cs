﻿// <copyright file="Device.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>

namespace MbedCloudSDK.DeviceDirectory.Model.Device
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using device_directory.Model;
    using Mbed.Cloud.Common;
    using MbedCloudSDK.Common;
    using MbedCloudSDK.Common.Extensions;
    using MbedCloudSDK.DeviceDirectory.Api;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Device
    /// </summary>
    public class Device : Entity
    {
        private readonly DeviceDirectoryApi api;

        /// <summary>
        /// Initializes a new instance of the <see cref="Device"/> class.
        /// Default constructor
        /// </summary>
        public Device()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class.
        /// </summary>
        /// <param name="api">DeviceDirectory Api.</param>
        public Device(DeviceDirectoryApi api)
        {
            this.api = api;
        }

        /// <summary>
        /// Gets or sets the ID of the channel used to communicate with the device
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Mechanism? Mechanism { get; set; }

        /// <summary>
        /// Gets or sets the current state of the device
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public State? State { get; set; }

        /// <summary>
        /// Gets or sets the state of the device's deployment
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public DeployedState? DeployedState { get; set; }

        /// <summary>
        /// Gets or sets gets or Sets BootstrappedTimestamp
        /// </summary>
        public DateTime? BootstrappedTimestamp { get; set; }

        /// <summary>
        /// Gets the time the object was updated
        /// </summary>
        [JsonProperty]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Gets or sets up to 5 custom JSON attributes
        /// </summary>
        public Dictionary<string, string> CustomAttributes { get; set; }

        /// <summary>
        /// Gets or sets the device class
        /// </summary>
        public string DeviceClass { get; set; }

        /// <summary>
        /// Gets or sets the description of the object
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets mark this device for auto firmware update
        /// </summary>
        public bool? AutoUpdate { get; set; }

        /// <summary>
        /// Gets or sets the key used to provision the device
        /// </summary>
        public string ProvisionKey { get; set; }

        /// <summary>
        /// Gets or sets the serial number of the device
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets the device vendor ID
        /// </summary>
        public string VendorId { get; set; }

        /// <summary>
        /// Gets the owning IAM account ID
        /// </summary>
        [JsonProperty]
        public string AccountId { get; internal set; }

        /// <summary>
        /// Gets or sets the last deployment used on the device
        /// </summary>
        public string Deployment { get; set; }

        /// <summary>
        /// Gets or sets the address of the connector to use
        /// </summary>
        public string MechanismUrl { get; set; }

        /// <summary>
        /// Gets or sets the name of the object
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the time the object was created
        /// </summary>
        [JsonProperty]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Gets or sets URL for the current device manifest
        /// </summary>
        public string Manifest { get; set; }

        /// <summary>
        /// Gets the timestamp of the current manifest version
        /// </summary>
        [JsonProperty]
        public DateTime? ManifestTimestamp { get; internal set; }

        /// <summary>
        /// Gets or sets fingerprint of the device certificate
        /// </summary>
        public string CertificateFingerprint { get; set; }

        /// <summary>
        /// Gets or sets ID of the issuer of the certificate
        /// </summary>
        public string CertificateIssuerId { get; set; }

        /// <summary>
        /// Gets or sets expiration date of the certificate used to connect to bootstrap server
        /// </summary>
        public DateTime? BootstrapCertificateExpiration { get; set; }

        /// <summary>
        /// Gets or sets expiration date of the certificate used to connect to connector server
        /// </summary>
        public DateTime? ConnectorCertificateExpiration { get; set; }

        /// <summary>
        /// Gets or sets the endpoint name given to the device
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Gets or sets the endpoint_name of the host gateway, if appropriate
        /// </summary>
        public string HostGateway { get; set; }

        /// <summary>
        /// Gets or sets defines the type of certificate used
        /// </summary>
        public int? DeviceExecutionMode { get; set; }

        /// <summary>
        /// Gets or sets the SHA256 checksum of the current firmware image
        /// </summary>
        public string FirmwareChecksum { get; set; }

        /// <summary>
        /// Gets or sets the endpoint type of the device - e.g. if the device is a gateway
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// Gets the claim date/time
        /// </summary>
        public DateTime? ClaimedAt { get; internal set; }

        /// <summary>
        /// Map to Device object.
        /// </summary>
        /// <param name="deviceData">DeviceDetal response object.</param>
        /// <param name="api">optional DeviceDirectoryApi</param>
        /// <returns>Device</returns>
        public static Device Map(DeviceData deviceData, DeviceDirectoryApi api = null)
        {
            var device = new Device(api)
            {
                BootstrappedTimestamp = deviceData.BootstrappedTimestamp.ToNullableUniversalTime(),
                UpdatedAt = deviceData.UpdatedAt.ToNullableUniversalTime(),
                CustomAttributes = deviceData.CustomAttributes,
                DeviceClass = deviceData.DeviceClass,
                Description = deviceData.Description,
                AutoUpdate = deviceData.AutoUpdate,
                Mechanism = deviceData.Mechanism.ParseEnum<Mechanism>(),
                State = deviceData.State.ParseEnum<State>(),
                ProvisionKey = deviceData.DeviceKey,
                SerialNumber = deviceData.SerialNumber,
                VendorId = deviceData.VendorId,
                AccountId = deviceData.AccountId,
                DeployedState = deviceData.DeployedState.ParseEnum<DeployedState>(),
                Deployment = deviceData.Deployment,
                MechanismUrl = deviceData.MechanismUrl,
                Id = deviceData.Id,
                Name = deviceData.Name,
                CreatedAt = deviceData.CreatedAt.ToNullableUniversalTime(),
                Manifest = deviceData.Manifest,
                CertificateFingerprint = deviceData.DeviceKey,
                CertificateIssuerId = deviceData.CaId,
                BootstrapCertificateExpiration = deviceData.BootstrapExpirationDate.ToNullableUniversalTime(),
                ConnectorCertificateExpiration = deviceData.ConnectorExpirationDate.ToNullableUniversalTime(),
                Alias = deviceData.EndpointName,
                HostGateway = deviceData.HostGateway,
                DeviceExecutionMode = deviceData.DeviceExecutionMode,
                FirmwareChecksum = deviceData.FirmwareChecksum,
                DeviceType = deviceData.EndpointType,
                ManifestTimestamp = deviceData.ManifestTimestamp.ToNullableUniversalTime(),
                ClaimedAt = deviceData.EnrolmentListTimestamp,
            };
            return device;
        }

        /// <summary>
        /// Create a device data post request
        /// </summary>
        /// <param name="device">Device</param>
        /// <returns>a device data post request</returns>
        public static DeviceDataPostRequest CreatePostRequest(Device device)
        {
            DeviceDataPostRequest.MechanismEnum? mechanism = null;
            if (device.Mechanism.HasValue)
            {
                mechanism = device.Mechanism.ParseEnum<DeviceDataPostRequest.MechanismEnum>();
            }

            DeviceDataPostRequest.StateEnum? state = null;
            if (device.State.HasValue)
            {
                device.State.ParseEnum<DeviceDataPostRequest.StateEnum>();
            }

            var deviceDataPostRequest = new DeviceDataPostRequest(DeviceKey: device.CertificateFingerprint, CaId: device.CertificateIssuerId)
            {
                BootstrapExpirationDate = device.BootstrapCertificateExpiration.ToNullableUniversalTime(),
                BootstrappedTimestamp = device.BootstrappedTimestamp.ToNullableUniversalTime(),
                ConnectorExpirationDate = device.ConnectorCertificateExpiration.ToNullableUniversalTime(),
                Mechanism = mechanism,
                DeviceClass = device.DeviceClass,
                EndpointName = device.Alias,
                AutoUpdate = device.AutoUpdate,
                HostGateway = device.HostGateway,
                DeviceExecutionMode = device.DeviceExecutionMode,
                CustomAttributes = device.CustomAttributes,
                State = state,
                SerialNumber = device.SerialNumber,
                FirmwareChecksum = device.FirmwareChecksum,
                VendorId = device.VendorId,
                Description = device.Description,
                EndpointType = device.DeviceType,
                Deployment = device.Deployment,
                MechanismUrl = device.MechanismUrl,
                Name = device.Name,
                DeviceKey = device.CertificateFingerprint,
                Manifest = device.Manifest,
                CaId = device.CertificateIssuerId,
            };

            return deviceDataPostRequest;
        }

        /// <summary>
        /// Create a device data put request
        /// </summary>
        /// <param name="device">Device</param>
        /// <returns>A device data put request</returns>
        public static DeviceDataPutRequest CreatePutRequest(Device device)
        {
            var deviceDataPutRequest = new DeviceDataPutRequest(CaId: device.CertificateIssuerId, DeviceKey: device.CertificateFingerprint)
            {
                Description = device.Description,
                EndpointName = device.Alias,
                AutoUpdate = device.AutoUpdate,
                HostGateway = device.HostGateway,
                CustomAttributes = device.CustomAttributes,
                EndpointType = device.DeviceType,
                Name = device.Name,
            };

            return deviceDataPutRequest;
        }

        /// <summary>
        /// Returns the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
            => this.DebugDump();
    }
}
