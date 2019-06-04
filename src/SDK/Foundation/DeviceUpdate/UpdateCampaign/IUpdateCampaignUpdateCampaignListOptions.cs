// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="IUpdateCampaignUpdateCampaignListOptions.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Common.Filters;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// UpdateCampaignUpdateCampaignListOptions
    /// </summary>
    public interface IUpdateCampaignUpdateCampaignListOptions : IQueryOptions
    {
        /// <summary>
        /// Filter object
        /// </summary>
        Filter Filter
        {
            get;
            set;
        }

        UpdateCampaignUpdateCampaignListOptions CreatedAtIn(params DateTime[] value);
        UpdateCampaignUpdateCampaignListOptions CreatedAtNotIn(params DateTime[] value);
        UpdateCampaignUpdateCampaignListOptions CreatedAtLessThan(DateTime value);
        UpdateCampaignUpdateCampaignListOptions CreatedAtGreaterThan(DateTime value);
        UpdateCampaignUpdateCampaignListOptions DescriptionEqualTo(string value);
        UpdateCampaignUpdateCampaignListOptions DescriptionNotEqualTo(string value);
        UpdateCampaignUpdateCampaignListOptions DescriptionIn(params string[] value);
        UpdateCampaignUpdateCampaignListOptions DescriptionNotIn(params string[] value);
        UpdateCampaignUpdateCampaignListOptions DeviceFilterEqualTo(string value);
        UpdateCampaignUpdateCampaignListOptions DeviceFilterNotEqualTo(string value);
        UpdateCampaignUpdateCampaignListOptions DeviceFilterIn(params string[] value);
        UpdateCampaignUpdateCampaignListOptions DeviceFilterNotIn(params string[] value);
        UpdateCampaignUpdateCampaignListOptions FinishedIn(params DateTime[] value);
        UpdateCampaignUpdateCampaignListOptions FinishedNotIn(params DateTime[] value);
        UpdateCampaignUpdateCampaignListOptions FinishedLessThan(DateTime value);
        UpdateCampaignUpdateCampaignListOptions FinishedGreaterThan(DateTime value);
        UpdateCampaignUpdateCampaignListOptions IdEqualTo(string value);
        UpdateCampaignUpdateCampaignListOptions IdNotEqualTo(string value);
        UpdateCampaignUpdateCampaignListOptions IdIn(params string[] value);
        UpdateCampaignUpdateCampaignListOptions IdNotIn(params string[] value);
        UpdateCampaignUpdateCampaignListOptions NameEqualTo(string value);
        UpdateCampaignUpdateCampaignListOptions NameNotEqualTo(string value);
        UpdateCampaignUpdateCampaignListOptions NameIn(params string[] value);
        UpdateCampaignUpdateCampaignListOptions NameNotIn(params string[] value);
        UpdateCampaignUpdateCampaignListOptions RootManifestIdEqualTo(string value);
        UpdateCampaignUpdateCampaignListOptions RootManifestIdNotEqualTo(string value);
        UpdateCampaignUpdateCampaignListOptions RootManifestIdIn(params string[] value);
        UpdateCampaignUpdateCampaignListOptions RootManifestIdNotIn(params string[] value);
        UpdateCampaignUpdateCampaignListOptions StartedAtIn(params DateTime[] value);
        UpdateCampaignUpdateCampaignListOptions StartedAtNotIn(params DateTime[] value);
        UpdateCampaignUpdateCampaignListOptions StartedAtLessThan(DateTime value);
        UpdateCampaignUpdateCampaignListOptions StartedAtGreaterThan(DateTime value);
        UpdateCampaignUpdateCampaignListOptions StateEqualTo(string value);
        UpdateCampaignUpdateCampaignListOptions StateNotEqualTo(string value);
        UpdateCampaignUpdateCampaignListOptions StateIn(params string[] value);
        UpdateCampaignUpdateCampaignListOptions StateNotIn(params string[] value);
        UpdateCampaignUpdateCampaignListOptions UpdatedAtIn(params DateTime[] value);
        UpdateCampaignUpdateCampaignListOptions UpdatedAtNotIn(params DateTime[] value);
        UpdateCampaignUpdateCampaignListOptions UpdatedAtLessThan(DateTime value);
        UpdateCampaignUpdateCampaignListOptions UpdatedAtGreaterThan(DateTime value);
        UpdateCampaignUpdateCampaignListOptions WhenIn(params DateTime[] value);
        UpdateCampaignUpdateCampaignListOptions WhenNotIn(params DateTime[] value);
        UpdateCampaignUpdateCampaignListOptions WhenLessThan(DateTime value);
        UpdateCampaignUpdateCampaignListOptions WhenGreaterThan(DateTime value);
    }
}