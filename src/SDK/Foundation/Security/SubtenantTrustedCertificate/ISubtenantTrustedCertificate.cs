// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="ISubtenantTrustedCertificate.cs" company="Arm">
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
    /// SubtenantTrustedCertificate
    /// </summary>
    public interface ISubtenantTrustedCertificate
    {
        /// <summary>
        /// account_id
        /// </summary>
        string AccountId
        {
            get;
            set;
        }

        /// <summary>
        /// certificate
        /// </summary>
        string Certificate
        {
            get;
            set;
        }

        /// <summary>
        /// certificate_fingerprint
        /// </summary>
        string CertificateFingerprint
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
        /// description
        /// </summary>
        string Description
        {
            get;
            set;
        }

        /// <summary>
        /// device_execution_mode
        /// </summary>
        int DeviceExecutionMode
        {
            get;
            set;
        }

        /// <summary>
        /// enrollment_mode
        /// </summary>
        bool? EnrollmentMode
        {
            get;
            set;
        }

        /// <summary>
        /// is_developer_certificate
        /// </summary>
        bool? IsDeveloperCertificate
        {
            get;
            set;
        }

        /// <summary>
        /// issuer
        /// </summary>
        string Issuer
        {
            get;
        }

        /// <summary>
        /// name
        /// </summary>
        string Name
        {
            get;
            set;
        }

        /// <summary>
        /// owner_id
        /// </summary>
        string OwnerId
        {
            get;
        }

        /// <summary>
        /// service
        /// </summary>
        SubtenantTrustedCertificateService? Service
        {
            get;
            set;
        }

        /// <summary>
        /// status
        /// </summary>
        SubtenantTrustedCertificateStatus? Status
        {
            get;
            set;
        }

        /// <summary>
        /// subject
        /// </summary>
        string Subject
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

        /// <summary>
        /// valid
        /// </summary>
        bool? Valid
        {
            get;
        }
        [JsonConverter(typeof(CustomDateConverter), "yyyy-MM-dd'T'HH:mm:ss.fffZ")]
        /// <summary>
        /// validity
        /// </summary>
        DateTime? Validity
        {
            get;
        }
    }
}