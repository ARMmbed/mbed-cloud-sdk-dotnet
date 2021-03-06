// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="IDeviceEnrollmentDenialListOptions.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Common.Filters;

    /// <summary>
    /// DeviceEnrollmentDenialListOptions
    /// </summary>
    public interface IDeviceEnrollmentDenialListOptions : IQueryOptions
    {
        /// <summary>
        /// Filter object
        /// </summary>
        Filter Filter
        {
            get;
            set;
        }

        DeviceEnrollmentDenialListOptions TrustedCertificateIdEqualTo(string value);
        DeviceEnrollmentDenialListOptions EndpointNameEqualTo(string value);
    }
}