// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="IDeviceEvents.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation.Entities
{
    using Mbed.Cloud.Foundation.Common;
    using System.Collections.Generic;
    using System;

    /// <summary>
    /// DeviceEvents
    /// </summary>
    public interface IDeviceEvents
    {
        /// <summary>
        /// changes
        /// </summary>
        Dictionary<string, string> Changes
        {
            get;
        }

        /// <summary>
        /// created_at
        /// </summary>
        DateTime? CreatedAt
        {
            get;
        }

        /// <summary>
        /// data
        /// </summary>
        Dictionary<string, string> Data
        {
            get;
        }

        /// <summary>
        /// date_time
        /// </summary>
        DateTime? DateTime
        {
            get;
        }

        /// <summary>
        /// description
        /// </summary>
        string Description
        {
            get;
        }

        /// <summary>
        /// device_id
        /// </summary>
        string DeviceId
        {
            get;
        }

        /// <summary>
        /// event_type
        /// </summary>
        string EventType
        {
            get;
        }

        /// <summary>
        /// event_type_category
        /// </summary>
        string EventTypeCategory
        {
            get;
        }

        /// <summary>
        /// event_type_description
        /// </summary>
        string EventTypeDescription
        {
            get;
        }

        /// <summary>
        /// state_change
        /// </summary>
        bool? StateChange
        {
            get;
        }
    }
}