using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp.Extensions.MonoHttp;

namespace MbedCloudSDK.Common.Filter
{
    public class Filter
    {
        /// <summary>
        /// Prefix for custom attributes.
        /// </summary>
        public static readonly string CustomAttributesPrefix = "custom_attributes__";
        public string FilterString { get{
                if (FilterDictionary.Any())
                {
                    return String.Join("&", FilterDictionary?.Select(q => $"{q.Key}{q.Value.GetSuffix()}={q.Value.Value}"));
                }
                return "";
            }
        }

        public Dictionary<string, FilterAttribute> FilterDictionary { get; set; }

        public JObject FilterJson { get; set; }

        public Filter()
        {
            FilterJson = new JObject();
            FilterDictionary = new Dictionary<string, FilterAttribute>();
        }

        public Filter(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (Utils.IsValidJson(value))
                {
                    FilterJson = stringToJsonObject(value);
                    FilterDictionary = ParseFilterJsonString(value);
                }
                else
                {
                    FilterJson = stringToJsonObject(QueryStringToJson(value));
                    FilterDictionary = ParseFilterJsonString(FilterJson.ToString());
                }
            }
            else
            {
                FilterJson = new JObject();
                FilterDictionary = new Dictionary<string, FilterAttribute>();
            }
        }

        public Filter QueryStringToFilter(string queryString)
        {
            var x = QueryStringToJson(queryString);
            FilterJson = stringToJsonObject(x);
            FilterDictionary = ParseFilterJsonString(x);
            return this;
        }

        private JObject stringToJsonObject(string jsonString)
        {
            return JObject.Parse(jsonString);
        }
        
        private Dictionary<string, FilterAttribute> ParseFilterJsonString(string attributeString)
        {
            var decodedString = HttpUtility.UrlDecode(attributeString).Replace("u'", "\"").Replace("'", "\"");
            var customAttributes = new Dictionary<string, FilterAttribute>();
            var json = JsonConvert.DeserializeObject<Dictionary<string, JObject>>(decodedString);
            if (json.Keys.Contains("custom_attributes"))
            {
                var f = json["custom_attributes"].ToString(Formatting.None);
                customAttributes = ParseFilterJsonString(f);
                json.Remove("custom_attributes");
            }
            var dict = json.ToDictionary(k => k.Key, k => parseVal(k.Value));
            if (customAttributes.Any())
            {
                customAttributes.ToList().ForEach(d => dict.Add($"custom_attributes__{d.Key}", d.Value));
            }
            return dict;
        }

        private static FilterAttribute parseVal(JObject val)
        {
            var oper = val.First as JProperty;
            var operName = oper.Name;
            var operValue = val.First.First.Value<string>();
            var queryAttribute = new FilterAttribute(operValue, ParseQueryOperator(operName));
            return queryAttribute;
        }

        public static FilterOperator ParseQueryOperator(string val)
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

        public static string QueryOperatorToString(FilterOperator queryOperator)
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

        public static string QueryStringToJson(string queryString)
        {
            queryString = HttpUtility.UrlDecode(queryString).Replace("u'", "\"").Replace("'", "\"");
            var dict = new Dictionary<string, FilterAttribute>();
            var split = queryString.Split('&');
            foreach (var b in split)
            {
                var keyValue = b.Split('=');
                var val = keyValue[1];
                var key = keyValue[0];
                var oper = FilterOperator.Equals;

                if (key.Contains("neq"))
                {
                    key = key.Replace("neq", "");
                    oper = FilterOperator.NotEqual;
                }
                if (key.Contains("ltq"))
                {
                    key = key.Replace("ltq", "");
                    oper = FilterOperator.LessOrEqual;
                }
                if (key.Contains("gtq"))
                {
                    key = key.Replace("gtq", "");
                    oper = FilterOperator.GreaterOrEqual;
                }

                var queryAttribute = new FilterAttribute(val, oper);
                dict.Add(key, queryAttribute);
            }
            var json = new JObject();
            foreach (var kv in dict)
            {
                var innerJson = new JObject();
                innerJson[QueryOperatorToString(kv.Value.FilterOperator)] = kv.Value.Value;
                json[kv.Key] = innerJson;
            }
            return json.ToString(Formatting.None);
        }



/* 
        get {
                if (this.queryString != null)
                {
            try
            {
                var attributeDictionary = Utils.ParseAttributeString(this.queryString);
                var queryString = String.Join("&", attributeDictionary.Select(q => $"{q.Key}{q.Value.GetSuffix()}={q.Value.Value}"));
                return queryString;
            }
            catch (Exception e)
            {
                return queryString;
            }
        }
                return null;
        }
        set {
                queryString = value;
                // Set attributes and custom attributes
                
                Attributes = new Dictionary<string, string>();
                CustomAttributes = new Dictionary<string, string>();
                string[] substrings = queryString.Split('&');
                if (substrings != null)
                {
                    foreach (var substring in substrings)
                    {
                        string[] att = substring.Split('=');
                        if (att.Length == 2)
                        {
                            if (att[0].StartsWith(Query.CustomAttributesPrefix))
                            {
                                CustomAttributes.Add(att[0].Replace(Query.CustomAttributesPrefix, string.Empty), att[1]);
                            }
                            else
                            {
                                Attributes.Add(att[0], att[1]);
                            }
                        }
                    }
                }
                
            }
            */
    }
}