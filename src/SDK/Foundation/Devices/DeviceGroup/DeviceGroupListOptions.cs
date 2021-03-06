// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="DeviceGroupListOptions.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Common.Filters;
    using System.Collections.Generic;
    using System;

    /// <summary>
    /// DeviceGroupListOptions
    /// </summary>
    public class DeviceGroupListOptions : QueryOptions, IDeviceGroupListOptions
    {
        public DeviceGroupListOptions()
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

        public DeviceGroupListOptions IdEqualTo(string value)
        {
            this.Filter.AddFilterItem("id", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public DeviceGroupListOptions IdNotEqualTo(string value)
        {
            this.Filter.AddFilterItem("id", new FilterItem(value, FilterOperator.NotEqual));
            return this;
        }

        public DeviceGroupListOptions IdIn(params string[] value)
        {
            this.Filter.AddFilterItem("id", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public DeviceGroupListOptions IdNotIn(params string[] value)
        {
            this.Filter.AddFilterItem("id", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public DeviceGroupListOptions DevicesCountEqualTo(int value)
        {
            this.Filter.AddFilterItem("devices_count", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public DeviceGroupListOptions DevicesCountNotEqualTo(int value)
        {
            this.Filter.AddFilterItem("devices_count", new FilterItem(value, FilterOperator.NotEqual));
            return this;
        }

        public DeviceGroupListOptions DevicesCountIn(params int[] value)
        {
            this.Filter.AddFilterItem("devices_count", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public DeviceGroupListOptions DevicesCountNotIn(params int[] value)
        {
            this.Filter.AddFilterItem("devices_count", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public DeviceGroupListOptions DevicesCountLessThan(int value)
        {
            this.Filter.AddFilterItem("devices_count", new FilterItem(value, FilterOperator.LessThan));
            return this;
        }

        public DeviceGroupListOptions DevicesCountGreaterThan(int value)
        {
            this.Filter.AddFilterItem("devices_count", new FilterItem(value, FilterOperator.GreaterThan));
            return this;
        }

        public DeviceGroupListOptions NameEqualTo(string value)
        {
            this.Filter.AddFilterItem("name", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public DeviceGroupListOptions NameNotEqualTo(string value)
        {
            this.Filter.AddFilterItem("name", new FilterItem(value, FilterOperator.NotEqual));
            return this;
        }

        public DeviceGroupListOptions NameIn(params string[] value)
        {
            this.Filter.AddFilterItem("name", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public DeviceGroupListOptions NameNotIn(params string[] value)
        {
            this.Filter.AddFilterItem("name", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public DeviceGroupListOptions CreatedAtIn(params DateTime[] value)
        {
            this.Filter.AddFilterItem("created_at", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public DeviceGroupListOptions CreatedAtNotIn(params DateTime[] value)
        {
            this.Filter.AddFilterItem("created_at", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public DeviceGroupListOptions CreatedAtLessThan(DateTime value)
        {
            this.Filter.AddFilterItem("created_at", new FilterItem(value, FilterOperator.LessThan));
            return this;
        }

        public DeviceGroupListOptions CreatedAtGreaterThan(DateTime value)
        {
            this.Filter.AddFilterItem("created_at", new FilterItem(value, FilterOperator.GreaterThan));
            return this;
        }

        public DeviceGroupListOptions UpdatedAtIn(params DateTime[] value)
        {
            this.Filter.AddFilterItem("updated_at", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public DeviceGroupListOptions UpdatedAtNotIn(params DateTime[] value)
        {
            this.Filter.AddFilterItem("updated_at", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public DeviceGroupListOptions UpdatedAtLessThan(DateTime value)
        {
            this.Filter.AddFilterItem("updated_at", new FilterItem(value, FilterOperator.LessThan));
            return this;
        }

        public DeviceGroupListOptions UpdatedAtGreaterThan(DateTime value)
        {
            this.Filter.AddFilterItem("updated_at", new FilterItem(value, FilterOperator.GreaterThan));
            return this;
        }
    }
}