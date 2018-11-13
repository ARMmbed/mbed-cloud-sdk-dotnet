// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 1.0.0
//
// <copyright file="DeviceEvents.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace MbedCloud.SDK.Entities
{
    using MbedCloud.SDK.Common;
    using MbedCloud.SDK.Client;
    using System;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;

    /// <summary>
    /// DeviceEvents
    /// </summary>
    public class DeviceEvents : BaseEntity
    {
        public DeviceEvents()
        {
        }

        public DeviceEvents(Config config) : base(config)
        {
        }

        /// <summary>
        /// changes
        /// </summary>
        public Dictionary<string, string> Changes
        {
            get;
            set;
        }

        /// <summary>
        /// created_at
        /// </summary>
        public DateTime? CreatedAt
        {
            get;
            set;
        }

        /// <summary>
        /// data
        /// </summary>
        public object Data
        {
            get;
            set;
        }

        /// <summary>
        /// date_time
        /// </summary>
        public DateTime? DateTime
        {
            get;
            set;
        }

        /// <summary>
        /// description
        /// </summary>
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// device_id
        /// </summary>
        public string DeviceId
        {
            get;
            set;
        }

        /// <summary>
        /// event_type
        /// </summary>
        public string EventType
        {
            get;
            set;
        }

        /// <summary>
        /// event_type_category
        /// </summary>
        public string EventTypeCategory
        {
            get;
            set;
        }

        /// <summary>
        /// event_type_description
        /// </summary>
        public string EventTypeDescription
        {
            get;
            set;
        }

        /// <summary>
        /// state_change
        /// </summary>
        public bool? StateChange
        {
            get;
            set;
        }

        public async Task<DeviceEvents> Get()
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "device_event_id", Id }, };
                return await Client.CallApi<DeviceEvents>(path: "/v3/device-events/{device_event_id}/", pathParams: pathParams, method: HttpMethods.GET, objectToUnpack: this);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<QueryOptions, DeviceEvents> List(QueryOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new QueryOptions();
                }

                Func<QueryOptions, ResponsePage<DeviceEvents>> paginatedFunc = (QueryOptions _options) => AsyncHelper.RunSync<ResponsePage<DeviceEvents>>(() => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, }; return Client.CallApi<ResponsePage<DeviceEvents>>(path: "/v3/device-events/", queryParams: queryParams, method: HttpMethods.GET); });
                return new PaginatedResponse<QueryOptions, DeviceEvents>(paginatedFunc, options);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}