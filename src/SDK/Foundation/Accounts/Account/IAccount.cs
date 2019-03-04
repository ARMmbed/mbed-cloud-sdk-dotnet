// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="IAccount.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.Foundation.Enums;
    using Mbed.Cloud.Foundation;

    /// <summary>
    /// Account
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// address_line1
        /// </summary>
        string AddressLine1
        {
            get;
            set;
        }

        /// <summary>
        /// address_line2
        /// </summary>
        string AddressLine2
        {
            get;
            set;
        }

        /// <summary>
        /// admin_email
        /// </summary>
        string AdminEmail
        {
            get;
            set;
        }

        /// <summary>
        /// admin_full_name
        /// </summary>
        string AdminFullName
        {
            get;
            set;
        }

        /// <summary>
        /// admin_id
        /// </summary>
        string AdminId
        {
            get;
        }

        /// <summary>
        /// admin_key
        /// </summary>
        string AdminKey
        {
            get;
        }

        /// <summary>
        /// admin_name
        /// </summary>
        string AdminName
        {
            get;
            set;
        }

        /// <summary>
        /// admin_password
        /// </summary>
        string AdminPassword
        {
            get;
            set;
        }

        /// <summary>
        /// aliases
        /// </summary>
        List<string> Aliases
        {
            get;
            set;
        }

        /// <summary>
        /// city
        /// </summary>
        string City
        {
            get;
            set;
        }

        /// <summary>
        /// company
        /// </summary>
        string Company
        {
            get;
            set;
        }

        /// <summary>
        /// contact
        /// </summary>
        string Contact
        {
            get;
            set;
        }

        /// <summary>
        /// contract_number
        /// </summary>
        string ContractNumber
        {
            get;
            set;
        }

        /// <summary>
        /// country
        /// </summary>
        string Country
        {
            get;
            set;
        }

        /// <summary>
        /// created_at
        /// </summary>
        DateTime? CreatedAt
        {
            get;
        }

        /// <summary>
        /// custom_fields
        /// </summary>
        Dictionary<string, string> CustomFields
        {
            get;
            set;
        }

        /// <summary>
        /// customer_number
        /// </summary>
        string CustomerNumber
        {
            get;
            set;
        }

        /// <summary>
        /// display_name
        /// </summary>
        string DisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// email
        /// </summary>
        string Email
        {
            get;
            set;
        }

        /// <summary>
        /// end_market
        /// </summary>
        string EndMarket
        {
            get;
            set;
        }

        /// <summary>
        /// expiration
        /// </summary>
        DateTime? Expiration
        {
            get;
        }

        /// <summary>
        /// expiration_warning_threshold
        /// </summary>
        string ExpirationWarningThreshold
        {
            get;
            set;
        }

        /// <summary>
        /// idle_timeout
        /// </summary>
        string IdleTimeout
        {
            get;
            set;
        }

        /// <summary>
        /// limits
        /// </summary>
        Dictionary<string, string> Limits
        {
            get;
        }

        /// <summary>
        /// mfa_status
        /// </summary>
        AccountMfaStatus? MfaStatus
        {
            get;
            set;
        }

        /// <summary>
        /// notification_emails
        /// </summary>
        List<string> NotificationEmails
        {
            get;
            set;
        }

        /// <summary>
        /// parent_account
        /// </summary>
        ParentAccount ParentAccount
        {
            get;
        }

        /// <summary>
        /// parent_id
        /// </summary>
        string ParentId
        {
            get;
        }

        /// <summary>
        /// password_policy
        /// </summary>
        PasswordPolicy PasswordPolicy
        {
            get;
            set;
        }

        /// <summary>
        /// password_recovery_expiration
        /// </summary>
        int? PasswordRecoveryExpiration
        {
            get;
            set;
        }

        /// <summary>
        /// phone_number
        /// </summary>
        string PhoneNumber
        {
            get;
            set;
        }

        /// <summary>
        /// policies
        /// </summary>
        List<Policy> Policies
        {
            get;
        }

        /// <summary>
        /// postal_code
        /// </summary>
        string PostalCode
        {
            get;
            set;
        }

        /// <summary>
        /// reason
        /// </summary>
        string Reason
        {
            get;
        }

        /// <summary>
        /// reference_note
        /// </summary>
        string ReferenceNote
        {
            get;
        }

        /// <summary>
        /// sales_contact
        /// </summary>
        string SalesContact
        {
            get;
            set;
        }

        /// <summary>
        /// state
        /// </summary>
        string State
        {
            get;
            set;
        }

        /// <summary>
        /// status
        /// </summary>
        AccountStatus? Status
        {
            get;
        }

        /// <summary>
        /// template_id
        /// </summary>
        string TemplateId
        {
            get;
        }

        /// <summary>
        /// tier
        /// </summary>
        string Tier
        {
            get;
        }

        /// <summary>
        /// updated_at
        /// </summary>
        DateTime? UpdatedAt
        {
            get;
        }

        /// <summary>
        /// upgraded_at
        /// </summary>
        DateTime? UpgradedAt
        {
            get;
        }
    }
}