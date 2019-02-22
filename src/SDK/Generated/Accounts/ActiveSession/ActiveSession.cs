// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="ActiveSession.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation.Entities
{
    using Mbed.Cloud.Foundation.Common;
    using System;

    /// <summary>
    /// ActiveSession
    /// </summary>
    public class ActiveSession : Entity
    {
        /// <summary>
        /// account_id
        /// </summary>
        public string AccountId
        {
            get;
            internal set;
        }

        /// <summary>
        /// ip_address
        /// </summary>
        public string IpAddress
        {
            get;
            internal set;
        }

        /// <summary>
        /// login_time
        /// </summary>
        public DateTime? LoginTime
        {
            get;
            internal set;
        }

        /// <summary>
        /// reference_token
        /// </summary>
        public string ReferenceToken
        {
            get;
            internal set;
        }

        /// <summary>
        /// user_agent
        /// </summary>
        public string UserAgent
        {
            get;
            internal set;
        }
    }
}