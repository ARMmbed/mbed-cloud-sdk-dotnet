// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="CertificateIssuerConfigRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation.Entities
{
    using Mbed.Cloud.Foundation.Common;
    using Mbed.Cloud.Foundation.ListOptions;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.Foundation.RestClient;

    /// <summary>
    /// CertificateIssuerConfigRepository
    /// </summary>
    public class CertificateIssuerConfigRepository : Repository
    {
        public CertificateIssuerConfigRepository()
        {
        }

        public CertificateIssuerConfigRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task<CertificateIssuerConfig> Create(CertificateIssuerConfig request)
        {
            try
            {
                var bodyParams = new CertificateIssuerConfig { CertificateIssuerId = request.CertificateIssuerId, CertificateReference = request.CertificateReference, };
                return await Client.CallApi<CertificateIssuerConfig>(path: "/v3/certificate-issuer-configurations", bodyParams: bodyParams, method: HttpMethods.POST, objectToUnpack: request);
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
                var pathParams = new Dictionary<string, object> { { "certificate-issuer-configuration-id", id }, };
                await Client.CallApi<CertificateIssuerConfig>(path: "/v3/certificate-issuer-configurations/{certificate-issuer-configuration-id}", pathParams: pathParams, method: HttpMethods.DELETE);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<CertificateIssuerConfig> Get(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "certificate-issuer-configuration-id", id }, };
                return await Client.CallApi<CertificateIssuerConfig>(path: "/v3/certificate-issuer-configurations/{certificate-issuer-configuration-id}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<CertificateIssuerConfig> GetDefault()
        {
            try
            {
                return await Client.CallApi<CertificateIssuerConfig>(path: "/v3/certificate-issuer-configurations/lwm2m", method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<CertificateIssuerConfigListOptions, CertificateIssuerConfig> List(CertificateIssuerConfigListOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new CertificateIssuerConfigListOptions();
                }

                Func<CertificateIssuerConfigListOptions, Task<ResponsePage<CertificateIssuerConfig>>> paginatedFunc = async (CertificateIssuerConfigListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, }; return await Client.CallApi<ResponsePage<CertificateIssuerConfig>>(path: "/v3/certificate-issuer-configurations", queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<CertificateIssuerConfigListOptions, CertificateIssuerConfig>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<CertificateIssuerConfig> Update(string id, CertificateIssuerConfig request)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "certificate-issuer-configuration-id", id }, };
                var bodyParams = new CertificateIssuerConfig { CertificateIssuerId = request.CertificateIssuerId, };
                return await Client.CallApi<CertificateIssuerConfig>(path: "/v3/certificate-issuer-configurations/{certificate-issuer-configuration-id}", pathParams: pathParams, bodyParams: bodyParams, method: HttpMethods.PUT, objectToUnpack: request);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}