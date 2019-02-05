using System;
using System.Collections.Generic;
using System.Linq;
using Mbed.Cloud;
using MbedCloudSDK.IntegrationTests.Foundation.Models;

namespace MbedCloudSDK.IntegrationTests.Models
{
    public class FoundationSDKInstance : Instance<SDK>, IFoundationInstance
    {
        public string Name { get; set; }
        public Dictionary<string, Method> Methods { get; set; } = new Dictionary<string, Method>();

        public FoundationSDKInstance(SDK instance) : base(instance)
        {
            Name = "Sdk";
            typeof(SDK).GetMethods()
                        .ToList()
                        .ForEach(m => {
                            Methods.Add(m.Name, new Method(m.Name, Name, m));
                        });
        }

        public FoundationInstanceResponse ToJson()
        {
            return new FoundationInstanceResponse
            {
                Id = Id,
                CreatedAt = CreatedAt,
                Entity = Name,
            };
        }

        public object ExecuteMethod(string methodId, Dictionary<string, object> parameters = null)
        {
            if (!Methods.ContainsKey(methodId))
            {
                throw new KeyNotFoundException("no such method");
            }

            var method = Methods.FirstOrDefault(m => m.Key == methodId).Value;
            if (method != null)
            {
                return method.Call(MyInstance, parameters);
            }

            return null;
        }
    }
}