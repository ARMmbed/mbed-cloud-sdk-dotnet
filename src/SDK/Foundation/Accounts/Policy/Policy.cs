// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="Policy.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;

    /// <summary>
    /// Policy
    /// </summary>
    public class Policy : Entity, IPolicy
    {
        /// <summary>
        /// action
        /// </summary>
        public string Action
        {
            get;
            private set;
        }

        /// <summary>
        /// allow
        /// </summary>
        public bool? Allow
        {
            get;
            private set;
        }

        /// <summary>
        /// feature
        /// </summary>
        public string Feature
        {
            get;
            private set;
        }

        /// <summary>
        /// inherited
        /// </summary>
        public bool? Inherited
        {
            get;
            private set;
        }

        /// <summary>
        /// resource
        /// </summary>
        public string Resource
        {
            get;
            private set;
        }
    }
}