// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 1.0.0
//
// <copyright file="LoginHistory.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace MbedCloud.SDK.Entities
{
    using MbedCloud.SDK.Common;
    using MbedCloud.SDK.Client;
    using System;

    /// <summary>
    /// LoginHistory
    /// </summary>
    public class LoginHistory : BaseEntity
    {
        public LoginHistory()
        {
        }

        public LoginHistory(Config config) : base(config)
        {
        }

        /// <summary>
        /// date
        /// </summary>
        public DateTime? Date
        {
            get;
            set;
        }

        /// <summary>
        /// ip_address
        /// </summary>
        public string IpAddress
        {
            get;
            set;
        }

        /// <summary>
        /// success
        /// </summary>
        public bool? Success
        {
            get;
            set;
        }

        /// <summary>
        /// user_agent
        /// </summary>
        public string UserAgent
        {
            get;
            set;
        }
    }
}