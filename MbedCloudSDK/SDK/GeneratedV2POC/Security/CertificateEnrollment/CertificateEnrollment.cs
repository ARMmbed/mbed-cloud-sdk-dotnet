// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 1.0.0
//
// <copyright file="CertificateEnrollment.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace MbedCloud.SDK.Entities
{
    using MbedCloud.SDK.Common;
    using System;
    using MbedCloud.SDK.Enums;

    /// <summary>
    /// CertificateEnrollment
    /// </summary>
    public class CertificateEnrollment : Entity
    {
        /// <summary>
        /// certificate_name
        /// </summary>
        public string CertificateName
        {
            get;
            set;
        }

        /// <summary>
        /// created_at
        /// </summary>
        public DateTime? CreatedAt
        {
            get;
            set;
        }

        /// <summary>
        /// device_id
        /// </summary>
        public string DeviceId
        {
            get;
            set;
        }

        /// <summary>
        /// enroll_result
        /// </summary>
        public CertificateEnrollmentEnrollResultEnum? EnrollResult
        {
            get;
            set;
        }

        /// <summary>
        /// enroll_status
        /// </summary>
        public CertificateEnrollmentEnrollStatusEnum? EnrollStatus
        {
            get;
            set;
        }

        /// <summary>
        /// updated_at
        /// </summary>
        public DateTime? UpdatedAt
        {
            get;
            set;
        }
    }
}