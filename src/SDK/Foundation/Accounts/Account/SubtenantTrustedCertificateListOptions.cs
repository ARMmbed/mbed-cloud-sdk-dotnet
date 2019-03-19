// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="SubtenantTrustedCertificateListOptions.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Common.Filters;
    using Mbed.Cloud.Foundation.Enums;

    /// <summary>
    /// SubtenantTrustedCertificateListOptions
    /// </summary>
    public class SubtenantTrustedCertificateListOptions : QueryOptions, ISubtenantTrustedCertificateListOptions
    {
        public SubtenantTrustedCertificateListOptions()
        {
            Filter = new Filter();
        }

        /// <summary>
        /// Filter object
        /// </summary>
        public Filter Filter
        {
            get;
            private set;
        }

        public SubtenantTrustedCertificateListOptions NameEqualTo(string value)
        {
            this.Filter.AddFilterItem("name", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public SubtenantTrustedCertificateListOptions ServiceEqualTo(string value)
        {
            this.Filter.AddFilterItem("service", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public SubtenantTrustedCertificateListOptions ExpireEqualTo(string value)
        {
            this.Filter.AddFilterItem("expire", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public SubtenantTrustedCertificateListOptions DeviceExecutionModeEqualTo(string value)
        {
            this.Filter.AddFilterItem("device_execution_mode", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public SubtenantTrustedCertificateListOptions DeviceExecutionModeNotEqualTo(string value)
        {
            this.Filter.AddFilterItem("device_execution_mode", new FilterItem(value, FilterOperator.NotEqual));
            return this;
        }

        public SubtenantTrustedCertificateListOptions OwnerEqualTo(string value)
        {
            this.Filter.AddFilterItem("owner", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public SubtenantTrustedCertificateListOptions EnrollmentModeEqualTo(string value)
        {
            this.Filter.AddFilterItem("enrollment_mode", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public SubtenantTrustedCertificateListOptions StatusEqualTo(AccountStatus value)
        {
            this.Filter.AddFilterItem("status", new FilterItem(value, FilterOperator.Equals));
            return this;
        }

        public SubtenantTrustedCertificateListOptions IssuerLike(string value)
        {
            this.Filter.AddFilterItem("issuer", new FilterItem(value, FilterOperator.Like));
            return this;
        }

        public SubtenantTrustedCertificateListOptions SubjectLike(string value)
        {
            this.Filter.AddFilterItem("subject", new FilterItem(value, FilterOperator.Like));
            return this;
        }

        public SubtenantTrustedCertificateListOptions ValidEqualTo(string value)
        {
            this.Filter.AddFilterItem("valid", new FilterItem(value, FilterOperator.Equals));
            return this;
        }
    }
}