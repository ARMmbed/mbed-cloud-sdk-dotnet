// <copyright file="AccountManagementApi.Account.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
namespace MbedCloudSDK.AccountAdmin.AccountGroup
{
    using MbedCloudSDK.Common;
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using MbedCloudSDK.Client;
    using MbedCloudSDK.Exceptions;
    using RestSharp;
    using MbedCloudSDK.Common.Extensions;

    /// <summary>
    /// AccountGroup
    /// </summary>
    public partial class AccountGroup : BaseModel
    {
        /// <summary>
        /// The UUID of the account this group belongs to.
        /// </summary>
        public string AccountId
        {
            get;
            set;
        }

        /// <summary>
        /// The number of API keys in this group.
        /// </summary>
        public int ApikeyCount
        {
            get;
            set;
        }

        /// <summary>
        /// Response code.
        /// </summary>
        public int Code
        {
            get;
            set;
        }

        /// <summary>
        /// Creation UTC time RFC3339.
        /// </summary>
        public DateTime CreatedAt
        {
            get;
            set;
        }

        /// <summary>
        /// A human readable message with detailed info.
        /// </summary>
        public string Message
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the group.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Request ID.
        /// </summary>
        public string RequestId
        {
            get;
            set;
        }

        /// <summary>
        /// Response type: success.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountGroupTypeEnum Type
        {
            get;
            set;
        }

        /// <summary>
        /// Last update UTC time RFC3339.
        /// </summary>
        public DateTime UpdatedAt
        {
            get;
            set;
        }

        /// <summary>
        /// The number of users in this group.
        /// </summary>
        public int UserCount
        {
            get;
            set;
        }

        public async Task<AccountGroup> Read()
        {
            var renames = new Dictionary<string, string>();
            try
            {
                return await MbedCloudSDK.Client.ApiCall.CallApi<AccountGroup>(path: "/v3/policy-groups/{groupID}", method: Method.GET, pathParams: new Dictionary<string, object>()
                {}, configuration: Config);
            }
            catch (MbedCloudSDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<AccountGroup> Update()
        {
            var renames = new Dictionary<string, string>();
            try
            {
                return await MbedCloudSDK.Client.ApiCall.CallApi<AccountGroup>(path: "/v3/policy-groups/{groupID}", method: Method.PUT, pathParams: new Dictionary<string, object>()
                {}, configuration: Config);
            }
            catch (MbedCloudSDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        /// <summary>
        /// Get human readable string of this object
        /// </summary>
        /// <returns>Serialized string of object</returns>
        public override string ToString() => this.DebugDump();
    }
}