// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="FirmwareImageListOptions.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Common.Filters;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// FirmwareImageListOptions
    /// </summary>
    public class FirmwareImageListOptions : QueryOptions, IFirmwareImageListOptions
    {
        public FirmwareImageListOptions()
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

        public FirmwareImageListOptions CreatedAtIn(params DateTime[] value)
        {
            this.Filter.AddFilterItem("created_at", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public FirmwareImageListOptions CreatedAtNotIn(params DateTime[] value)
        {
            this.Filter.AddFilterItem("created_at", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public FirmwareImageListOptions CreatedAtLessThan(DateTime value)
        {
            this.Filter.AddFilterItem("created_at", new FilterItem(value, FilterOperator.LessThan));
            return this;
        }

        public FirmwareImageListOptions CreatedAtGreaterThan(DateTime value)
        {
            this.Filter.AddFilterItem("created_at", new FilterItem(value, FilterOperator.GreaterThan));
            return this;
        }

        public FirmwareImageListOptions DatafileUrlEqualTo(string value)
        {
            this.Filter.AddFilterItem("datafile_url", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public FirmwareImageListOptions DatafileUrlNotEqualTo(string value)
        {
            this.Filter.AddFilterItem("datafile_url", new FilterItem(value, FilterOperator.NotEqual));
            return this;
        }

        public FirmwareImageListOptions DatafileUrlIn(params string[] value)
        {
            this.Filter.AddFilterItem("datafile_url", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public FirmwareImageListOptions DatafileUrlNotIn(params string[] value)
        {
            this.Filter.AddFilterItem("datafile_url", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public FirmwareImageListOptions DatafileChecksumEqualTo(string value)
        {
            this.Filter.AddFilterItem("datafile_checksum", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public FirmwareImageListOptions DatafileChecksumNotEqualTo(string value)
        {
            this.Filter.AddFilterItem("datafile_checksum", new FilterItem(value, FilterOperator.NotEqual));
            return this;
        }

        public FirmwareImageListOptions DatafileChecksumIn(params string[] value)
        {
            this.Filter.AddFilterItem("datafile_checksum", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public FirmwareImageListOptions DatafileChecksumNotIn(params string[] value)
        {
            this.Filter.AddFilterItem("datafile_checksum", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public FirmwareImageListOptions DatafileSizeEqualTo(long value)
        {
            this.Filter.AddFilterItem("datafile_size", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public FirmwareImageListOptions DatafileSizeNotEqualTo(long value)
        {
            this.Filter.AddFilterItem("datafile_size", new FilterItem(value, FilterOperator.NotEqual));
            return this;
        }

        public FirmwareImageListOptions DatafileSizeIn(params long[] value)
        {
            this.Filter.AddFilterItem("datafile_size", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public FirmwareImageListOptions DatafileSizeNotIn(params long[] value)
        {
            this.Filter.AddFilterItem("datafile_size", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public FirmwareImageListOptions DescriptionEqualTo(string value)
        {
            this.Filter.AddFilterItem("description", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public FirmwareImageListOptions DescriptionNotEqualTo(string value)
        {
            this.Filter.AddFilterItem("description", new FilterItem(value, FilterOperator.NotEqual));
            return this;
        }

        public FirmwareImageListOptions DescriptionIn(params string[] value)
        {
            this.Filter.AddFilterItem("description", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public FirmwareImageListOptions DescriptionNotIn(params string[] value)
        {
            this.Filter.AddFilterItem("description", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public FirmwareImageListOptions IdEqualTo(string value)
        {
            this.Filter.AddFilterItem("id", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public FirmwareImageListOptions IdNotEqualTo(string value)
        {
            this.Filter.AddFilterItem("id", new FilterItem(value, FilterOperator.NotEqual));
            return this;
        }

        public FirmwareImageListOptions IdIn(params string[] value)
        {
            this.Filter.AddFilterItem("id", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public FirmwareImageListOptions IdNotIn(params string[] value)
        {
            this.Filter.AddFilterItem("id", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public FirmwareImageListOptions NameEqualTo(string value)
        {
            this.Filter.AddFilterItem("name", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public FirmwareImageListOptions NameNotEqualTo(string value)
        {
            this.Filter.AddFilterItem("name", new FilterItem(value, FilterOperator.NotEqual));
            return this;
        }

        public FirmwareImageListOptions NameIn(params string[] value)
        {
            this.Filter.AddFilterItem("name", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public FirmwareImageListOptions NameNotIn(params string[] value)
        {
            this.Filter.AddFilterItem("name", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public FirmwareImageListOptions UpdatedAtIn(params DateTime[] value)
        {
            this.Filter.AddFilterItem("updated_at", new FilterItem(value, FilterOperator.In));
            return this;
        }

        public FirmwareImageListOptions UpdatedAtNotIn(params DateTime[] value)
        {
            this.Filter.AddFilterItem("updated_at", new FilterItem(value, FilterOperator.NotIn));
            return this;
        }

        public FirmwareImageListOptions UpdatedAtLessThan(DateTime value)
        {
            this.Filter.AddFilterItem("updated_at", new FilterItem(value, FilterOperator.LessThan));
            return this;
        }

        public FirmwareImageListOptions UpdatedAtGreaterThan(DateTime value)
        {
            this.Filter.AddFilterItem("updated_at", new FilterItem(value, FilterOperator.GreaterThan));
            return this;
        }
    }
}