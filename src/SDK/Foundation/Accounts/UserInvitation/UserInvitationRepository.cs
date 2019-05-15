// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="UserInvitationRepository.cs" company="Arm">
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
    /// UserInvitationRepository
    /// </summary>
    public class UserInvitationRepository : Repository, IUserInvitationRepository
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
                var externalBodyParams = new
                {
                    validForDays = validForDays,
                };
                return await Client.CallApi<UserInvitation>(path: "/v3/user-invitations", bodyParams: bodyParams, externalBodyParams: externalBodyParams, objectToUnpack: request, method: HttpMethods.POST);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task Delete(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "invitation_id", id }, };
                await Client.CallApi<UserInvitation>(path: "/v3/user-invitations/{invitation_id}", pathParams: pathParams, method: HttpMethods.DELETE);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<IUserInvitationListOptions, UserInvitation> List(IUserInvitationListOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new UserInvitationListOptions();
                }

                Func<IUserInvitationListOptions, Task<ResponsePage<UserInvitation>>> paginatedFunc = async (IUserInvitationListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "limit", _options.Limit }, { "order", _options.Order }, { "login_profiles__eq", _options.Filter.GetEncodedValue("login_profiles", "$eq") }, }; return await Client.CallApi<ResponsePage<UserInvitation>>(path: "/v3/user-invitations", queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<IUserInvitationListOptions, UserInvitation>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<UserInvitation> Read(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "invitation_id", id }, };
                return await Client.CallApi<UserInvitation>(path: "/v3/user-invitations/{invitation_id}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}