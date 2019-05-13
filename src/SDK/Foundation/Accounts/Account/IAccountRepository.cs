// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="IAccountRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Foundation;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.RestClient;

    /// <summary>
    /// AccountRepository
    /// </summary>
    public interface IAccountRepository
    {
        PaginatedResponse<ISubtenantApiKeyListOptions, SubtenantApiKey> ApiKeys(string id, ISubtenantApiKeyListOptions options = null);
        Task<Account> Create(Account request, string action = null);
        PaginatedResponse<IAccountListOptions, Account> List(IAccountListOptions options = null);
        Task<Account> Me(string include = null, string properties = null);
        Task<Account> Read(string id, string include = null, string properties = null);
        PaginatedResponse<ISubtenantTrustedCertificateListOptions, SubtenantTrustedCertificate> TrustedCertificates(string id, ISubtenantTrustedCertificateListOptions options = null);
        Task<Account> Update(string id, Account request);
        PaginatedResponse<ISubtenantUserInvitationListOptions, SubtenantUserInvitation> UserInvitations(string id, ISubtenantUserInvitationListOptions options = null);
        PaginatedResponse<ISubtenantUserListOptions, SubtenantUser> Users(string id, ISubtenantUserListOptions options = null);
    }
}