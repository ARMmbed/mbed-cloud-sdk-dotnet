// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="CertificateIssuerConfig.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using System.Collections.Generic;
    using System;

    /// <summary>
    /// CertificateIssuerConfig
    /// </summary>
    public class CertificateIssuerConfig : Entity, ICertificateIssuerConfig
    {
        internal static Dictionary<string, string> Renames = new Dictionary<string, string>() { { "CertificateReference", "reference" }, };

        /// <summary>
        /// certificate_issuer_id
        /// </summary>
        public string CertificateIssuerId
        {
            get;
            set;
        }

        /// <summary>
        /// certificate_reference
        /// </summary>
        public string CertificateReference
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
            private set;
        }

        /// <summary>
        /// updated_at
        /// </summary>
        public DateTime? UpdatedAt
        {
            get;
            private set;
        }
    }
}