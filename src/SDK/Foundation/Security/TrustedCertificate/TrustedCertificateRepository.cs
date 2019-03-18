// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="TrustedCertificateRepository.cs" company="Arm">
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
    /// TrustedCertificateRepository
    /// </summary>
    public class TrustedCertificateRepository : Repository, ITrustedCertificateRepository
    {
        public TrustedCertificateRepository()
        {
        }

        public TrustedCertificateRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task<TrustedCertificate> Create(TrustedCertificate request)
        {
            try
            {
                var bodyParams = new TrustedCertificate { Certificate = request.Certificate, Description = request.Description, EnrollmentMode = request.EnrollmentMode, Name = request.Name, Service = request.Service, Status = request.Status, };
                return await Client.CallApi<TrustedCertificate>(path: "/v3/trusted-certificates", bodyParams: bodyParams, method: HttpMethods.POST, objectToUnpack: request);
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
                var pathParams = new Dictionary<string, object> { { "cert_id", id }, };
                await Client.CallApi<TrustedCertificate>(path: "/v3/trusted-certificates/{cert_id}", pathParams: pathParams, method: HttpMethods.DELETE);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<DeveloperCertificate> GetDeveloperCertificateInfo(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "developerCertificateId", id }, };
                return await Client.CallApi<DeveloperCertificate>(path: "/v3/developer-certificates/{developerCertificateId}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<ITrustedCertificateListOptions, TrustedCertificate> List(ITrustedCertificateListOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new TrustedCertificateListOptions();
                }

                Func<ITrustedCertificateListOptions, Task<ResponsePage<TrustedCertificate>>> paginatedFunc = async (ITrustedCertificateListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, { "name__eq", _options.Filter.GetEncodedValue("name","$eq") }, { "service__eq", _options.Filter.GetEncodedValue("service","$eq") }, { "expire__eq", _options.Filter.GetEncodedValue("expire","$eq") }, { "device_execution_mode__eq", _options.Filter.GetEncodedValue("deviceExecutionMode","$eq") }, { "device_execution_mode__neq", _options.Filter.GetEncodedValue("deviceExecutionMode","$neq") }, { "owner__eq", _options.Filter.GetEncodedValue("owner","$eq") }, { "enrollment_mode__eq", _options.Filter.GetEncodedValue("enrollmentMode","$eq") }, { "status__eq", _options.Filter.GetEncodedValue("status","$eq") }, { "issuer__like", _options.Filter.GetEncodedValue("issuer","$like") }, { "subject__like", _options.Filter.GetEncodedValue("subject","$like") }, { "valid__eq", _options.Filter.GetEncodedValue("valid","$eq") }, }; return await Client.CallApi<ResponsePage<TrustedCertificate>>(path: "/v3/trusted-certificates", queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<ITrustedCertificateListOptions, TrustedCertificate>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<TrustedCertificate> Read(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "cert_id", id }, };
                return await Client.CallApi<TrustedCertificate>(path: "/v3/trusted-certificates/{cert_id}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<TrustedCertificate> Update(string id, TrustedCertificate request)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "cert_id", id }, };
                var bodyParams = new TrustedCertificate { Certificate = request.Certificate, Description = request.Description, EnrollmentMode = request.EnrollmentMode, Name = request.Name, Service = request.Service, Status = request.Status, };
                return await Client.CallApi<TrustedCertificate>(path: "/v3/trusted-certificates/{cert_id}", pathParams: pathParams, bodyParams: bodyParams, method: HttpMethods.PUT, objectToUnpack: request);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}