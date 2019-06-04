// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="DarkThemeImage.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Foundation.Enums;
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// DarkThemeImage
    /// </summary>
    public class DarkThemeImage : Entity, IDarkThemeImage
    {
        /// <summary>
        /// reference
        /// </summary>
        public DarkThemeImageReference? Reference
        {
            get;
            set;
        }

        /// <summary>
        /// static_uri
        /// </summary>
        public string StaticUri
        {
            get;
            internal set;
        }
        [JsonConverter(typeof(CustomDateConverter), "yyyy-MM-dd'T'HH:mm:ss.fffZ")]
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