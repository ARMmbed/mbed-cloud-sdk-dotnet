// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="AccountListOptions.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Common.Filters;
    using Mbed.Cloud.Foundation.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// AccountListOptions
    /// </summary>
    public class AccountListOptions : QueryOptions, IAccountListOptions
    {
        public AccountListOptions()
        {
            Filter = new Filter();
        }

        /// <summary>
        /// 
        /// </summary>
        public string Format
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Properties
        {
            get;
            set;
        }

        /// <summary>
        /// Filter object
        /// </summary>
        public Filter Filter
        {
            get;
            private set;
        }

        public AccountListOptions StatusEqualTo(AccountStatus value)
        {
            this.Filter.AddFilterItem("status", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public AccountListOptions StatusIn(IEnumerable<AccountStatus> value)
        {
            this.Filter.AddFilterItem("status", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public AccountListOptions StatusNotIn(IEnumerable<AccountStatus> value)
        {
            this.Filter.AddFilterItem("status", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public AccountListOptions TierEqualTo(string value)
        {
            this.Filter.AddFilterItem("tier", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public AccountListOptions ParentEqualTo(string value)
        {
            this.Filter.AddFilterItem("parent", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public AccountListOptions EndMarketEqualTo(string value)
        {
            this.Filter.AddFilterItem("end_market", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public AccountListOptions CountryLike(string value)
        {
            this.Filter.AddFilterItem("country", new FilterItem(value, FilterOperator.Like));
            return this;
        }
    }
}