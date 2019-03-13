// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="DeviceEnrollmentBulkDeleteRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using System.IO;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.RestClient;

    /// <summary>
    /// DeviceEnrollmentBulkDeleteRepository
    /// </summary>
    public class DeviceEnrollmentBulkDeleteRepository : Repository, IDeviceEnrollmentBulkDeleteRepository
    {
        public DeviceEnrollmentBulkDeleteRepository()
        {
        }

        public DeviceEnrollmentBulkDeleteRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task<DeviceEnrollmentBulkDelete> Delete(Stream enrollmentIdentities)
        {
            try
            {
                var fileParams = new Dictionary<string, Stream> { { "enrollment_identities", enrollmentIdentities }, };
                return await Client.CallApi<DeviceEnrollmentBulkDelete>(path: "/v3/device-enrollments-bulk-deletes", fileParams: fileParams, method: HttpMethods.POST);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<Stream> DownloadErrorsReportFile(DeviceEnrollmentBulkDelete model)
        {
            return await CustomFunctions.DownloadErrorsReportFile(this, model);
        }

        public async Task<Stream> DownloadFullReportFile(DeviceEnrollmentBulkDelete model)
        {
            return await CustomFunctions.DownloadFullReportFile(this, model);
        }

        public async Task<DeviceEnrollmentBulkDelete> Read(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "id", id }, };
                return await Client.CallApi<DeviceEnrollmentBulkDelete>(path: "/v3/device-enrollments-bulk-deletes/{id}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}