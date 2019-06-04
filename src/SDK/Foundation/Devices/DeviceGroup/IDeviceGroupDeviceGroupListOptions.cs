// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="IDeviceGroupDeviceGroupListOptions.cs" company="Arm">
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
    /// DeviceGroupDeviceGroupListOptions
    /// </summary>
    public interface IDeviceGroupDeviceGroupListOptions : IQueryOptions
    {
        /// <summary>
        /// Filter object
        /// </summary>
        Filter Filter
        {
            get;
            set;
        }

        DeviceGroupDeviceGroupListOptions IdEqualTo(string value);
        DeviceGroupDeviceGroupListOptions IdNotEqualTo(string value);
        DeviceGroupDeviceGroupListOptions IdIn(params string[] value);
        DeviceGroupDeviceGroupListOptions IdNotIn(params string[] value);
        DeviceGroupDeviceGroupListOptions DevicesCountEqualTo(int value);
        DeviceGroupDeviceGroupListOptions DevicesCountNotEqualTo(int value);
        DeviceGroupDeviceGroupListOptions DevicesCountIn(params int[] value);
        DeviceGroupDeviceGroupListOptions DevicesCountNotIn(params int[] value);
        DeviceGroupDeviceGroupListOptions DevicesCountLessThan(int value);
        DeviceGroupDeviceGroupListOptions DevicesCountGreaterThan(int value);
        DeviceGroupDeviceGroupListOptions NameEqualTo(string value);
        DeviceGroupDeviceGroupListOptions NameNotEqualTo(string value);
        DeviceGroupDeviceGroupListOptions NameIn(params string[] value);
        DeviceGroupDeviceGroupListOptions NameNotIn(params string[] value);
        DeviceGroupDeviceGroupListOptions CustomAttributesEqualTo(Dictionary<string, string> value);
        DeviceGroupDeviceGroupListOptions CustomAttributesNotEqualTo(Dictionary<string, string> value);
        DeviceGroupDeviceGroupListOptions CreatedAtIn(params DateTime[] value);
        DeviceGroupDeviceGroupListOptions CreatedAtNotIn(params DateTime[] value);
        DeviceGroupDeviceGroupListOptions CreatedAtLessThan(DateTime value);
        DeviceGroupDeviceGroupListOptions CreatedAtGreaterThan(DateTime value);
        DeviceGroupDeviceGroupListOptions UpdatedAtIn(params DateTime[] value);
        DeviceGroupDeviceGroupListOptions UpdatedAtNotIn(params DateTime[] value);
        DeviceGroupDeviceGroupListOptions UpdatedAtLessThan(DateTime value);
        DeviceGroupDeviceGroupListOptions UpdatedAtGreaterThan(DateTime value);
    }
}