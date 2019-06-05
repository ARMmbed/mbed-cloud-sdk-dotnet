// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="ApiKeyRepository.cs" company="Arm">
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
    /// ApiKeyRepository
    /// </summary>
    public class ApiKeyRepository : Repository, IApiKeyRepository
    {
        public ApiKeyRepository()
        {
        }

        public ApiKeyRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task<ApiKey> Create(ApiKey request)
        {
            try
            {
                var bodyParams = new ApiKey { Name = request.Name, Owner = request.Owner, Status = request.Status, };
                return await Client.CallApi<ApiKey>(path: "/v3/api-keys", bodyParams: bodyParams, objectToUnpack: request, method: HttpMethods.POST);
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
                var pathParams = new Dictionary<string, object> { { "apikey_id", id }, };
                await Client.CallApi<ApiKey>(path: "/v3/api-keys/{apikey_id}", pathParams: pathParams, method: HttpMethods.DELETE);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<IApiKeyApiKeyListOptions, ApiKey> List(IApiKeyApiKeyListOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new ApiKeyApiKeyListOptions();
                }

                Func<IApiKeyApiKeyListOptions, Task<ResponsePage<ApiKey>>> paginatedFunc = async (IApiKeyApiKeyListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, { "key__eq", _options.Filter.GetEncodedValue("key", "$eq") }, { "owner__eq", _options.Filter.GetEncodedValue("owner", "$eq") }, }; return await Client.CallApi<ResponsePage<ApiKey>>(path: "/v3/api-keys", queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<IApiKeyApiKeyListOptions, ApiKey>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<ApiKey> Me()
        {
            try
            {
                return await Client.CallApi<ApiKey>(path: "/v3/api-keys/me", method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<ApiKey> Read(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "apikey_id", id }, };
                return await Client.CallApi<ApiKey>(path: "/v3/api-keys/{apikey_id}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<ApiKey> Update(string id, ApiKey request)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "apikey_id", id }, };
                var bodyParams = new ApiKey { Name = request.Name, Owner = request.Owner, Status = request.Status, };
                return await Client.CallApi<ApiKey>(path: "/v3/api-keys/{apikey_id}", pathParams: pathParams, bodyParams: bodyParams, objectToUnpack: request, method: HttpMethods.PUT);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}