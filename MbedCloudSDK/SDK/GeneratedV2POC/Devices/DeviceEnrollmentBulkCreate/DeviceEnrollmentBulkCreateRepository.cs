// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 1.0.0
//
// <copyright file="DeviceEnrollmentBulkCreateRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace MbedCloud.SDK.Entities
{
    using MbedCloud.SDK.Common;
    using System.IO;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using MbedCloud.SDK.Client;

    /// <summary>
    /// DeviceEnrollmentBulkCreateRepository
    /// </summary>
    public class DeviceEnrollmentBulkCreateRepository : Repository
    {
        public DeviceEnrollmentBulkCreateRepository()
        {
        }

        public DeviceEnrollmentBulkCreateRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task<DeviceEnrollmentBulkCreate> Create(Stream enrollmentIdentities)
        {
            try
            {
                var fileParams = new Dictionary<string, Stream> { { "enrollment_identities", enrollmentIdentities }, };
                return await Client.CallApi<DeviceEnrollmentBulkCreate>(path: "/v3/device-enrollments-bulk-uploads", fileParams: fileParams, method: HttpMethods.POST);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<Stream> DownloadErrorsReportFile(DeviceEnrollmentBulkCreate model)
        {
            return await CustomFunctions.DownloadErrorsReportFile(this, model);
        }

        public async Task<Stream> DownloadFullReportFile(DeviceEnrollmentBulkCreate model)
        {
            return await CustomFunctions.DownloadFullReportFile(this, model);
        }

        public async Task<DeviceEnrollmentBulkCreate> Get(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "id", id }, };
                return await Client.CallApi<DeviceEnrollmentBulkCreate>(path: "/v3/device-enrollments-bulk-uploads/{id}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}