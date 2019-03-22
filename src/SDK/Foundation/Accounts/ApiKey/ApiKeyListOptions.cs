// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="ApiKeyListOptions.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Common.Filters;

    /// <summary>
    /// ApiKeyListOptions
    /// </summary>
    public class ApiKeyListOptions : QueryOptions, IApiKeyListOptions
    {
        public ApiKeyListOptions()
        {
            Filter = new Filter();
        }

        /// <summary>
        /// Filter object
        /// </summary>
        public Filter Filter
        {
            get;
            set;
        }

        public ApiKeyListOptions KeyEqualTo(string value)
        {
            this.Filter.AddFilterItem("key", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public ApiKeyListOptions OwnerEqualTo(string value)
        {
            this.Filter.AddFilterItem("owner", new FilterItem(value, FilterOperator.Equals));
            return this;
        }
    }
}