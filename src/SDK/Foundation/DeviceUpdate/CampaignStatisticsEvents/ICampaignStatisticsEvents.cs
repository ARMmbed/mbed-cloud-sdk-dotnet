// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="ICampaignStatisticsEvents.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// CampaignStatisticsEvents
    /// </summary>
    public interface ICampaignStatisticsEvents
    {
        /// <summary>
        /// campaign_id
        /// </summary>
        string CampaignId
        {
            get;
            set;
        }

        /// <summary>
        /// count
        /// </summary>
        int? Count
        {
            get;
        }
        [JsonConverter(typeof(CustomDateConverter), "yyyy-MM-dd'T'HH:mm:ss.fffZ")]
        /// <summary>
        /// created_at
        /// </summary>
        DateTime? CreatedAt
        {
            get;
        }

        /// <summary>
        /// description
        /// </summary>
        string Description
        {
            get;
        }

        /// <summary>
        /// event_type
        /// </summary>
        string EventType
        {
            get;
        }

        /// <summary>
        /// summary_status
        /// </summary>
        string SummaryStatus
        {
            get;
        }

        /// <summary>
        /// summary_status_id
        /// </summary>
        string SummaryStatusId
        {
            get;
            set;
        }
    }
}