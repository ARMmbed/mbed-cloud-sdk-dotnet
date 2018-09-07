// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 1.0.0
//
// <copyright file="Renames.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace MbedCloudSDK.Common.Renames
{
    using System;
    using System.Collections.Generic;

    public static class Renames
    {
        public static Dictionary<Type, Dictionary<string, string>> RenamesDict = new Dictionary<Type, Dictionary<string, string>> { { typeof(MbedCloudSDK.Entities.ApiKey.ApiKey), new Dictionary<string, string> { { "GroupIds", "groups" }, } }, { typeof(MbedCloudSDK.Entities.LoginHistory.LoginHistory), new Dictionary<string, string> { } }, { typeof(MbedCloudSDK.Entities.MyAccount.MyAccount), new Dictionary<string, string> { } }, { typeof(MbedCloudSDK.Entities.PasswordPolicy.PasswordPolicy), new Dictionary<string, string> { } }, { typeof(MbedCloudSDK.Entities.PolicyGroup.PolicyGroup), new Dictionary<string, string> { } }, { typeof(MbedCloudSDK.Entities.SubtenantAccount.SubtenantAccount), new Dictionary<string, string> { } }, { typeof(MbedCloudSDK.Entities.User.User), new Dictionary<string, string> { { "GroupIds", "groups" }, { "MarketingAccepted", "is_marketing_accepted" }, { "TermsAccepted", "is_gtc_accepted" }, { "TwoFactorAuthentication", "is_totp_enabled" }, } }, };
    }
}