// <copyright file="CampaignStateEnumConverter.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>

using System;
using MbedCloudSDK.Common;
using Newtonsoft.Json;

namespace MbedCloudSDK.Update.Model.Campaign
{
    public class CampaignStateEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var enumString = (string)reader.Value;
            return Utils.GetEnumMemberValue(typeof(CampaignStateEnum), enumString);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var campaignStateEnum = (CampaignStateEnum)value;
            writer.WriteValue(Utils.GetEnumMemberValue(typeof(CampaignStateEnum), campaignStateEnum.ToString()));
        }
    }
}