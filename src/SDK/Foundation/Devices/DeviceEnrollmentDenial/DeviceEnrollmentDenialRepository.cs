// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="DeviceEnrollmentDenialRepository.cs" company="Arm">
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
    /// DeviceEnrollmentDenialRepository
    /// </summary>
    public class DeviceEnrollmentDenialRepository : Repository, IDeviceEnrollmentDenialRepository
    {
        public DeviceEnrollmentDenialRepository()
        {
        }

        public DeviceEnrollmentDenialRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public PaginatedResponse<IDeviceEnrollmentDenialListOptions, DeviceEnrollmentDenial> List(IDeviceEnrollmentDenialListOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new DeviceEnrollmentDenialListOptions();
                }

                Func<IDeviceEnrollmentDenialListOptions, Task<ResponsePage<DeviceEnrollmentDenial>>> paginatedFunc = async (IDeviceEnrollmentDenialListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "limit", _options.Limit }, { "order", _options.Order }, { "trusted_certificate_id__eq", _options.Filter.GetEncodedValue("trusted_certificate_id", "$eq") }, { "endpoint_name__eq", _options.Filter.GetEncodedValue("endpoint_name", "$eq") }, }; return await Client.CallApi<ResponsePage<DeviceEnrollmentDenial>>(path: "/v3/device-enrollment-denials", queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<IDeviceEnrollmentDenialListOptions, DeviceEnrollmentDenial>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<DeviceEnrollmentDenial> Read(string deviceEnrollmentDenialId)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "device_enrollment_denial_id", deviceEnrollmentDenialId }, };
                return await Client.CallApi<DeviceEnrollmentDenial>(path: "/v3/device-enrollment-denials/{device_enrollment_denial_id}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}