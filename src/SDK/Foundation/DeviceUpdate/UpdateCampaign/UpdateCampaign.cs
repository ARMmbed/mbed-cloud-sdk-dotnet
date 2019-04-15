// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="UpdateCampaign.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Foundation.Enums;
    using System;
    using Newtonsoft.Json;
    using Mbed.Cloud.Common.Filters;

    /// <summary>
    /// UpdateCampaign
    /// </summary>
    public class UpdateCampaign : Entity, IUpdateCampaign
    {
        /// <summary>
        /// autostop_reason
        /// </summary>
        public string AutostopReason
        {
            get;
            internal set;
        }

        /// <summary>
        /// campaign_strategy
        /// </summary>
        public UpdateCampaignStrategy? CampaignStrategy
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
            internal set;
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
        /// device_filter
        /// </summary>
        public string DeviceFilter
        {
            get;
            set;
        }

        [JsonIgnore]
        /// <summary>
        /// device_filter_helper
        /// </summary>
        public Filter DeviceFilterHelper
        {
            get
            {
                return CustomFunctions.DeviceFilterHelperGetter(this);
            }

            set
            {
                CustomFunctions.DeviceFilterHelperSetter(this, value);
            }
        }

        /// <summary>
        /// finished
        /// </summary>
        public DateTime? Finished
        {
            get;
            internal set;
        }

        /// <summary>
        /// name
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// phase
        /// </summary>
        public string Phase
        {
            get;
            internal set;
        }

        /// <summary>
        /// root_manifest_id
        /// </summary>
        public string RootManifestId
        {
            get;
            set;
        }

        /// <summary>
        /// root_manifest_url
        /// </summary>
        public string RootManifestUrl
        {
            get;
            internal set;
        }

        /// <summary>
        /// started_at
        /// </summary>
        public DateTime? StartedAt
        {
            get;
            internal set;
        }

        /// <summary>
        /// updated_at
        /// </summary>
        public DateTime? UpdatedAt
        {
            get;
            internal set;
        }

        /// <summary>
        /// when
        /// </summary>
        public DateTime? When
        {
            get;
            set;
        }
    }
}