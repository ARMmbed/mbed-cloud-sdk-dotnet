// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="DeviceEnrollmentDenial.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// DeviceEnrollmentDenial
    /// </summary>
    public class DeviceEnrollmentDenial : Entity, IDeviceEnrollmentDenial
    {
        /// <summary>
        /// account_id
        /// </summary>
        public string AccountId
        {
            get;
            internal set;
        }
        [JsonConverter(typeof(CustomDateConverter), "yyyy-MM-dd'T'HH:mm:ss.fffZ")]
        /// <summary>
        /// created_at
        /// </summary>
        public DateTime? CreatedAt
        {
            get;
            internal set;
        }

        /// <summary>
        /// endpoint_name
        /// </summary>
        public string EndpointName
        {
            get;
            internal set;
        }

        /// <summary>
        /// trusted_certificate_id
        /// </summary>
        public string TrustedCertificateId
        {
            get;
            internal set;
        }
    }
}