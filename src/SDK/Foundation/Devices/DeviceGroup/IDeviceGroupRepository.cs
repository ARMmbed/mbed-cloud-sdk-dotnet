// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="IDeviceGroupRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Foundation;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.RestClient;

    /// <summary>
    /// DeviceGroupRepository
    /// </summary>
    public interface IDeviceGroupRepository
    {
        Task AddDevice(string id, DeviceGroup request, string deviceId = null);
        Task<DeviceGroup> Create(DeviceGroup request);
        Task Delete(string id);
        PaginatedResponse<IDeviceGroupDeviceListOptions, Device> Devices(string id, IDeviceGroupDeviceListOptions options = null);
        PaginatedResponse<IDeviceGroupListOptions, DeviceGroup> List(IDeviceGroupListOptions options = null);
        Task<DeviceGroup> Read(string id);
        Task RemoveDevice(string id, DeviceGroup request, string deviceId = null);
        Task<DeviceGroup> Update(string id, DeviceGroup request);
    }
}