﻿// <copyright file="AccountManagementApi.ApiKey.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>

namespace MbedCloudSDK.AccountManagement.Api
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using MbedCloudSDK.AccountManagement.Model.ApiKey;
    using MbedCloudSDK.Common;
    using MbedCloudSDK.Common.Query;
    using MbedCloudSDK.Exceptions;

    /// <summary>
    /// Account Management api
    /// </summary>
    public partial class AccountManagementApi
    {
        /// <summary>
        /// Lists API keys.
        /// </summary>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     var options = new QueryOptions
        ///     {
        ///         Limit = 5,
        ///     };
        ///     var keys = accountApi.ListApiKeys(options).Data;
        ///     foreach (var key in keys)
        ///     {
        ///         Console.WriteLine(key);
        ///     }
        ///     return keys;
        /// }
        /// catch (CloudApiException)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        /// <returns>A paginated response containing <see cref="ApiKey"/></returns>
        /// <param name="options"><see cref="QueryOptions"/></param>
        public PaginatedResponse<ApiKey> ListApiKeys(QueryOptions options = null)
        {
            if (options == null)
            {
                options = new QueryOptions();
            }

            try
            {
                return new PaginatedResponse<ApiKey>(ListApiKeysFunc, options);
            }
            catch (CloudApiException)
            {
                throw;
            }
        }

        private ResponsePage<ApiKey> ListApiKeysFunc(QueryOptions options = null)
        {
            if (options == null)
            {
                options = new QueryOptions();
            }

            try
            {
                var resp = developerApi.GetAllApiKeys(limit: options.Limit, after: options.After, order: options.Order, include: options.Include, ownerEq: options.Filter?.FilterString);
                var respKeys = new ResponsePage<ApiKey>(resp.After, resp.HasMore, resp.Limit, resp.Order.ToString(), resp.TotalCount);
                foreach (var key in resp.Data)
                {
                    respKeys.Data.Add(ApiKey.Map(key));
                }

                return respKeys;
            }
            catch (iam.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        /// <summary>
        /// List API keys asynchronously.
        /// </summary>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     var options = new QueryOptions
        ///     {
        ///         Limit = 5,
        ///     };
        ///     var keys = await accountApi.ListApiKeysAsync(options);
        ///     foreach (var key in keys)
        ///     {
        ///         Console.WriteLine(key);
        ///     }
        ///     return keys;
        /// }
        /// catch (CloudApiException)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        /// <returns>A <see cref="Task"/> with List containing <see cref="ApiKey"/></returns>
        /// <param name="options"><see cref="QueryOptions"/></param>
        public async Task<List<ApiKey>> ListApiKeysAsync(QueryOptions options = null)
        {
            if (options == null)
            {
                options = new QueryOptions();
            }

            try
            {
                var apiKeysInfo = await developerApi.GetAllApiKeysAsync(limit: options.Limit, after: options.After, order: options.Order, include: options.Include, ownerEq: options.Filter?.FilterString);
                var apiKeys = new List<ApiKey>();
                foreach (var key in apiKeysInfo.Data)
                {
                    apiKeys.Add(ApiKey.Map(key));
                }

                return apiKeys;
            }
            catch (iam.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        /// <summary>
        /// Get API key details. Returns currently used key for empty argument.
        /// </summary>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     var key = accountApi.GetApiKey();
        ///     return key;
        /// }
        /// catch (CloudApiException)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        /// <param name="apiKeyId"><see cref="ApiKey.Id"/></param>
        /// <returns><see cref="ApiKey"/></returns>
        public ApiKey GetApiKey(string apiKeyId = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(apiKeyId))
                {
                    return ApiKey.Map(developerApi.GetApiKey(apiKeyId));
                }
                else
                {
                    return ApiKey.Map(developerApi.GetMyApiKey());
                }
            }
            catch (iam.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        /// <summary>
        /// Get API key details asynchronously. Returns currently used key for empty argument.
        /// </summary>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     var key = awaut accountApi.GetApiKeyAsync();
        ///     return key;
        /// }
        /// catch (CloudApiException)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        /// <param name="apiKeyId"><see cref="ApiKey.Id"/></param>
        /// <returns><see cref="Task"/> with <see cref="ApiKey"/></returns>
        public async Task<ApiKey> GetApiKeyAsync(string apiKeyId = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(apiKeyId))
                {
                    return ApiKey.Map(await developerApi.GetApiKeyAsync(apiKeyId));
                }
                else
                {
                    return ApiKey.Map(await developerApi.GetMyApiKeyAsync());
                }
            }
            catch (iam.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        /// <summary>
        /// Create new Api key.
        /// </summary>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     var key = new ApiKey
        ///     {
        ///         Name = "example api key",
        ///     };
        ///     var newKey = accountApi.AddApiKey(key);
        ///     return newKey;
        /// }
        /// catch (CloudApiException)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        /// <param name="key"><see cref="ApiKey"/></param>
        /// <returns><see cref="ApiKey"/></returns>
        public ApiKey AddApiKey(ApiKey key)
        {
            try
            {
                var keyBody = key.CreatePostRequest();
                return ApiKey.Map(developerApi.CreateApiKey(keyBody));
            }
            catch (iam.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        /// <summary>
        /// Create new Api key asynchronously.
        /// </summary>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     var key = new ApiKey
        ///     {
        ///         Name = "example api key",
        ///     };
        ///     var newKey = await accountApi.AddApiKeyAsync(key);
        ///     return newKey;
        /// }
        /// catch (CloudApiException)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        /// <param name="key"><see cref="ApiKey"/></param>
        /// <returns><see cref="Task"/> with <see cref="ApiKey"/></returns>
        public async Task<ApiKey> AddApiKeyAsync(ApiKey key)
        {
            try
            {
                var keyBody = key.CreatePostRequest();
                return ApiKey.Map(await developerApi.CreateApiKeyAsync(keyBody));
            }
            catch (iam.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        /// <summary>
        /// Update API key.
        /// </summary>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     var key = accountApi.GetApiKey()
        ///     key.Name = "updated api key";
        ///     var updatedApiKey = accountApi.UpdateApiKey(key.Id, key);
        ///     return updatedApiKey;
        /// }
        /// catch (CloudApiException)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        /// <param name="apiKeyId"><see cref="ApiKey.Id"/></param>
        /// <param name="key"><see cref="ApiKey"/></param>
        /// <returns><see cref="ApiKey"/></returns>
        public ApiKey UpdateApiKey(string apiKeyId, ApiKey key)
        {
            try
            {
                var req = key.CreatePutRequest();
                return ApiKey.Map(developerApi.UpdateApiKey(apiKeyId, req));
            }
            catch (iam.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        /// <summary>
        /// Update API key asynchronously.
        /// </summary>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     var key = await accountApi.GetApiKeyAsync()
        ///     key.Name = "updated api key";
        ///     var updatedApiKey = await accountApi.UpdateApiKeyAsync(key.Id, key);
        ///     return updatedApiKey;
        /// }
        /// catch (CloudApiException)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        /// <param name="apiKeyId"><see cref="ApiKey.Id"/></param>
        /// <param name="key"><see cref="ApiKey"/></param>
        /// <returns><see cref="Task"/> with <see cref="ApiKey"/></returns>
        public async Task<ApiKey> UpdateApiKeyAsync(string apiKeyId, ApiKey key)
        {
            try
            {
                var req = key.CreatePutRequest();
                return ApiKey.Map(await developerApi.UpdateApiKeyAsync(apiKeyId, req));
            }
            catch (iam.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        /// <summary>
        /// Delete API key.
        /// </summary>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     var key = accountApi.GetApiKey()
        ///     accountApi.DeleteApiKey(key.Id);
        /// }
        /// catch (CloudApiException)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        /// <param name="apiKeyId"><see cref="ApiKey.Id"/></param>
        public void DeleteApiKey(string apiKeyId)
        {
            try
            {
                developerApi.DeleteApiKey(apiKeyId);
            }
            catch (iam.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        /// <summary>
        /// Delete API key asynchronously.
        /// </summary>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     var key = accountApi.GetApiKey()
        ///     await accountApi.DeleteApiKeyAsync(key.Id);
        /// }
        /// catch (CloudApiException)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        /// <param name="apiKeyId"><see cref="ApiKey.Id"/></param>
        /// <returns><see cref="Task"/> with <see cref="ApiKey"/></returns>
        public async Task DeleteApiKeyAsync(string apiKeyId)
        {
            try
            {
                await developerApi.DeleteApiKeyAsync(apiKeyId);
            }
            catch (iam.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}