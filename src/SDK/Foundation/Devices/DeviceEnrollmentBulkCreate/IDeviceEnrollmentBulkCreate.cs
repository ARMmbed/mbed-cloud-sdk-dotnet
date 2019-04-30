// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="IDeviceEnrollmentBulkCreate.cs" company="Arm">
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
    public interface IDeviceEnrollmentBulkCreate
    {
        /// <summary>
        /// account_id
        /// </summary>
        string AccountId
        {
            get;
        }
        [JsonConverter(typeof(CustomDateConverter), "yyyy-MM-dd'T'HH:mm:ss.fffZ")]
        /// <summary>
        /// completed_at
        /// </summary>
        DateTime? CompletedAt
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
        /// errors_count
        /// </summary>
        int? ErrorsCount
        {
            get;
        }

        /// <summary>
        /// errors_report_file
        /// </summary>
        string ErrorsReportFile
        {
            get;
        }

        /// <summary>
        /// full_report_file
        /// </summary>
        string FullReportFile
        {
            get;
        }

        /// <summary>
        /// processed_count
        /// </summary>
        int? ProcessedCount
        {
            get;
        }

        /// <summary>
        /// status
        /// </summary>
        DeviceEnrollmentBulkCreateStatus? Status
        {
            get;
        }

        /// <summary>
        /// total_count
        /// </summary>
        int? TotalCount
        {
            get;
        }
    }
}