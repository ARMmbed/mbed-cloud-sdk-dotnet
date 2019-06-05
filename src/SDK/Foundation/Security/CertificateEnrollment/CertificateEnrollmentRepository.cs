// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="CertificateEnrollmentRepository.cs" company="Arm">
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
    /// CertificateEnrollmentRepository
    /// </summary>
    public class CertificateEnrollmentRepository : Repository, ICertificateEnrollmentRepository
    {
        public CertificateEnrollmentRepository()
        {
        }

        public CertificateEnrollmentRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public PaginatedResponse<ICertificateEnrollmentCertificateEnrollmentListOptions, CertificateEnrollment> List(ICertificateEnrollmentCertificateEnrollmentListOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new CertificateEnrollmentCertificateEnrollmentListOptions();
                }

                Func<ICertificateEnrollmentCertificateEnrollmentListOptions, Task<ResponsePage<CertificateEnrollment>>> paginatedFunc = async (ICertificateEnrollmentCertificateEnrollmentListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, { "device_id__eq", _options.Filter.GetEncodedValue("device_id", "$eq") }, { "certificate_name__eq", _options.Filter.GetEncodedValue("certificate_name", "$eq") }, { "enroll_status__neq", _options.Filter.GetEncodedValue("enroll_status", "$neq") }, { "enroll_status__eq", _options.Filter.GetEncodedValue("enroll_status", "$eq") }, { "enroll_result__neq", _options.Filter.GetEncodedValue("enroll_result", "$neq") }, { "enroll_result__eq", _options.Filter.GetEncodedValue("enroll_result", "$eq") }, { "created_at__lte", _options.Filter.GetEncodedValue("created_at", "$lte") }, { "created_at__gte", _options.Filter.GetEncodedValue("created_at", "$gte") }, { "updated_at__lte", _options.Filter.GetEncodedValue("updated_at", "$lte") }, { "updated_at__gte", _options.Filter.GetEncodedValue("updated_at", "$gte") }, }; return await Client.CallApi<ResponsePage<CertificateEnrollment>>(path: "/v3/certificate-enrollments", queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<ICertificateEnrollmentCertificateEnrollmentListOptions, CertificateEnrollment>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<CertificateEnrollment> Read(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "certificate-enrollment-id", id }, };
                return await Client.CallApi<CertificateEnrollment>(path: "/v3/certificate-enrollments/{certificate-enrollment-id}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}