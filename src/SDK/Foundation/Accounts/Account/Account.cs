// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="Account.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using System;
    using Mbed.Cloud.Foundation.Enums;
    using Mbed.Cloud.Foundation;

    /// <summary>
    /// Account
    /// </summary>
    public class Account : Entity, IAccount
    {
        /// <summary>
        /// address_line1
        /// </summary>
        public string AddressLine1
        {
            get;
            set;
        }

        /// <summary>
        /// address_line2
        /// </summary>
        public string AddressLine2
        {
            get;
            set;
        }

        /// <summary>
        /// admin_email
        /// </summary>
        public string AdminEmail
        {
            get;
            set;
        }

        /// <summary>
        /// admin_full_name
        /// </summary>
        public string AdminFullName
        {
            get;
            set;
        }

        /// <summary>
        /// admin_id
        /// </summary>
        public string AdminId
        {
            get;
            internal set;
        }

        /// <summary>
        /// admin_key
        /// </summary>
        public string AdminKey
        {
            get;
            internal set;
        }

        /// <summary>
        /// admin_name
        /// </summary>
        public string AdminName
        {
            get;
            set;
        }

        /// <summary>
        /// admin_password
        /// </summary>
        public string AdminPassword
        {
            get;
            set;
        }

        /// <summary>
        /// aliases
        /// </summary>
        public List<string> Aliases
        {
            get;
            set;
        }

        /// <summary>
        /// city
        /// </summary>
        public string City
        {
            get;
            set;
        }

        /// <summary>
        /// company
        /// </summary>
        public string Company
        {
            get;
            set;
        }

        /// <summary>
        /// contact
        /// </summary>
        public string Contact
        {
            get;
            set;
        }

        /// <summary>
        /// contract_number
        /// </summary>
        public string ContractNumber
        {
            get;
            set;
        }

        /// <summary>
        /// country
        /// </summary>
        public string Country
        {
            get;
            set;
        }
        [JsonConverter(typeof(CustomDateConverter), "yyyy-MM-dd'T'HH:mm:ss.fffZ")]
        /// <summary>
        /// created_at
        /// </summary>
        public DateTime? CreatedAt
        {
            get;
            internal set;
        }

        /// <summary>
        /// custom_fields
        /// </summary>
        public Dictionary<string, string> CustomFields
        {
            get;
            set;
        }

        /// <summary>
        /// customer_number
        /// </summary>
        public string CustomerNumber
        {
            get;
            set;
        }

        /// <summary>
        /// display_name
        /// </summary>
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// email
        /// </summary>
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// end_market
        /// </summary>
        public string EndMarket
        {
            get;
            set;
        }
        [JsonConverter(typeof(CustomDateConverter), "yyyy-MM-dd'T'HH:mm:ss.fffZ")]
        /// <summary>
        /// expiration
        /// </summary>
        public DateTime? Expiration
        {
            get;
            internal set;
        }

        /// <summary>
        /// expiration_warning_threshold
        /// </summary>
        public int? ExpirationWarningThreshold
        {
            get;
            set;
        }

        /// <summary>
        /// idle_timeout
        /// </summary>
        public int? IdleTimeout
        {
            get;
            set;
        }

        /// <summary>
        /// limits
        /// </summary>
        public Dictionary<string, string> Limits
        {
            get;
            internal set;
        }

        /// <summary>
        /// mfa_status
        /// </summary>
        public AccountMfaStatus? MfaStatus
        {
            get;
            set;
        }

        /// <summary>
        /// notification_emails
        /// </summary>
        public List<string> NotificationEmails
        {
            get;
            set;
        }

        /// <summary>
        /// parent_account
        /// </summary>
        public ParentAccount ParentAccount
        {
            get;
            internal set;
        }

        /// <summary>
        /// parent_id
        /// </summary>
        public string ParentId
        {
            get;
            internal set;
        }

        /// <summary>
        /// password_policy
        /// </summary>
        public PasswordPolicy PasswordPolicy
        {
            get;
            set;
        }

        /// <summary>
        /// password_recovery_expiration
        /// </summary>
        public int? PasswordRecoveryExpiration
        {
            get;
            set;
        }

        /// <summary>
        /// phone_number
        /// </summary>
        public string PhoneNumber
        {
            get;
            set;
        }

        /// <summary>
        /// policies
        /// </summary>
        public List<Policy> Policies
        {
            get;
            internal set;
        }

        /// <summary>
        /// postal_code
        /// </summary>
        public string PostalCode
        {
            get;
            set;
        }

        /// <summary>
        /// reason
        /// </summary>
        public string Reason
        {
            get;
            internal set;
        }

        /// <summary>
        /// reference_note
        /// </summary>
        public string ReferenceNote
        {
            get;
            internal set;
        }

        /// <summary>
        /// sales_contact
        /// </summary>
        public string SalesContact
        {
            get;
            set;
        }

        /// <summary>
        /// state
        /// </summary>
        public string State
        {
            get;
            set;
        }

        /// <summary>
        /// status
        /// </summary>
        public AccountStatus? Status
        {
            get;
            internal set;
        }

        /// <summary>
        /// template_id
        /// </summary>
        public string TemplateId
        {
            get;
            internal set;
        }

        /// <summary>
        /// tier
        /// </summary>
        public string Tier
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
        [JsonConverter(typeof(CustomDateConverter), "yyyy-MM-dd'T'HH:mm:ss.fffZ")]
        /// <summary>
        /// upgraded_at
        /// </summary>
        public DateTime? UpgradedAt
        {
            get;
            internal set;
        }
    }
}