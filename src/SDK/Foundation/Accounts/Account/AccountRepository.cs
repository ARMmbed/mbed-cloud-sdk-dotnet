// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="AccountRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation.Entities
{
    using Mbed.Cloud.Foundation.Common;
    using Mbed.Cloud.Foundation.ListOptions;
    using Mbed.Cloud.Foundation.Entities;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.Foundation.RestClient;

    /// <summary>
    /// AccountRepository
    /// </summary>
    public class AccountRepository : Repository
    {
        public AccountRepository()
        {
        }

        public AccountRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task<Account> Create(Account request, string action = null)
        {
            try
            {
                var queryParams = new Dictionary<string, object> { { "action", action }, };
                var bodyParams = new Account { AddressLine1 = request.AddressLine1, AddressLine2 = request.AddressLine2, AdminEmail = request.AdminEmail, AdminFullName = request.AdminFullName, AdminName = request.AdminName, AdminPassword = request.AdminPassword, Aliases = request.Aliases, City = request.City, Company = request.Company, Contact = request.Contact, ContractNumber = request.ContractNumber, Country = request.Country, CustomerNumber = request.CustomerNumber, DisplayName = request.DisplayName, Email = request.Email, EndMarket = request.EndMarket, PhoneNumber = request.PhoneNumber, PostalCode = request.PostalCode, State = request.State, };
                return await Client.CallApi<Account>(path: "/v3/accounts", queryParams: queryParams, bodyParams: bodyParams, method: HttpMethods.POST, objectToUnpack: request);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<Account> Get(string id, string include = null, string properties = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", id }, };
                var queryParams = new Dictionary<string, object> { { "include", include }, { "properties", properties }, };
                return await Client.CallApi<Account>(path: "/v3/accounts/{account_id}", pathParams: pathParams, queryParams: queryParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<AccountListOptions, Account> List(AccountListOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new AccountListOptions();
                }

                Func<AccountListOptions, Task<ResponsePage<Account>>> paginatedFunc = async (AccountListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "format", _options.Format }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, { "properties", _options.Properties }, }; return await Client.CallApi<ResponsePage<Account>>(path: "/v3/accounts", queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<AccountListOptions, Account>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<Account> Me(string include = null, string properties = null)
        {
            try
            {
                var queryParams = new Dictionary<string, object> { { "include", include }, { "properties", properties }, };
                return await Client.CallApi<Account>(path: "/v3/accounts/me", queryParams: queryParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<SubtenantTrustedCertificateListOptions, SubtenantTrustedCertificate> TrustedCertificates(string id, SubtenantTrustedCertificateListOptions options = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", id }, };
                if (options == null)
                {
                    options = new SubtenantTrustedCertificateListOptions();
                }

                Func<SubtenantTrustedCertificateListOptions, Task<ResponsePage<SubtenantTrustedCertificate>>> paginatedFunc = async (SubtenantTrustedCertificateListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, }; return await Client.CallApi<ResponsePage<SubtenantTrustedCertificate>>(path: "/v3/accounts/{account_id}/trusted-certificates", pathParams: pathParams, queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<SubtenantTrustedCertificateListOptions, SubtenantTrustedCertificate>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<Account> Update(string id, Account request)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", id }, };
                var bodyParams = new Account { AddressLine1 = request.AddressLine1, AddressLine2 = request.AddressLine2, Aliases = request.Aliases, City = request.City, Company = request.Company, Contact = request.Contact, ContractNumber = request.ContractNumber, Country = request.Country, CustomFields = request.CustomFields, CustomerNumber = request.CustomerNumber, DisplayName = request.DisplayName, Email = request.Email, EndMarket = request.EndMarket, ExpirationWarningThreshold = request.ExpirationWarningThreshold, IdleTimeout = request.IdleTimeout, MfaStatus = request.MfaStatus, NotificationEmails = request.NotificationEmails, PasswordPolicy = request.PasswordPolicy, PasswordRecoveryExpiration = request.PasswordRecoveryExpiration, PhoneNumber = request.PhoneNumber, PostalCode = request.PostalCode, SalesContact = request.SalesContact, State = request.State, };
                return await Client.CallApi<Account>(path: "/v3/accounts/{account_id}", pathParams: pathParams, bodyParams: bodyParams, method: HttpMethods.PUT, objectToUnpack: request);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<SubtenantUserInvitationListOptions, SubtenantUserInvitation> UserInvitations(string id, SubtenantUserInvitationListOptions options = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", id }, };
                if (options == null)
                {
                    options = new SubtenantUserInvitationListOptions();
                }

                Func<SubtenantUserInvitationListOptions, Task<ResponsePage<SubtenantUserInvitation>>> paginatedFunc = async (SubtenantUserInvitationListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "limit", _options.Limit }, { "order", _options.Order }, }; return await Client.CallApi<ResponsePage<SubtenantUserInvitation>>(path: "/v3/accounts/{account_id}/user-invitations", pathParams: pathParams, queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<SubtenantUserInvitationListOptions, SubtenantUserInvitation>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<SubtenantUserListOptions, SubtenantUser> Users(string id, SubtenantUserListOptions options = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", id }, };
                if (options == null)
                {
                    options = new SubtenantUserListOptions();
                }

                Func<SubtenantUserListOptions, Task<ResponsePage<SubtenantUser>>> paginatedFunc = async (SubtenantUserListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, }; return await Client.CallApi<ResponsePage<SubtenantUser>>(path: "/v3/accounts/{account_id}/users", pathParams: pathParams, queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<SubtenantUserListOptions, SubtenantUser>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}