// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="CertificateIssuerRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Foundation;
    using Mbed.Cloud.Foundation;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.RestClient;

    /// <summary>
    /// CertificateIssuerRepository
    /// </summary>
    public class CertificateIssuerRepository : Repository, ICertificateIssuerRepository
    {
        public CertificateIssuerRepository()
        {
        }

        public CertificateIssuerRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task<CertificateIssuer> Create(CertificateIssuer request, Dictionary<string, string> issuerCredentials = null)
        {
            try
            {
                var bodyParams = new CertificateIssuer { Description = request.Description, IssuerAttributes = request.IssuerAttributes, IssuerType = request.IssuerType, Name = request.Name, };
                return await Client.CallApi<CertificateIssuer>(path: "/v3/certificate-issuers", bodyParams: bodyParams, method: HttpMethods.POST, objectToUnpack: request);
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
                var pathParams = new Dictionary<string, object> { { "certificate-issuer-id", id }, };
                await Client.CallApi<CertificateIssuer>(path: "/v3/certificate-issuers/{certificate-issuer-id}", pathParams: pathParams, method: HttpMethods.DELETE);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<CertificateIssuer> Get(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "certificate-issuer-id", id }, };
                return await Client.CallApi<CertificateIssuer>(path: "/v3/certificate-issuers/{certificate-issuer-id}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<ICertificateIssuerListOptions, CertificateIssuer> List(ICertificateIssuerListOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new CertificateIssuerListOptions();
                }

                Func<ICertificateIssuerListOptions, Task<ResponsePage<CertificateIssuer>>> paginatedFunc = async (ICertificateIssuerListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, }; return await Client.CallApi<ResponsePage<CertificateIssuer>>(path: "/v3/certificate-issuers", queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<ICertificateIssuerListOptions, CertificateIssuer>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<CertificateIssuer> Update(string id, CertificateIssuer request, Dictionary<string, string> issuerCredentials = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "certificate-issuer-id", id }, };
                var bodyParams = new CertificateIssuer { Description = request.Description, IssuerAttributes = request.IssuerAttributes, Name = request.Name, };
                return await Client.CallApi<CertificateIssuer>(path: "/v3/certificate-issuers/{certificate-issuer-id}", pathParams: pathParams, bodyParams: bodyParams, method: HttpMethods.PUT, objectToUnpack: request);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<VerificationResponse> Verify(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "certificate-issuer-id", id }, };
                return await Client.CallApi<VerificationResponse>(path: "/v3/certificate-issuers/{certificate-issuer-id}/verify", pathParams: pathParams, method: HttpMethods.POST);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}