// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 1.0.0
//
// <copyright file="Account.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace MbedCloud.SDK.Entities
{
    using MbedCloud.SDK.Common;
    using MbedCloud.SDK.Client;
    using System.Collections.Generic;
    using System;
    using MbedCloud.SDK.Enums;
    using MbedCloud.SDK.Entities;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;

    /// <summary>
    /// Account
    /// </summary>
    public class Account : BaseEntity
    {
        public Account()
        {
        }

        public Account(Config config) : base(config)
        {
        }

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
            set;
        }

        /// <summary>
        /// admin_key
        /// </summary>
        public string AdminKey
        {
            get;
            set;
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

        /// <summary>
        /// created_at
        /// </summary>
        public DateTime? CreatedAt
        {
            get;
            set;
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

        /// <summary>
        /// expiration_warning_threshold
        /// </summary>
        public string ExpirationWarningThreshold
        {
            get;
            set;
        }

        /// <summary>
        /// idle_timeout
        /// </summary>
        public string IdleTimeout
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
            set;
        }

        /// <summary>
        /// mfa_status
        /// </summary>
        public AccountMfaStatusEnum? MfaStatus
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
        /// parent_id
        /// </summary>
        public string ParentId
        {
            get;
            set;
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
            set;
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
            set;
        }

        /// <summary>
        /// reference_note
        /// </summary>
        public string ReferenceNote
        {
            get;
            set;
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
        public AccountStatusEnum? Status
        {
            get;
            set;
        }

        /// <summary>
        /// sub_accounts
        /// </summary>
        public List<object> SubAccounts
        {
            get;
            set;
        }

        /// <summary>
        /// template_id
        /// </summary>
        public string TemplateId
        {
            get;
            set;
        }

        /// <summary>
        /// tier
        /// </summary>
        public string Tier
        {
            get;
            set;
        }

        /// <summary>
        /// updated_at
        /// </summary>
        public DateTime? UpdatedAt
        {
            get;
            set;
        }

        /// <summary>
        /// upgraded_at
        /// </summary>
        public DateTime? UpgradedAt
        {
            get;
            set;
        }

        public async Task<Account> Create(string action = null)
        {
            try
            {
                var queryParams = new Dictionary<string, object> { { "action", action }, };
                var bodyParams = new Account { AddressLine1 = AddressLine1, AddressLine2 = AddressLine2, AdminEmail = AdminEmail, AdminFullName = AdminFullName, AdminName = AdminName, AdminPassword = AdminPassword, Aliases = Aliases, City = City, Company = Company, Contact = Contact, ContractNumber = ContractNumber, Country = Country, CustomerNumber = CustomerNumber, DisplayName = DisplayName, Email = Email, EndMarket = EndMarket, PhoneNumber = PhoneNumber, PostalCode = PostalCode, State = State, };
                return await Client.CallApi<Account>(path: "/v3/accounts", queryParams: queryParams, bodyParams: bodyParams, method: HttpMethods.POST, objectToUnpack: this);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<Account> Get(string include = null, string properties = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "accountID", Id }, };
                var queryParams = new Dictionary<string, object> { { "include", include }, { "properties", properties }, };
                return await Client.CallApi<Account>(path: "/v3/accounts/{accountID}", pathParams: pathParams, queryParams: queryParams, method: HttpMethods.GET, objectToUnpack: this);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<QueryOptions, Account> List(QueryOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new QueryOptions();
                }

                Func<QueryOptions, ResponsePage<Account>> paginatedFunc = (QueryOptions _options) => AsyncHelper.RunSync<ResponsePage<Account>>(() => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, }; return Client.CallApi<ResponsePage<Account>>(path: "/v3/accounts", queryParams: queryParams, method: HttpMethods.GET); });
                return new PaginatedResponse<QueryOptions, Account>(paginatedFunc, options);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<Account> Me(string include = null, string properties = null)
        {
            try
            {
                var queryParams = new Dictionary<string, object> { { "include", include }, { "properties", properties }, };
                return await Client.CallApi<Account>(path: "/v3/accounts/me", queryParams: queryParams, method: HttpMethods.GET, objectToUnpack: this);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<QueryOptions, SubtenantTrustedCertificate> TrustedCertificates(QueryOptions options = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "accountID", Id }, };
                if (options == null)
                {
                    options = new QueryOptions();
                }

                Func<QueryOptions, ResponsePage<SubtenantTrustedCertificate>> paginatedFunc = (QueryOptions _options) => AsyncHelper.RunSync<ResponsePage<SubtenantTrustedCertificate>>(() => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, }; return Client.CallApi<ResponsePage<SubtenantTrustedCertificate>>(path: "/v3/accounts/{accountID}/trusted-certificates", pathParams: pathParams, queryParams: queryParams, method: HttpMethods.GET); });
                return new PaginatedResponse<QueryOptions, SubtenantTrustedCertificate>(paginatedFunc, options);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<Account> Update()
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "accountID", Id }, };
                var bodyParams = new Account { AddressLine1 = AddressLine1, AddressLine2 = AddressLine2, Aliases = Aliases, City = City, Company = Company, Contact = Contact, ContractNumber = ContractNumber, Country = Country, CustomFields = CustomFields, CustomerNumber = CustomerNumber, DisplayName = DisplayName, Email = Email, EndMarket = EndMarket, ExpirationWarningThreshold = ExpirationWarningThreshold, IdleTimeout = IdleTimeout, MfaStatus = MfaStatus, NotificationEmails = NotificationEmails, PasswordPolicy = PasswordPolicy, PhoneNumber = PhoneNumber, PostalCode = PostalCode, SalesContact = SalesContact, State = State, };
                return await Client.CallApi<Account>(path: "/v3/accounts/{accountID}", pathParams: pathParams, bodyParams: bodyParams, method: HttpMethods.PUT, objectToUnpack: this);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<QueryOptions, SubtenantUserInvitation> UserInvitations(QueryOptions options = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account-id", Id }, };
                if (options == null)
                {
                    options = new QueryOptions();
                }

                Func<QueryOptions, ResponsePage<SubtenantUserInvitation>> paginatedFunc = (QueryOptions _options) => AsyncHelper.RunSync<ResponsePage<SubtenantUserInvitation>>(() => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "limit", _options.Limit }, { "order", _options.Order }, }; return Client.CallApi<ResponsePage<SubtenantUserInvitation>>(path: "/v3/accounts/{account-id}/user-invitations", pathParams: pathParams, queryParams: queryParams, method: HttpMethods.GET); });
                return new PaginatedResponse<QueryOptions, SubtenantUserInvitation>(paginatedFunc, options);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<QueryOptions, SubtenantUser> Users(QueryOptions options = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "accountID", Id }, };
                if (options == null)
                {
                    options = new QueryOptions();
                }

                Func<QueryOptions, ResponsePage<SubtenantUser>> paginatedFunc = (QueryOptions _options) => AsyncHelper.RunSync<ResponsePage<SubtenantUser>>(() => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, }; return Client.CallApi<ResponsePage<SubtenantUser>>(path: "/v3/accounts/{accountID}/users", pathParams: pathParams, queryParams: queryParams, method: HttpMethods.GET); });
                return new PaginatedResponse<QueryOptions, SubtenantUser>(paginatedFunc, options);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}