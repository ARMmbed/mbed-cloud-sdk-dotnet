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

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Foundation;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.RestClient;

    /// <summary>
    /// AccountRepository
    /// </summary>
    public class AccountRepository : Repository, IAccountRepository
    {
        public AccountRepository()
        {
        }

        public AccountRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public PaginatedResponse<IAccountSubtenantApiKeyListOptions, SubtenantApiKey> ApiKeys(string id, IAccountSubtenantApiKeyListOptions options = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", id }, };
                if (options == null)
                {
                    options = new AccountSubtenantApiKeyListOptions();
                }

                Func<IAccountSubtenantApiKeyListOptions, Task<ResponsePage<SubtenantApiKey>>> paginatedFunc = async (IAccountSubtenantApiKeyListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, { "key__eq", _options.Filter.GetEncodedValue("key", "$eq") }, { "owner__eq", _options.Filter.GetEncodedValue("owner", "$eq") }, }; return await Client.CallApi<ResponsePage<SubtenantApiKey>>(path: "/v3/accounts/{account_id}/api-keys", pathParams: pathParams, queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<IAccountSubtenantApiKeyListOptions, SubtenantApiKey>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<Account> Create(Account request, string action = null)
        {
            try
            {
                var queryParams = new Dictionary<string, object> { { "action", action }, };
                var bodyParams = new Account { AddressLine1 = request.AddressLine1, AddressLine2 = request.AddressLine2, AdminEmail = request.AdminEmail, AdminFullName = request.AdminFullName, AdminName = request.AdminName, AdminPassword = request.AdminPassword, Aliases = request.Aliases, City = request.City, Company = request.Company, Contact = request.Contact, ContractNumber = request.ContractNumber, Country = request.Country, CustomerNumber = request.CustomerNumber, DisplayName = request.DisplayName, Email = request.Email, EndMarket = request.EndMarket, PhoneNumber = request.PhoneNumber, PostalCode = request.PostalCode, State = request.State, };
                return await Client.CallApi<Account>(path: "/v3/accounts", queryParams: queryParams, bodyParams: bodyParams, objectToUnpack: request, method: HttpMethods.POST);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<IAccountSubtenantDarkThemeColorListOptions, SubtenantDarkThemeColor> DarkThemeBrandingColors(string id, IAccountSubtenantDarkThemeColorListOptions options = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", id }, };
                if (options == null)
                {
                    options = new AccountSubtenantDarkThemeColorListOptions();
                }

                Func<IAccountSubtenantDarkThemeColorListOptions, Task<ResponsePage<SubtenantDarkThemeColor>>> paginatedFunc = async (IAccountSubtenantDarkThemeColorListOptions _options) => { return await Client.CallApi<ResponsePage<SubtenantDarkThemeColor>>(path: "/v3/accounts/{account_id}/branding-colors/dark", pathParams: pathParams, method: HttpMethods.GET); };
                return new PaginatedResponse<IAccountSubtenantDarkThemeColorListOptions, SubtenantDarkThemeColor>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<IAccountSubtenantDarkThemeImageListOptions, SubtenantDarkThemeImage> DarkThemeBrandingImages(string id, IAccountSubtenantDarkThemeImageListOptions options = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", id }, };
                if (options == null)
                {
                    options = new AccountSubtenantDarkThemeImageListOptions();
                }

                Func<IAccountSubtenantDarkThemeImageListOptions, Task<ResponsePage<SubtenantDarkThemeImage>>> paginatedFunc = async (IAccountSubtenantDarkThemeImageListOptions _options) => { return await Client.CallApi<ResponsePage<SubtenantDarkThemeImage>>(path: "/v3/accounts/{account_id}/branding-images/dark", pathParams: pathParams, method: HttpMethods.GET); };
                return new PaginatedResponse<IAccountSubtenantDarkThemeImageListOptions, SubtenantDarkThemeImage>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<IAccountSubtenantLightThemeColorListOptions, SubtenantLightThemeColor> LightThemeBrandingColors(string id, IAccountSubtenantLightThemeColorListOptions options = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", id }, };
                if (options == null)
                {
                    options = new AccountSubtenantLightThemeColorListOptions();
                }

                Func<IAccountSubtenantLightThemeColorListOptions, Task<ResponsePage<SubtenantLightThemeColor>>> paginatedFunc = async (IAccountSubtenantLightThemeColorListOptions _options) => { return await Client.CallApi<ResponsePage<SubtenantLightThemeColor>>(path: "/v3/accounts/{account_id}/branding-colors/light", pathParams: pathParams, method: HttpMethods.GET); };
                return new PaginatedResponse<IAccountSubtenantLightThemeColorListOptions, SubtenantLightThemeColor>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<IAccountSubtenantLightThemeImageListOptions, SubtenantLightThemeImage> LightThemeBrandingImages(string id, IAccountSubtenantLightThemeImageListOptions options = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", id }, };
                if (options == null)
                {
                    options = new AccountSubtenantLightThemeImageListOptions();
                }

                Func<IAccountSubtenantLightThemeImageListOptions, Task<ResponsePage<SubtenantLightThemeImage>>> paginatedFunc = async (IAccountSubtenantLightThemeImageListOptions _options) => { return await Client.CallApi<ResponsePage<SubtenantLightThemeImage>>(path: "/v3/accounts/{account_id}/branding-images/light", pathParams: pathParams, method: HttpMethods.GET); };
                return new PaginatedResponse<IAccountSubtenantLightThemeImageListOptions, SubtenantLightThemeImage>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<IAccountListOptions, Account> List(IAccountListOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new AccountListOptions();
                }

                Func<IAccountListOptions, Task<ResponsePage<Account>>> paginatedFunc = async (IAccountListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "format", _options.Format }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, { "properties", _options.Properties }, { "status__eq", _options.Filter.GetEncodedValue("status", "$eq") }, { "status__in", _options.Filter.GetEncodedValue("status", "$in") }, { "status__nin", _options.Filter.GetEncodedValue("status", "$nin") }, { "tier__eq", _options.Filter.GetEncodedValue("tier", "$eq") }, { "parent__eq", _options.Filter.GetEncodedValue("parent", "$eq") }, { "end_market__eq", _options.Filter.GetEncodedValue("end_market", "$eq") }, { "country__like", _options.Filter.GetEncodedValue("country", "$like") }, }; return await Client.CallApi<ResponsePage<Account>>(path: "/v3/accounts", queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<IAccountListOptions, Account>(paginatedFunc, options);
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

        public async Task<Account> Read(string id, string include = null, string properties = null)
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

        public PaginatedResponse<IAccountSubtenantTrustedCertificateListOptions, SubtenantTrustedCertificate> TrustedCertificates(string id, IAccountSubtenantTrustedCertificateListOptions options = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", id }, };
                if (options == null)
                {
                    options = new AccountSubtenantTrustedCertificateListOptions();
                }

                Func<IAccountSubtenantTrustedCertificateListOptions, Task<ResponsePage<SubtenantTrustedCertificate>>> paginatedFunc = async (IAccountSubtenantTrustedCertificateListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, { "name__eq", _options.Filter.GetEncodedValue("name", "$eq") }, { "service__eq", _options.Filter.GetEncodedValue("service", "$eq") }, { "expire__eq", _options.Filter.GetEncodedValue("expire", "$eq") }, { "device_execution_mode__eq", _options.Filter.GetEncodedValue("device_execution_mode", "$eq") }, { "device_execution_mode__neq", _options.Filter.GetEncodedValue("device_execution_mode", "$neq") }, { "owner__eq", _options.Filter.GetEncodedValue("owner", "$eq") }, { "enrollment_mode__eq", _options.Filter.GetEncodedValue("enrollment_mode", "$eq") }, { "status__eq", _options.Filter.GetEncodedValue("status", "$eq") }, { "issuer__like", _options.Filter.GetEncodedValue("issuer", "$like") }, { "subject__like", _options.Filter.GetEncodedValue("subject", "$like") }, { "valid__eq", _options.Filter.GetEncodedValue("valid", "$eq") }, }; return await Client.CallApi<ResponsePage<SubtenantTrustedCertificate>>(path: "/v3/accounts/{account_id}/trusted-certificates", pathParams: pathParams, queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<IAccountSubtenantTrustedCertificateListOptions, SubtenantTrustedCertificate>(paginatedFunc, options);
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
                return await Client.CallApi<Account>(path: "/v3/accounts/{account_id}", pathParams: pathParams, bodyParams: bodyParams, objectToUnpack: request, method: HttpMethods.PUT);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<IAccountSubtenantUserInvitationListOptions, SubtenantUserInvitation> UserInvitations(string id, IAccountSubtenantUserInvitationListOptions options = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", id }, };
                if (options == null)
                {
                    options = new AccountSubtenantUserInvitationListOptions();
                }

                Func<IAccountSubtenantUserInvitationListOptions, Task<ResponsePage<SubtenantUserInvitation>>> paginatedFunc = async (IAccountSubtenantUserInvitationListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "limit", _options.Limit }, { "order", _options.Order }, { "login_profiles__eq", _options.Filter.GetEncodedValue("login_profiles", "$eq") }, }; return await Client.CallApi<ResponsePage<SubtenantUserInvitation>>(path: "/v3/accounts/{account_id}/user-invitations", pathParams: pathParams, queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<IAccountSubtenantUserInvitationListOptions, SubtenantUserInvitation>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<IAccountSubtenantUserListOptions, SubtenantUser> Users(string id, IAccountSubtenantUserListOptions options = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", id }, };
                if (options == null)
                {
                    options = new AccountSubtenantUserListOptions();
                }

                Func<IAccountSubtenantUserListOptions, Task<ResponsePage<SubtenantUser>>> paginatedFunc = async (IAccountSubtenantUserListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, { "email__eq", _options.Filter.GetEncodedValue("email", "$eq") }, { "status__eq", _options.Filter.GetEncodedValue("status", "$eq") }, { "status__in", _options.Filter.GetEncodedValue("status", "$in") }, { "status__nin", _options.Filter.GetEncodedValue("status", "$nin") }, { "login_profiles__eq", _options.Filter.GetEncodedValue("login_profiles", "$eq") }, }; return await Client.CallApi<ResponsePage<SubtenantUser>>(path: "/v3/accounts/{account_id}/users", pathParams: pathParams, queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<IAccountSubtenantUserListOptions, SubtenantUser>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}