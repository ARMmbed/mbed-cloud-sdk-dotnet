// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="UserRepository.cs" company="Arm">
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
    /// UserRepository
    /// </summary>
    public class UserRepository : Repository, IUserRepository
    {
        public UserRepository()
        {
        }

        public UserRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task<User> Create(User request, string action = null)
        {
            try
            {
                var queryParams = new Dictionary<string, object> { { "action", action }, };
                var bodyParams = new User { Address = request.Address, Email = request.Email, FullName = request.FullName, LoginProfiles = request.LoginProfiles, MarketingAccepted = request.MarketingAccepted, Password = request.Password, PhoneNumber = request.PhoneNumber, TermsAccepted = request.TermsAccepted, Username = request.Username, };
                return await Client.CallApi<User>(path: "/v3/users", queryParams: queryParams, bodyParams: bodyParams, method: HttpMethods.POST, objectToUnpack: request);
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
                var pathParams = new Dictionary<string, object> { { "user_id", id }, };
                await Client.CallApi<User>(path: "/v3/users/{user_id}", pathParams: pathParams, method: HttpMethods.DELETE);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<IUserListOptions, User> List(IUserListOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new UserListOptions();
                }

                Func<IUserListOptions, Task<ResponsePage<User>>> paginatedFunc = async (IUserListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, { "email__eq", _options.Filter.GetEncodedValue("email") }, { "status__eq", _options.Filter.GetEncodedValue("status") }, { "status__in", _options.Filter.GetEncodedValue("status") }, { "status__nin", _options.Filter.GetEncodedValue("status") }, { "login_profile__eq", _options.Filter.GetEncodedValue("loginProfile") }, }; return await Client.CallApi<ResponsePage<User>>(path: "/v3/users", queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<IUserListOptions, User>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<User> Read(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "user_id", id }, };
                return await Client.CallApi<User>(path: "/v3/users/{user_id}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<User> Update(string id, User request)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "user_id", id }, };
                var bodyParams = new User { Address = request.Address, FullName = request.FullName, LoginProfiles = request.LoginProfiles, MarketingAccepted = request.MarketingAccepted, PhoneNumber = request.PhoneNumber, TermsAccepted = request.TermsAccepted, TwoFactorAuthentication = request.TwoFactorAuthentication, Username = request.Username, };
                return await Client.CallApi<User>(path: "/v3/users/{user_id}", pathParams: pathParams, bodyParams: bodyParams, method: HttpMethods.PUT, objectToUnpack: request);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}