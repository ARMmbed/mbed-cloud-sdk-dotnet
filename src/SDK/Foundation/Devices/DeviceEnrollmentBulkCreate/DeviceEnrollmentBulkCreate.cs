// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="DeviceEnrollmentBulkCreate.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Newtonsoft.Json;
    using System;
    using Mbed.Cloud.Foundation.Enums;

    /// <summary>
    /// DeviceEnrollmentBulkCreate
    /// </summary>
    public class DeviceEnrollmentBulkCreate : Entity, IDeviceEnrollmentBulkCreate
    {
        /// <summary>
        /// account_id
        /// </summary>
        public string AccountId
        {
            get;
            internal set;
        }
        [JsonConverter(typeof(CustomDateConverter), "yyyy-MM-dd'T'HH:mm:ss.fffZ")]
        /// <summary>
        /// completed_at
        /// </summary>
        public DateTime? CompletedAt
        {
            get;
            internal set;
        }
        [JsonConverter(typeof(CustomDateConverter), "yyyy-MM-dd'T'HH:mm:ss.fffZ")]
        /// <summary>
        /// created_at
        /// </summary>
        public DateTime? CreatedAt
        {
            get;
            internal set;
        }

        /// <summary>
        /// errors_count
        /// </summary>
        public int? ErrorsCount
        {
            get;
            internal set;
        }

        /// <summary>
        /// errors_report_file
        /// </summary>
        public string ErrorsReportFile
        {
            get;
            internal set;
        }

        /// <summary>
        /// full_report_file
        /// </summary>
        public string FullReportFile
        {
            get;
            internal set;
        }

        /// <summary>
        /// processed_count
        /// </summary>
        public int? ProcessedCount
        {
            get;
            internal set;
        }

        /// <summary>
        /// status
        /// </summary>
        public DeviceEnrollmentBulkCreateStatus? Status
        {
            get;
            internal set;
        }

        /// <summary>
        /// total_count
        /// </summary>
        public int? TotalCount
        {
            get;
            internal set;
        }
    }
}