// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="ICertificateIssuer.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using System;
    using System.Collections.Generic;
    using Mbed.Cloud.Foundation.Enums;

    /// <summary>
    /// CertificateIssuer
    /// </summary>
    public interface ICertificateIssuer
    {
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
        /// issuer_attributes
        /// </summary>
        Dictionary<string, string> IssuerAttributes
        {
            get;
            set;
        }

        /// <summary>
        /// issuer_type
        /// </summary>
        CertificateIssuerType? IssuerType
        {
            get;
            set;
        }

        /// <summary>
        /// name
        /// </summary>
        string Name
        {
            get;
            set;
        }
    }
}