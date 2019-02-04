// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="SubtenantUserInvitationRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation.Entities
{
    using Mbed.Cloud.Foundation.Common;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.Foundation.RestClient;

    /// <summary>
    /// SubtenantUserInvitationRepository
    /// </summary>
    public class SubtenantUserInvitationRepository : Repository
    {
        public SubtenantUserInvitationRepository()
        {
        }

        public SubtenantUserInvitationRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task<SubtenantUserInvitation> Create(string accountId, SubtenantUserInvitation request, int validForDays = 25)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", accountId }, };
                var bodyParams = new SubtenantUserInvitation { Email = request.Email, LoginProfiles = request.LoginProfiles, };
                return await Client.CallApi<SubtenantUserInvitation>(path: "/v3/accounts/{account_id}/user-invitations", pathParams: pathParams, bodyParams: bodyParams, method: HttpMethods.POST, objectToUnpack: request);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task Delete(string accountId, string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", accountId }, { "invitation_id", id }, };
                await Client.CallApi<SubtenantUserInvitation>(path: "/v3/accounts/{account_id}/user-invitations/{invitation_id}", pathParams: pathParams, method: HttpMethods.DELETE);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<SubtenantUserInvitation> Get(string accountId, string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", accountId }, { "invitation_id", id }, };
                return await Client.CallApi<SubtenantUserInvitation>(path: "/v3/accounts/{account_id}/user-invitations/{invitation_id}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}