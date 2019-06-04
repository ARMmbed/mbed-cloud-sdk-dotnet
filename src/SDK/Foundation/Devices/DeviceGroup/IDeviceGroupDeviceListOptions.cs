// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="IDeviceGroupDeviceListOptions.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Common.Filters;
    using System.Collections.Generic;
    using System;

    /// <summary>
    /// DeviceGroupDeviceListOptions
    /// </summary>
    public interface IDeviceGroupDeviceListOptions : IQueryOptions
    {
        /// <summary>
        /// Filter object
        /// </summary>
        Filter Filter
        {
            get;
            set;
        }

        DeviceGroupDeviceListOptions AccountIdEqualTo(string value);
        DeviceGroupDeviceListOptions AccountIdNotEqualTo(string value);
        DeviceGroupDeviceListOptions AccountIdIn(params string[] value);
        DeviceGroupDeviceListOptions AccountIdNotIn(params string[] value);
        DeviceGroupDeviceListOptions AutoUpdateEqualTo(string value);
        DeviceGroupDeviceListOptions AutoUpdateNotEqualTo(string value);
        DeviceGroupDeviceListOptions BootstrapExpirationDateIn(params string[] value);
        DeviceGroupDeviceListOptions BootstrapExpirationDateNotIn(params string[] value);
        DeviceGroupDeviceListOptions BootstrapExpirationDateLessThan(string value);
        DeviceGroupDeviceListOptions BootstrapExpirationDateGreaterThan(string value);
        DeviceGroupDeviceListOptions BootstrappedTimestampIn(params string[] value);
        DeviceGroupDeviceListOptions BootstrappedTimestampNotIn(params string[] value);
        DeviceGroupDeviceListOptions BootstrappedTimestampLessThan(string value);
        DeviceGroupDeviceListOptions BootstrappedTimestampGreaterThan(string value);
        DeviceGroupDeviceListOptions CaIdEqualTo(string value);
        DeviceGroupDeviceListOptions CaIdNotEqualTo(string value);
        DeviceGroupDeviceListOptions CaIdIn(params string[] value);
        DeviceGroupDeviceListOptions CaIdNotIn(params string[] value);
        DeviceGroupDeviceListOptions ConnectorExpirationDateIn(params string[] value);
        DeviceGroupDeviceListOptions ConnectorExpirationDateNotIn(params string[] value);
        DeviceGroupDeviceListOptions ConnectorExpirationDateLessThan(string value);
        DeviceGroupDeviceListOptions ConnectorExpirationDateGreaterThan(string value);
        DeviceGroupDeviceListOptions CreatedAtIn(params DateTime[] value);
        DeviceGroupDeviceListOptions CreatedAtNotIn(params DateTime[] value);
        DeviceGroupDeviceListOptions CreatedAtLessThan(DateTime value);
        DeviceGroupDeviceListOptions CreatedAtGreaterThan(DateTime value);
        DeviceGroupDeviceListOptions DeployedStateEqualTo(string value);
        DeviceGroupDeviceListOptions DeployedStateNotEqualTo(string value);
        DeviceGroupDeviceListOptions DeployedStateIn(params string[] value);
        DeviceGroupDeviceListOptions DeployedStateNotIn(params string[] value);
        DeviceGroupDeviceListOptions DeploymentEqualTo(string value);
        DeviceGroupDeviceListOptions DeploymentNotEqualTo(string value);
        DeviceGroupDeviceListOptions DeploymentIn(params string[] value);
        DeviceGroupDeviceListOptions DeploymentNotIn(params string[] value);
        DeviceGroupDeviceListOptions DescriptionEqualTo(string value);
        DeviceGroupDeviceListOptions DescriptionNotEqualTo(string value);
        DeviceGroupDeviceListOptions DescriptionIn(params string[] value);
        DeviceGroupDeviceListOptions DescriptionNotIn(params string[] value);
        DeviceGroupDeviceListOptions DeviceClassEqualTo(string value);
        DeviceGroupDeviceListOptions DeviceClassNotEqualTo(string value);
        DeviceGroupDeviceListOptions DeviceClassIn(params string[] value);
        DeviceGroupDeviceListOptions DeviceClassNotIn(params string[] value);
        DeviceGroupDeviceListOptions DeviceExecutionModeEqualTo(string value);
        DeviceGroupDeviceListOptions DeviceExecutionModeNotEqualTo(string value);
        DeviceGroupDeviceListOptions DeviceExecutionModeIn(params string[] value);
        DeviceGroupDeviceListOptions DeviceExecutionModeNotIn(params string[] value);
        DeviceGroupDeviceListOptions DeviceKeyEqualTo(string value);
        DeviceGroupDeviceListOptions DeviceKeyNotEqualTo(string value);
        DeviceGroupDeviceListOptions DeviceKeyIn(params string[] value);
        DeviceGroupDeviceListOptions DeviceKeyNotIn(params string[] value);
        DeviceGroupDeviceListOptions EndpointNameEqualTo(string value);
        DeviceGroupDeviceListOptions EndpointNameNotEqualTo(string value);
        DeviceGroupDeviceListOptions EndpointNameIn(params string[] value);
        DeviceGroupDeviceListOptions EndpointNameNotIn(params string[] value);
        DeviceGroupDeviceListOptions EndpointTypeEqualTo(string value);
        DeviceGroupDeviceListOptions EndpointTypeNotEqualTo(string value);
        DeviceGroupDeviceListOptions EndpointTypeIn(params string[] value);
        DeviceGroupDeviceListOptions EndpointTypeNotIn(params string[] value);
        DeviceGroupDeviceListOptions EnrolmentListTimestampIn(params string[] value);
        DeviceGroupDeviceListOptions EnrolmentListTimestampNotIn(params string[] value);
        DeviceGroupDeviceListOptions EnrolmentListTimestampLessThan(string value);
        DeviceGroupDeviceListOptions EnrolmentListTimestampGreaterThan(string value);
        DeviceGroupDeviceListOptions FirmwareChecksumEqualTo(string value);
        DeviceGroupDeviceListOptions FirmwareChecksumNotEqualTo(string value);
        DeviceGroupDeviceListOptions FirmwareChecksumIn(params string[] value);
        DeviceGroupDeviceListOptions FirmwareChecksumNotIn(params string[] value);
        DeviceGroupDeviceListOptions HostGatewayEqualTo(string value);
        DeviceGroupDeviceListOptions HostGatewayNotEqualTo(string value);
        DeviceGroupDeviceListOptions HostGatewayIn(params string[] value);
        DeviceGroupDeviceListOptions HostGatewayNotIn(params string[] value);
        DeviceGroupDeviceListOptions IdEqualTo(string value);
        DeviceGroupDeviceListOptions IdNotEqualTo(string value);
        DeviceGroupDeviceListOptions IdIn(params string[] value);
        DeviceGroupDeviceListOptions IdNotIn(params string[] value);
        DeviceGroupDeviceListOptions ManifestEqualTo(string value);
        DeviceGroupDeviceListOptions ManifestNotEqualTo(string value);
        DeviceGroupDeviceListOptions ManifestIn(params string[] value);
        DeviceGroupDeviceListOptions ManifestNotIn(params string[] value);
        DeviceGroupDeviceListOptions ManifestTimestampIn(params string[] value);
        DeviceGroupDeviceListOptions ManifestTimestampNotIn(params string[] value);
        DeviceGroupDeviceListOptions ManifestTimestampLessThan(string value);
        DeviceGroupDeviceListOptions ManifestTimestampGreaterThan(string value);
        DeviceGroupDeviceListOptions MechanismEqualTo(string value);
        DeviceGroupDeviceListOptions MechanismNotEqualTo(string value);
        DeviceGroupDeviceListOptions MechanismIn(params string[] value);
        DeviceGroupDeviceListOptions MechanismNotIn(params string[] value);
        DeviceGroupDeviceListOptions MechanismUrlEqualTo(string value);
        DeviceGroupDeviceListOptions MechanismUrlNotEqualTo(string value);
        DeviceGroupDeviceListOptions MechanismUrlIn(params string[] value);
        DeviceGroupDeviceListOptions MechanismUrlNotIn(params string[] value);
        DeviceGroupDeviceListOptions NameEqualTo(string value);
        DeviceGroupDeviceListOptions NameNotEqualTo(string value);
        DeviceGroupDeviceListOptions NameIn(params string[] value);
        DeviceGroupDeviceListOptions NameNotIn(params string[] value);
        DeviceGroupDeviceListOptions SerialNumberEqualTo(string value);
        DeviceGroupDeviceListOptions SerialNumberNotEqualTo(string value);
        DeviceGroupDeviceListOptions SerialNumberIn(params string[] value);
        DeviceGroupDeviceListOptions SerialNumberNotIn(params string[] value);
        DeviceGroupDeviceListOptions StateEqualTo(string value);
        DeviceGroupDeviceListOptions StateNotEqualTo(string value);
        DeviceGroupDeviceListOptions StateIn(params string[] value);
        DeviceGroupDeviceListOptions StateNotIn(params string[] value);
        DeviceGroupDeviceListOptions UpdatedAtIn(params DateTime[] value);
        DeviceGroupDeviceListOptions UpdatedAtNotIn(params DateTime[] value);
        DeviceGroupDeviceListOptions UpdatedAtLessThan(DateTime value);
        DeviceGroupDeviceListOptions UpdatedAtGreaterThan(DateTime value);
        DeviceGroupDeviceListOptions VendorIdEqualTo(string value);
        DeviceGroupDeviceListOptions VendorIdNotEqualTo(string value);
        DeviceGroupDeviceListOptions VendorIdIn(params string[] value);
        DeviceGroupDeviceListOptions VendorIdNotIn(params string[] value);
    }
}