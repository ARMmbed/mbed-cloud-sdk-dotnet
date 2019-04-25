// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="CampaignDeviceMetadata.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.Foundation.Enums;

    /// <summary>
    /// CampaignDeviceMetadata
    /// </summary>
    public class CampaignDeviceMetadata : Entity, ICampaignDeviceMetadata
    {
        internal static Dictionary<string, string> Renames = new Dictionary<string, string>() { { "CampaignId", "campaign" }, };

        /// <summary>
        /// campaign_id
        /// </summary>
        public string CampaignId
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
        /// deployment_state
        /// </summary>
        public CampaignDeviceMetadataDeploymentState? DeploymentState
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
            internal set;
        }

        /// <summary>
        /// device_id
        /// </summary>
        public string DeviceId
        {
            get;
            internal set;
        }

        /// <summary>
        /// mechanism
        /// </summary>
        public string Mechanism
        {
            get;
            internal set;
        }

        /// <summary>
        /// mechanism_url
        /// </summary>
        public string MechanismUrl
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
    }
}