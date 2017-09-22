// <copyright file="Filter.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>

namespace MbedCloudSDK.Common.Filter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using RestSharp.Extensions.MonoHttp;

    /// <summary>
    /// Filter object
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// Prefix for custom attributes.
        /// </summary>
        public static readonly string CustomAttributesPrefix = "custom_attributes__";

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter"/> class.
        /// Default constructor
        /// </summary>
        public Filter()
        {
            FilterJson = new JObject();
            FilterDictionary = new Dictionary<string, FilterAttribute>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter"/> class.
        /// Create new filter object from json or query string
        /// </summary>
        /// <param name="value">Json or query string.</param>
        /// <param name="isBlank">If true, Filter will not be mapped during update</param>
        public Filter(string value, bool isBlank = false)
        {
            IsBlank = isBlank;
            if (!string.IsNullOrEmpty(value))
            {
                if (Utils.IsValidJson(value))
                {
                    FilterJson = StringToJsonObject(value);
                    FilterDictionary = QueryJsonToDictionary(value);
                }
                else
                {
                    FilterJson = StringToJsonObject(QueryStringToJson(value));
                    FilterDictionary = QueryJsonToDictionary(Convert.ToString(FilterJson));
                }
            }
            else
            {
                FilterJson = new JObject();
                FilterDictionary = new Dictionary<string, FilterAttribute>();
            }
        }

        /// <summary>
        /// Gets string representation of Filter.
        /// </summary>
        public string FilterString
        {
            get
            {
                if (FilterDictionary.Any())
                {
                    return string.Join("&", FilterDictionary?.Select(q => $"{q.Key}{q.Value.GetSuffix()}={q.Value.Value}"));
                }

                return string.Empty;
            }
        }

        /// <summary>
        /// Gets dictionary containing key-value pairs of filters
        /// </summary>
        [JsonProperty]
        public Dictionary<string, FilterAttribute> FilterDictionary { get; private set; }

        /// <summary>
        /// Gets json representation of filter
        /// </summary>
        [JsonProperty]
        public JObject FilterJson { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether if true, filter will not be mapped during an update
        /// </summary>
        public bool IsBlank { get; set; }

        /// <summary>
        /// Add new query to filter
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        /// <param name="filterOperator">Operator, Equals if not provided</param>
        public void Add(string key, string value, FilterOperator filterOperator = FilterOperator.Equals)
        {
            try
            {
                var filterAttribute = new FilterAttribute(value, filterOperator);
                FilterDictionary.Remove(key);
                FilterDictionary.Add(key, filterAttribute);
                var prop = new JProperty(key, JObject.FromObject(filterAttribute));
                FilterJson.Add(prop);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static FilterAttribute GetQueryAttribute(JObject val)
        {
            var oper = val.First as JProperty;
            var operName = oper.Name;
            var operValue = val.First.First.Value<string>();
            var queryAttribute = new FilterAttribute(operValue, QueryOperatorToEnum(operName));
            return queryAttribute;
        }

        private static FilterOperator QueryOperatorToEnum(string val)
        {
            switch (val)
            {
                case "$eq":
                    return FilterOperator.Equals;
                case "$neq":
                    return FilterOperator.NotEqual;
                case "$lte":
                    return FilterOperator.LessOrEqual;
                case "$gte":
                    return FilterOperator.GreaterOrEqual;
                default:
                    return FilterOperator.Equals;
            }
        }

        private static string QueryOperatorToString(FilterOperator queryOperator)
        {
            switch (queryOperator)
            {
                case FilterOperator.Equals:
                    return "$eq";
                case FilterOperator.NotEqual:
                    return "$neq";
                case FilterOperator.LessOrEqual:
                    return "$lte";
                case FilterOperator.GreaterOrEqual:
                    return "$gte";
                default:
                    return "$eq";
            }
        }

        private static string QueryStringToJson(string queryString)
        {
            queryString = HttpUtility.UrlDecode(queryString).Replace("u'", "\"").Replace("'", "\"");
            var dict = new Dictionary<string, FilterAttribute>();
            var split = queryString.Split('&');
            foreach (var part in split)
            {
                var keyValue = part.Split('=');
                if (keyValue.Length == 2)
                {
                    var val = keyValue[1];
                    var key = keyValue[0];
                    var oper = FilterOperator.Equals;

                    if (key.Contains("neq"))
                    {
                        key = key.Replace("neq", string.Empty);
                        oper = FilterOperator.NotEqual;
                    }

                    if (key.Contains("ltq"))
                    {
                        key = key.Replace("ltq", string.Empty);
                        oper = FilterOperator.LessOrEqual;
                    }

                    if (key.Contains("gtq"))
                    {
                        key = key.Replace("gtq", string.Empty);
                        oper = FilterOperator.GreaterOrEqual;
                    }

                    var queryAttribute = new FilterAttribute(val, oper);
                    dict.Add(key, queryAttribute);
                }
            }

            var json = new JObject();
            foreach (var kv in dict)
            {
                var innerJson = new JObject
                {
                    [QueryOperatorToString(kv.Value.FilterOperator)] = kv.Value.Value
                };
                json[kv.Key] = innerJson;
            }

            return json.ToString(Formatting.None);
        }

        private static JObject StringToJsonObject(string jsonString)
        {
            return JObject.Parse(jsonString);
        }

        private Filter QueryStringToFilter(string queryString)
        {
            var queryJsonString = QueryStringToJson(queryString);
            FilterJson = StringToJsonObject(queryJsonString);
            FilterDictionary = QueryJsonToDictionary(queryJsonString);
            return this;
        }

        private Dictionary<string, FilterAttribute> QueryJsonToDictionary(string queryJson)
        {
            var decodedString = HttpUtility.UrlDecode(queryJson).Replace("u'", "\"").Replace("'", "\"");
            var customAttributes = new Dictionary<string, FilterAttribute>();
            if (Utils.IsValidJson(decodedString))
            {
                var json = JsonConvert.DeserializeObject<Dictionary<string, JObject>>(decodedString);
                if (json.Keys.Contains("custom_attributes"))
                {
                    var customAttributeJson = json["custom_attributes"].ToString(Formatting.None);
                    customAttributes = QueryJsonToDictionary(customAttributeJson);
                    json.Remove("custom_attributes");
                }

                var dict = json.ToDictionary(k => k.Key, k => GetQueryAttribute(k.Value));
                if (customAttributes.Any())
                {
                    customAttributes.ToList().ForEach(d => dict.Add($"{CustomAttributesPrefix}{d.Key}", d.Value));
                }

                return dict;
            }

            return new Dictionary<string, FilterAttribute>();
        }
    }
}