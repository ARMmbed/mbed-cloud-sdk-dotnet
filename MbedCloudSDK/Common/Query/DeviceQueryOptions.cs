﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MbedCloudSDK.Common.Query
{
    /// <summary>
    /// Query options used in DeviceDirectory API.
    /// </summary>
    public class DeviceQueryOptions: QueryOptions
    {
        /// <summary>
        /// Get Query String.
        /// </summary>
        public override string QueryString
        {
            get
            {
                string attributes = Attributes != null ?  string.Join("&", Attributes.Select(q => $"{q.Key}{q.Value.GetSuffix()}={q.Value.Value}")) : string.Empty;
                if (CustomAttributes != null)
                {
                    return Uri.UnescapeDataString(string.Join("&", attributes, CustomAttributes));
                }
                return attributes;
            }
        }

        /// <summary>
        /// Get or Set custom attributes.
        /// </summary>
        public Dictionary<string, QueryAttribute> CustomAttributes { get; set; }

        /// <summary>
        /// Create new instance of Device query options.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after"></param>
        /// <param name="include"></param>
        /// <param name="attributes"></param>
        /// <param name="customAttributes"></param>
        public DeviceQueryOptions(int? limit = null, string order = null, string after = null, string include = null, 
            Dictionary<string, QueryAttribute> attributes = null, Dictionary<string, QueryAttribute> customAttributes = null) : 
            base(limit, order, after, include, attributes)
        {
            this.CustomAttributes = customAttributes;
        }
    }
}