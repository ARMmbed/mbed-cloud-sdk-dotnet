// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="ITrustedCertificate.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation.Entities
{
    using Mbed.Cloud.Foundation.Common;
    using System;
    using Mbed.Cloud.Foundation.Enums;

    /// <summary>
    /// TrustedCertificate
    /// </summary>
    public interface ITrustedCertificate
    {
        /// <summary>
        /// account_id
        /// </summary>
        string AccountId
        {
            get;
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
        int? DeviceExecutionMode
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
        TrustedCertificateService? Service
        {
            get;
            set;
        }

        /// <summary>
        /// status
        /// </summary>
        TrustedCertificateStatus? Status
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

        /// <summary>
        /// validity
        /// </summary>
        DateTime? Validity
        {
            get;
        }
    }
}