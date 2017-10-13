// <copyright file="Utils.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>

namespace MbedCloudSDK.Common
{
    using System;
    using System.Linq;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Utils
    /// A set of utility functions
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Map update object to original object.
        /// </summary>
        /// <param name="origObj">Original object</param>
        /// <param name="updateObj">Update object</param>
        /// <returns>Object</returns>
        public static object MapToUpdate(object origObj, object updateObj)
        {
            var type = updateObj.GetType();
            var props = type.GetProperties();
            var newObj = Activator.CreateInstance(type);

            foreach (var prop in props)
            {
                var targetProperty = type.GetProperty(prop.Name);
                if (targetProperty.GetSetMethod(true) == null)
                {
                    continue;
                }
                else
                {
                    var val = prop.GetValue(updateObj, null);
                    if (val != null)
                    {
                        if (typeof(Filter.Filter) == val.GetType())
                        {
                            var filter = val as MbedCloudSDK.Common.Filter.Filter;
                            if (filter.IsBlank)
                            {
                                targetProperty.SetValue(newObj, prop.GetValue(origObj, null));
                            }
                            else
                            {
                                targetProperty.SetValue(newObj, val, null);
                            }
                        }
                        else
                        {
                            targetProperty.SetValue(newObj, val, null);
                        }
                    }
                    else
                    {
                        targetProperty.SetValue(newObj, prop.GetValue(origObj, null));
                    }
                }
            }

            return newObj;
        }

        /// <summary>
        /// Parse an enum
        /// </summary>
        /// <typeparam name="T">Type of Enum</typeparam>
        /// <param name="enumValue">Enum</param>
        /// <returns>Enum of type T</returns>
        public static T ParseEnum<T>(object enumValue)
            where T : struct, IComparable
        {
            var value = Convert.ToString(enumValue);
            if (string.IsNullOrEmpty(value))
            {
                return default(T);
            }

            return Enum.TryParse<T>(value, true, out T result) ? result : default(T);
        }

        /// <summary>
        /// Get string value of enum member value from enum.
        /// </summary>
        /// <param name="type">Enum type</param>
        /// <param name="value">Enum member string</param>
        /// <returns>Value of Enum member attribute</returns>
        public static string GetEnumMemberValue(Type type, string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                var memInfo = type.GetMember(value);
                if (memInfo.Any())
                {
                    var attributes = memInfo[0].GetCustomAttributes(typeof(EnumMemberAttribute), false);
                    return ((EnumMemberAttribute)attributes.FirstOrDefault()).Value;
                }
            }

            return null;
        }

        /// <summary>
        /// Get enum from enum member string
        /// </summary>
        /// <param name="type">Type of enum</param>
        /// <param name="value">Enum member string</param>
        /// <returns>Enum</returns>
        public static object GetEnumFromEnumMemberValue(Type type, string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                foreach (var name in Enum.GetNames(type))
                {
                    var attr = ((EnumMemberAttribute[])type.GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).Single();
                    if (attr.Value == value)
                    {
                        return Enum.Parse(type, name);
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Check if string is valid Json
        /// </summary>
        /// <param name="strInput">string to check</param>
        /// <returns>Bool</returns>
        public static bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) ||
                (strInput.StartsWith("[") && strInput.EndsWith("]")))
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException)
                {
                    // Exception in parsing json
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Convert snake case string to camel case
        /// </summary>
        /// <param name="input">Input</param>
        /// <param name="firstLower">If true, first letter will be lower case</param>
        /// <returns>Camel case string</returns>
        public static string SnakeToCamel(string input, bool firstLower = false)
        {
            var newString = new char[input.Length];
            var startIndex = 1;
            var newStringIndex = 1;

            if (firstLower)
            {
                newString[0] = input[0];
            }
            else
            {
                if (input[0] == '_')
                {
                    newString[0] = char.ToUpper(input[1]);
                    startIndex += 1;
                }
                else
                {
                    var firstCap = char.ToUpper(input[0]);
                    newString[0] = firstCap;
                }
            }

            for (int i = startIndex; i < input.Count(); i++)
            {
                if (input[i] == '_')
                {
                    if (i + 1 >= input.Count())
                    {
                        newString[newStringIndex] = '_';
                    }
                    else
                    {
                        newString[newStringIndex] = char.ToUpper(input[i + 1]);
                        newString[newStringIndex + 1] = ' ';
                        i++;
                        newStringIndex += 1;
                    }
                }
                else
                {
                    newString[newStringIndex] = input[i];
                }

                newStringIndex += 1;
            }

            return new string(newString.Where(c => !char.IsWhiteSpace(c) && !(c == '\0')).ToArray());
        }

        /// <summary>
        /// Wrapper method that returns camel case stirng with lowercase first letter
        /// </summary>
        /// <param name="input">Input</param>
        /// <returns>camelcase string</returns>
        public static string SnakeToLowerCamel(string input)
        {
            return SnakeToCamel(input, true);
        }

        /// <summary>
        /// Convert camelcase string to snake case
        /// </summary>
        /// <param name="input">Input</param>
        /// <returns>snake case string</returns>
        public static string CamelToSnake(string input)
        {
            return string.Concat(input.Select((x, i) =>
            {
                return (i >= 0 && char.IsUpper(x)) ? "_" + x.ToString() : x.ToString();
            })).ToLower();
        }
    }
}