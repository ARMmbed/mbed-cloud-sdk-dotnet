using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MbedCloudSDK.Connect.Model.ConnectedDevice;
using MbedCloudSDK.Connect.Model.Subscription;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using MbedCloudSDK.Common;
using MbedCloudSDK.Exceptions;
using Mbed.Cloud;
using System.Linq.Expressions;
using MbedCloudSDK.Common.Extensions;
using Mbed.Cloud.Common;
using Mbed.Cloud.Common.CustomSerializers;
using Mbed.Cloud.Common.Filters;
using System.IO;
using Newtonsoft.Json.Converters;

namespace MbedCloudSDK.IntegrationTests.Models
{
    public class Method
    {
        public string Name { get; set; }
        public string Entity { get; set; }
        public MethodInfo MethodInfo { get; set; }

        public Method(string name, string entity, MethodInfo methodInfo)
        {
            Name = name;
            Entity = entity;
            MethodInfo = methodInfo;
        }

        public object Call(object myInstance, Dictionary<string, object> parameters = null)
        {
            return CallMethod(myInstance, MethodInfo, parameters);
        }

        private object CallMethod(object instance, MethodInfo methodInfo, Dictionary<string, object> args = null)
        {
            var argsJsonObj = new JObject();
            if (args != null)
            {
                var y = (Char.ToLowerInvariant(Entity[0]) + Entity.Substring(1)).CamelToSnake();
                var idKey = args.Keys.FirstOrDefault(k => k.StartsWith(y) && k.EndsWith("id"));
                if (idKey != null)
                {
                    // pop id
                    args.Add("id", args[idKey]);
                    args.Remove(idKey);
                }
                var camelDict = TestServer.Utils.SnakeToCamelDict(args);
                var argsJson = JsonConvert.SerializeObject(camelDict, GetDateSettings());
                argsJsonObj = JObject.Parse(argsJson);
            }

            try
            {
                var @params = GetMethodParams(methodInfo, argsJsonObj);
                object invokedMethod = null;
                if (IsAsyncMethod(methodInfo))
                {
                    var resultTask = methodInfo.Invoke(instance, @params.ToArray());

                    if (methodInfo.ReturnType.Name == "Task")
                    {
                        // return type is void
                        var runSyncVoid = typeof(AsyncHelper).GetMethods()
                                                         .FirstOrDefault(m => m.Name == "RunSyncWrapVoid");
                        invokedMethod = runSyncVoid.Invoke(null, new[] { resultTask });
                    }
                    else
                    {
                        var returnType = methodInfo.ReturnType.GenericTypeArguments.FirstOrDefault();
                        var runSync = typeof(AsyncHelper).GetMethods()
                                                         .FirstOrDefault(m => m.Name == "RunSyncWrap");
                        var genericRunSync = runSync.MakeGenericMethod(returnType);

                        invokedMethod = genericRunSync.Invoke(null, new[] { resultTask });
                    }
                }
                else
                {
                    invokedMethod = methodInfo.Invoke(instance, @params.ToArray());
                }

                if (invokedMethod != null)
                {
                    if (invokedMethod.GetType() == typeof(AsyncConsumer<string>))
                    {
                        var asyncConsumer = invokedMethod as AsyncConsumer<string>;
                        return asyncConsumer.ToString();
                    }
                    // if (invokedMethod.GetType().GetProperties().Select(p => p.Name).Contains("DeviceFilter"))
                    // {
                    //     var returnedJson = JObject.FromObject(invokedMethod);
                    //     var tempJson = new JObject();

                    //     var deviceFilter = returnedJson["DeviceFilter"];
                    //     returnedJson.Remove("DeviceFilter");
                    //     returnedJson.Add("DeviceFilter", JObject.FromObject(deviceFilter["FilterJson"]));

                    //     foreach (var row in returnedJson)
                    //     {
                    //         tempJson.Add(TestServer.Utils.CamelToSnake(row.Key), row.Value);
                    //     }

                    //     return tempJson;
                    // }
                    if (methodInfo.ReturnType.Name.StartsWith("PaginatedResponse"))
                    {
                        // if return type is a paginator, return the data property which ca
                        var listResponse = methodInfo.ReturnType.GetMethod("All").Invoke(invokedMethod, null);
                        var serializedResult = JsonConvert.SerializeObject(listResponse, Formatting.Indented, GetSerializerSettings());
                        return JsonConvert.DeserializeObject(serializedResult, GetDeserializerSettings());
                    }
                    if (invokedMethod.GetType() == typeof(FileStream))
                    {
                        var file = invokedMethod as FileStream;
                        file.Close();
                        file.Dispose();
                        return "got a file";
                    }
                }
                var result = JsonConvert.SerializeObject(invokedMethod, Formatting.Indented, GetSerializerSettings());
                if (result == null || result == "null")
                {
                    return null;
                }

                return JsonConvert.DeserializeObject(result, GetDeserializerSettings());
            }
            catch (TargetInvocationException e)
            {
                if (e.InnerException.GetType() == typeof(CloudApiException))
                {
                    throw e.InnerException as CloudApiException;
                }

                throw;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private JsonSerializerSettings GetDateSettings()
        {
            var settings = new JsonSerializerSettings()
            {
                DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffffffZ",
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            };
            return settings;
        }

        private JsonSerializerSettings GetSerializerSettings()
        {
            var settings = new JsonSerializerSettings()
            {
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            };
            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy(),
            };
            settings.ContractResolver = contractResolver;
            settings.Converters.Add(new StringEnumConverter());
            return settings;
        }

        private JsonSerializerSettings GetDeserializerSettings()
        {
            var settings = new JsonSerializerSettings()
            {
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            };
            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy(),
            };
            settings.ContractResolver = contractResolver;
            settings.Converters.Add(new TolerantEnumConverter());
            return settings;
        }

        private List<Object> GetMethodParams(MethodInfo methodInfo, JObject argsJsonObj)
        {
            var @params = methodInfo.GetParameters();
            var serialisedParams = new List<object>();
            foreach (var p in @params)
            {
                var paramType = p.ParameterType;
                if (paramType.IsInterface)
                {
                    // parameter is interface so get corresponding class
                    var interfaceType = Assembly.GetAssembly(typeof(SDK)).GetTypes().FirstOrDefault(t => paramType.IsAssignableFrom(t) && !t.IsInterface);
                    if (interfaceType != null)
                    {
                        paramType = interfaceType;
                    }
                }

                if (paramType.IsPrimitive || paramType == typeof(String))
                {
                    var paramValue = GetParamValuePrimitive(p, paramType, argsJsonObj);
                    if (paramValue != null)
                    {
                        serialisedParams.Add(paramValue);
                    }
                }
                else if (paramType == typeof(DateTime))
                {
                    var val = argsJsonObj[p.Name.ToUpper()].Value<string>();
                    var isDate = DateTime.TryParseExact(val, "MM/dd/yyyy HH:mm:ss", null, DateTimeStyles.None, out DateTime dateValue);
                    if (isDate)
                    {
                        var dateWithMilli = argsJsonObj[p.Name.ToUpper()].Value<DateTime>();
                        serialisedParams.Add(dateWithMilli);
                    }
                    else
                    {
                        serialisedParams.Add(null);
                    }
                }
                else if (paramType == typeof(Stream))
                {
                    var filePath = argsJsonObj[p.Name.ToUpper()].Value<string>();
                    var fs = File.OpenRead(filePath);
                    serialisedParams.Add(fs);
                }
                else
                {
                    var properties = paramType.GetProperties();
                    var vals = new JObject();
                    foreach (var prop in properties)
                    {
                        var propertyInst = paramType.GetProperty(prop.Name);
                        if (propertyInst != null)
                        {
                            if (propertyInst.PropertyType.Name == "Filter")
                            {
                                if (propertyInst.Name == "DeviceFilterHelper")
                                {
                                    vals[propertyInst.Name] = null;
                                }
                                else
                                {
                                    var filterJson = GetParamValue(propertyInst, argsJsonObj);
                                    var filterJsonString = filterJson != null ? filterJson.ToString() : "";
                                    var filterJToken = JToken.FromObject(new Filter(filterJsonString, p));
                                    vals[propertyInst.Name] = filterJToken;
                                }
                            }
                            else if (propertyInst.PropertyType == typeof(List<string>))
                            {
                                var paramValue = GetParamValue(propertyInst, argsJsonObj);
                                if (paramValue != null)
                                {
                                    var list = JsonConvert.DeserializeObject<List<string>>(paramValue.ToString());
                                    vals[propertyInst.Name] = JToken.FromObject(list);
                                }
                                else
                                {
                                    vals[propertyInst.Name] = paramValue;
                                }
                            }
                            else
                            {
                                var paramValue = GetParamValue(propertyInst, argsJsonObj);
                                if (paramValue != null)
                                {
                                    vals[propertyInst.Name] = paramValue;
                                }
                            }
                        }
                    }
                    try
                    {
                        var obj = JsonConvert.DeserializeObject(vals.ToString(), paramType);
                        serialisedParams.Add(obj);
                    }
                    catch (JsonReaderException)
                    {
                        serialisedParams.Add(null);
                    }
                }
            }

            if (serialisedParams.Count < @params.Length)
            {
                while (serialisedParams.Count < @params.Length)
                {
                    serialisedParams.Add(Type.Missing);
                }
            }
            return serialisedParams;
        }

        private JToken GetParamValue(PropertyInfo propertyInst, JObject argsJsonObj)
        {
            var valFromArgsProp = argsJsonObj[propertyInst.Name.ToUpper()];
            if (valFromArgsProp != null)
            {
                return valFromArgsProp;
            }

            return null;
        }

        private object GetParamValuePrimitive(ParameterInfo p, Type paramType, JObject argsJsonObj)
        {
            var obj = argsJsonObj[p.Name.ToUpper()] as JValue;

            // if obj is nested obj
            if (obj == null)
            {
                var token = argsJsonObj[p.Name.ToUpper()] as JToken;
                if (token != null)
                    return token.ToString();
            }

            if (obj != null)
            {
                if (paramType == typeof(int))
                {
                    return Convert.ToInt32(obj.Value);
                }
                else
                {
                    return obj.Value;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Handy IsAsyncMethod taken from https://stackoverflow.com/questions/20350397/how-can-i-tell-if-a-c-sharp-method-is-async-await-via-reflection
        /// </summary>
        private static bool IsAsyncMethod(MethodInfo method)
        {
            Type attType = typeof(AsyncStateMachineAttribute);

            // Obtain the custom attribute for the method.
            // The value returned contains the StateMachineType property.
            // Null is returned if the attribute isn't present for the method.
            var attrib = (AsyncStateMachineAttribute)method.GetCustomAttribute(attType);

            return (attrib != null);
        }
    }
}