// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="DarkThemeColorRepository.cs" company="Arm">
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
    /// DarkThemeColorRepository
    /// </summary>
    public class DarkThemeColorRepository : Repository, IDarkThemeColorRepository
    {
        public DarkThemeColorRepository()
        {
        }

        public DarkThemeColorRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task Delete(string reference)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "reference", reference }, };
                await Client.CallApi<DarkThemeColor>(path: "/v3/branding-colors/dark/{reference}", pathParams: pathParams, method: HttpMethods.DELETE);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<IDarkThemeColorDarkThemeColorListOptions, DarkThemeColor> List(IDarkThemeColorDarkThemeColorListOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new DarkThemeColorDarkThemeColorListOptions();
                }

                Func<IDarkThemeColorDarkThemeColorListOptions, Task<ResponsePage<DarkThemeColor>>> paginatedFunc = async (IDarkThemeColorDarkThemeColorListOptions _options) => { return await Client.CallApi<ResponsePage<DarkThemeColor>>(path: "/v3/branding-colors/dark", method: HttpMethods.GET); };
                return new PaginatedResponse<IDarkThemeColorDarkThemeColorListOptions, DarkThemeColor>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<DarkThemeColor> Read(string reference)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "reference", reference }, };
                return await Client.CallApi<DarkThemeColor>(path: "/v3/branding-colors/dark/{reference}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<DarkThemeColor> Update(string reference, DarkThemeColor request)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "reference", reference }, };
                var bodyParams = new DarkThemeColor { Color = request.Color, UpdatedAt = request.UpdatedAt, };
                return await Client.CallApi<DarkThemeColor>(path: "/v3/branding-colors/dark/{reference}", pathParams: pathParams, bodyParams: bodyParams, objectToUnpack: request, method: HttpMethods.PUT);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}