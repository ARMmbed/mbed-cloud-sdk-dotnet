// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="ISubtenantTrustedCertificateRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation.Entities
{
    using Mbed.Cloud.Foundation.Common;
    using Mbed.Cloud.Foundation.Entities;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.Foundation.RestClient;

    /// <summary>
    /// SubtenantTrustedCertificateRepository
    /// </summary>
    public interface ISubtenantTrustedCertificateRepository
    {
        Task<SubtenantTrustedCertificate> Create(string accountId, SubtenantTrustedCertificate request);
        Task Delete(string accountId, string id);
        Task<SubtenantTrustedCertificate> Get(string accountId, string id);
        Task<DeveloperCertificate> GetDeveloperCertificateInfo(string id);
        Task<SubtenantTrustedCertificate> Update(string accountId, string id, SubtenantTrustedCertificate request);
    }
}