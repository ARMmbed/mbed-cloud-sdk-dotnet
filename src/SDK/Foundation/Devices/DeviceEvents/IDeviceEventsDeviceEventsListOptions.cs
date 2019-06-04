// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="IDeviceEventsDeviceEventsListOptions.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Common.Filters;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// DeviceEventsDeviceEventsListOptions
    /// </summary>
    public interface IDeviceEventsDeviceEventsListOptions : IQueryOptions
    {
        /// <summary>
        /// Filter object
        /// </summary>
        Filter Filter
        {
            get;
            set;
        }

        DeviceEventsDeviceEventsListOptions DateTimeIn(params DateTime[] value);
        DeviceEventsDeviceEventsListOptions DateTimeNotIn(params DateTime[] value);
        DeviceEventsDeviceEventsListOptions DateTimeLessThan(DateTime value);
        DeviceEventsDeviceEventsListOptions DateTimeGreaterThan(DateTime value);
        DeviceEventsDeviceEventsListOptions DescriptionEqualTo(string value);
        DeviceEventsDeviceEventsListOptions DescriptionNotEqualTo(string value);
        DeviceEventsDeviceEventsListOptions DescriptionIn(params string[] value);
        DeviceEventsDeviceEventsListOptions DescriptionNotIn(params string[] value);
        DeviceEventsDeviceEventsListOptions IdEqualTo(string value);
        DeviceEventsDeviceEventsListOptions IdNotEqualTo(string value);
        DeviceEventsDeviceEventsListOptions IdIn(params string[] value);
        DeviceEventsDeviceEventsListOptions IdNotIn(params string[] value);
        DeviceEventsDeviceEventsListOptions DeviceIdEqualTo(string value);
        DeviceEventsDeviceEventsListOptions DeviceIdNotEqualTo(string value);
        DeviceEventsDeviceEventsListOptions DeviceIdIn(params string[] value);
        DeviceEventsDeviceEventsListOptions DeviceIdNotIn(params string[] value);
        DeviceEventsDeviceEventsListOptions EventTypeEqualTo(string value);
        DeviceEventsDeviceEventsListOptions EventTypeNotEqualTo(string value);
        DeviceEventsDeviceEventsListOptions EventTypeIn(params string[] value);
        DeviceEventsDeviceEventsListOptions EventTypeNotIn(params string[] value);
        DeviceEventsDeviceEventsListOptions StateChangeEqualTo(bool value);
        DeviceEventsDeviceEventsListOptions StateChangeNotEqualTo(bool value);
    }
}