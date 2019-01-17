// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 1.0.0
//
// <copyright file="UserInvitationRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace MbedCloud.SDK.Entities
{
    using MbedCloud.SDK.Common;
    using MbedCloud.SDK.Entities.ListOptions;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using MbedCloud.SDK.Client;

    /// <summary>
    /// UserInvitationRepository
    /// </summary>
    public class UserInvitationRepository : Repository
    {
        public UserInvitationRepository()
        {
        }

        public UserInvitationRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task<UserInvitation> Create(UserInvitation request, int validForDays = 25)
        {
            try
            {
                var bodyParams = new UserInvitation { Email = request.Email, LoginProfiles = request.LoginProfiles, };
                return await Client.CallApi<UserInvitation>(path: "/v3/user-invitations", bodyParams: bodyParams, method: HttpMethods.POST, objectToUnpack: request);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<UserInvitation> Delete(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "invitation_id", id }, };
                return await Client.CallApi<UserInvitation>(path: "/v3/user-invitations/{invitation_id}", pathParams: pathParams, method: HttpMethods.DELETE);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<UserInvitation> Get(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "invitation_id", id }, };
                return await Client.CallApi<UserInvitation>(path: "/v3/user-invitations/{invitation_id}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<UserInvitationListOptions, UserInvitation> List(UserInvitationListOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new UserInvitationListOptions();
                }

                Func<UserInvitationListOptions, ResponsePage<UserInvitation>> paginatedFunc = (UserInvitationListOptions _options) => AsyncHelper.RunSync<ResponsePage<UserInvitation>>(() => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "limit", _options.Limit }, { "order", _options.Order }, }; return Client.CallApi<ResponsePage<UserInvitation>>(path: "/v3/user-invitations", queryParams: queryParams, method: HttpMethods.GET); });
                return new PaginatedResponse<UserInvitationListOptions, UserInvitation>(paginatedFunc, options);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}