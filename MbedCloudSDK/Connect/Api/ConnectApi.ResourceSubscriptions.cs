// <copyright file="ConnectApi.ResourceSubscriptions.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>

namespace MbedCloudSDK.Connect.Api
{
    using System;
    using MbedCloudSDK.Connect.Model.ConnectedDevice;
    using MbedCloudSDK.Connect.Model.Resource;
    using MbedCloudSDK.Exceptions;

    /// <summary>
    /// Connect Api
    /// </summary>
    public partial class ConnectApi
    {
        /// <summary>
        /// Subscribe to resource updates.
        /// </summary>
        /// <param name="deviceId">Id of device.</param>
        /// <param name="resourcePath">Resource path.</param>
        /// <returns>Async Consumer with String</returns>
        /// <example>
        /// <code>
        /// var consumer = api.AddResourceSubscription("015bb66a92a30000000000010010006d", "3200/0/5500");
        /// var counter = 0;
        /// while (true)
        /// {
        ///     var t = consumer.GetValue();
        ///     Console.WriteLine(t.Result);
        ///     counter++;
        ///     if (counter >= 2)
        ///     {
        ///     break;
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <exception cref="CloudApiException">CloudApiException</exception>
        public Resource AddResourceSubscription(string deviceId, string resourcePath)
        {
            try
            {
                StartNotifications();
                var fixedPath = FixedPath(resourcePath);
                subscriptionsApi.V2SubscriptionsDeviceIdResourcePathPut(deviceId, fixedPath);
                var subscribePath = deviceId + resourcePath;
                var resource = new Resource(deviceId, null, this);
                if (!ResourceSubscribtions.ContainsKey(subscribePath))
                {
                    ResourceSubscribtions.Add(subscribePath, resource);
                }
                else
                {
                    ResourceSubscribtions.Remove(subscribePath);
                    ResourceSubscribtions.Add(subscribePath, resource);
                }

                return resource;
            }
            catch (mds.Client.ApiException ex)
            {
                throw new CloudApiException(ex.ErrorCode, ex.Message, ex.ErrorContent);
            }
        }

        /// <summary>
        /// Subscribe to resource updates.
        /// </summary>
        /// <param name="resource">The resource to subscribe to.</param>
        /// <returns>Async Consumer with String</returns>
        /// <example>
        /// <code>
        /// var resource = new Resource("015bb66a92a30000000000010010006d", null, this);
        /// var consumer = api.AddResourceSubscription(resource);
        /// var counter = 0;
        /// while (true)
        /// {
        ///     var t = consumer.GetValue();
        ///     Console.WriteLine(t.Result);
        ///     counter++;
        ///     if (counter >= 2)
        ///     {
        ///     break;
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <exception cref="CloudApiException">CloudApiException</exception>
        public Resource AddResourceSubscription(Resource resource)
        {
            try
            {
                StartNotifications();
                var fixedPath = FixedPath(resource.Path);
                subscriptionsApi.V2SubscriptionsDeviceIdResourcePathPut(resource.DeviceId, fixedPath);
                var subscribePath = resource.DeviceId + resource.Path;

                if (!ResourceSubscribtions.ContainsKey(subscribePath))
                {
                    ResourceSubscribtions.Add(subscribePath, resource);
                }
                else
                {
                    ResourceSubscribtions.Remove(subscribePath);
                    ResourceSubscribtions.Add(subscribePath, resource);
                }

                return resource;
            }
            catch (mds.Client.ApiException ex)
            {
                throw new CloudApiException(ex.ErrorCode, ex.Message, ex.ErrorContent);
            }
        }

        /// <summary>
        /// Gets the status of a resource's subscription. True if ok, false if not.
        /// </summary>
        /// <param name="deviceId">Id of device.</param>
        /// <param name="resourcePath">Resource path.</param>
        /// <returns>True if subscribed, false if not.</returns>
        /// <example>
        /// <code>
        /// var status = connectApi.GetResourceSubscription("015bb66a92a30000000000010010006d", "3200/0/5500");
        /// </code>
        /// </example>
        public bool GetResourceSubscription(string deviceId, string resourcePath)
        {
            try
            {
                var fixedPath = FixedPath(resourcePath);
                subscriptionsApi.V2SubscriptionsDeviceIdResourcePathGet(deviceId, fixedPath);
                return true;
            }
            catch (mds.Client.ApiException)
            {
                return false;
            }
        }

        /// <summary>
        /// Unsubscribe from device and/or resource_path updates.
        /// </summary>
        /// <param name="deviceId">device to unsubscribe events from. If not provided, all registered devices will be unsubscribed</param>
        /// <param name="resourcePath">resource_path to unsubscribe events from. If not provided, all resource paths will be unsubscribed.</param>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     connectApi.DeleteResourceSubscription("015bb66a92a30000000000010010006d", "3200/0/5500");
        /// }
        /// catch (CloudApiException)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        /// <exception cref="CloudApiException">CloudApiException</exception>
        public void DeleteResourceSubscription(string deviceId = null, string resourcePath = null)
        {
            try
            {
                if (deviceId == null)
                {
                    foreach (var resource in ResourceSubscribtions)
                    {
                        subscriptionsApi.V2SubscriptionsDeviceIdResourcePathDelete(resource.Key, resource.Value.Path);
                        ResourceSubscribtions.Clear();
                    }
                }
                else
                {
                    subscriptionsApi.V2SubscriptionsDeviceIdResourcePathDelete(deviceId, resourcePath);
                    var subscribePath = deviceId + resourcePath;
                    ResourceSubscribtions.Remove(subscribePath);
                }
            }
            catch (mds.Client.ApiException ex)
            {
                throw new CloudApiException(ex.ErrorCode, ex.Message, ex.ErrorContent);
            }
        }
    }
}