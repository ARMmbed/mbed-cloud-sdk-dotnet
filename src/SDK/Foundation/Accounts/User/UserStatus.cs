// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="UserStatus.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation.Enums
{
    using System.Runtime.Serialization;

    public enum UserStatus
    {
        [EnumMember(Value = "UNKNOWN_ENUM_VALUE_RECEIVED")]
        UNKNOWN_ENUM_VALUE_RECEIVED,
        [EnumMember(Value = "ENROLLING")]
        ENROLLING,
        [EnumMember(Value = "INVITED")]
        INVITED,
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,
        [EnumMember(Value = "RESET")]
        RESET,
        [EnumMember(Value = "INACTIVE")]
        INACTIVE,
    }
}