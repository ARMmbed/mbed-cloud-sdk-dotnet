// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="ICertificateIssuerConfigRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.RestClient;

    /// <summary>
    /// CertificateIssuerConfigRepository
    /// </summary>
    public interface ICertificateIssuerConfigRepository
    {
        Task<CertificateIssuerConfig> Create(CertificateIssuerConfig request);
        Task Delete(string id);
        Task<CertificateIssuerConfig> GetDefault();
        PaginatedResponse<ICertificateIssuerConfigListOptions, CertificateIssuerConfig> List(ICertificateIssuerConfigListOptions options = null);
        Task<CertificateIssuerConfig> Read(string id);
        Task<CertificateIssuerConfig> Update(string id, CertificateIssuerConfig request);
    }
}