// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="ICertificateEnrollment.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Newtonsoft.Json;
    using System;
    using Mbed.Cloud.Foundation.Enums;

    /// <summary>
    /// CertificateEnrollment
    /// </summary>
    public interface ICertificateEnrollment
    {
        /// <summary>
        /// certificate_name
        /// </summary>
        string CertificateName
        {
            get;
        }
        [JsonConverter(typeof(CustomDateConverter), "yyyy-MM-dd'T'HH:mm:ss.fffZ")]
        /// <summary>
        /// created_at
        /// </summary>
        DateTime? CreatedAt
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
        /// enroll_result
        /// </summary>
        CertificateEnrollmentEnrollResult? EnrollResult
        {
            get;
        }

        /// <summary>
        /// enroll_result_detail
        /// </summary>
        string EnrollResultDetail
        {
            get;
        }

        /// <summary>
        /// enroll_status
        /// </summary>
        CertificateEnrollmentEnrollStatus? EnrollStatus
        {
            get;
        }
        [JsonConverter(typeof(CustomDateConverter), "yyyy-MM-dd'T'HH:mm:ss.fffZ")]
        /// <summary>
        /// updated_at
        /// </summary>
        DateTime? UpdatedAt
        {
            get;
        }
    }
}