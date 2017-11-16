﻿// <copyright file="ConnectApi.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>

namespace MbedCloudSDK.Connect.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using device_directory.Client;
    using MbedCloudSDK.Common;
    using MbedCloudSDK.Connect.Model.ConnectedDevice;
    using MbedCloudSDK.Connect.Model.Resource;
    using mds.Api;

    /// <summary>
    /// Exposing functionality from the following underlying services:
    /// - Connector / mDS
    /// - Device query service
    /// - Device catalog
    /// </summary>
    public partial class ConnectApi : BaseApi, IDisposable
    {
        /// <summary>
        /// Resources that are currently subscribed.
        /// </summary>
        private static Dictionary<string, Resource> resourceSubscribtions = new Dictionary<string, Resource>();

        /// <summary>
        /// Responses to async requests.
        /// </summary>
        private static Dictionary<string, AsyncProducerConsumerCollection<string>> asyncResponses = new Dictionary<string, AsyncProducerConsumerCollection<string>>();

        private Task notificationTask;
        private CancellationTokenSource cancellationToken;
        private device_directory.Api.DefaultApi deviceDirectoryApi;
        private statistics.Api.StatisticsApi statisticsApi;
        private EndpointsApi endpointsApi;
        private statistics.Api.AccountApi accountApi;
        private SubscriptionsApi subscriptionsApi;
        private ResourcesApi resourcesApi;
        private string auth;
        private NotificationsApi notificationsApi;
        private DefaultApi defaultApi;
        private bool disposed;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectApi"/> class.
        /// </summary>
        /// <param name="config">Config.</param>
        public ConnectApi(Config config)
            : base(config)
        {
            cancellationToken = new CancellationTokenSource();
            notificationTask = new Task(new Action(Notifications), cancellationToken.Token, TaskCreationOptions.LongRunning);
            ResourceSubscribtions = new Dictionary<string, Resource>();

            auth = string.Format("{0} {1}", config.AuthorizationPrefix, config.ApiKey);
            statistics.Client.Configuration.Default.ApiClient = new statistics.Client.ApiClient(config.Host);
            statistics.Client.Configuration.Default.ApiKey["Authorization"] = config.ApiKey;
            statistics.Client.Configuration.Default.ApiKeyPrefix["Authorization"] = config.AuthorizationPrefix;
            statistics.Client.Configuration.Default.DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ss.fffZ";

            mds.Client.Configuration.Default.ApiClient = new mds.Client.ApiClient(config.Host);
            mds.Client.Configuration.Default.ApiKey["Authorization"] = config.ApiKey;
            mds.Client.Configuration.Default.ApiKeyPrefix["Authorization"] = config.AuthorizationPrefix;
            mds.Client.Configuration.Default.DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ss.fffZ";

            Configuration.Default.ApiClient = new ApiClient(config.Host);
            Configuration.Default.ApiKey["Authorization"] = config.ApiKey;
            Configuration.Default.ApiKeyPrefix["Authorization"] = config.AuthorizationPrefix;
            Configuration.Default.DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ss.fffZ";

            deviceDirectoryApi = new device_directory.Api.DefaultApi();
            statisticsApi = new statistics.Api.StatisticsApi();
            subscriptionsApi = new SubscriptionsApi();
            resourcesApi = new ResourcesApi();
            endpointsApi = new EndpointsApi();
            accountApi = new statistics.Api.AccountApi();
            notificationsApi = new NotificationsApi();
            defaultApi = new DefaultApi();
        }

        /// <summary>
        /// Gets or sets async responses
        /// </summary>
        public static Dictionary<string, AsyncProducerConsumerCollection<string>> AsyncResponses { get => asyncResponses; set => asyncResponses = value; }

        /// <summary>
        /// Gets or sets resource Subscriptions
        /// </summary>
        public static Dictionary<string, Resource> ResourceSubscribtions { get => resourceSubscribtions; set => resourceSubscribtions = value; }

        /// <summary>
        /// Get meta data for the last Mbed Cloud API call
        /// </summary>
        /// <returns>Metadata Object</returns>
        public static ApiMetadata GetLastApiMetadata()
        {
            var lastMds = mds.Client.Configuration.Default.ApiClient.LastApiResponse.LastOrDefault()?.Headers?.Where(m => m.Name == "Date")?.Select(d => DateTime.Parse(d.Value.ToString()))?.FirstOrDefault();
            var lastStats = statistics.Client.Configuration.Default.ApiClient.LastApiResponse.LastOrDefault()?.Headers?.Where(m => m.Name == "Date")?.Select(d => DateTime.Parse(d.Value.ToString()))?.FirstOrDefault();
            if (Nullable.Compare(lastMds, lastStats) > 0)
            {
                return ApiMetadata.Map(mds.Client.Configuration.Default.ApiClient.LastApiResponse.LastOrDefault());
            }
            else
            {
                return ApiMetadata.Map(statistics.Client.Configuration.Default.ApiClient.LastApiResponse.LastOrDefault());
            }
        }

        /// <summary>
        /// Test
        /// </summary>
        /// <returns>Test</returns>
        public List<Model.Metric.Metric> TestTest()
        {
            var options = new Model.Metric.MetricQueryOptions
            {
                Interval = "1d",
                Start = new DateTime(2017, 3, 1),
                End = new DateTime(2017, 4, 1),
            };
            var metrics = ListMetrics(options);
            foreach (var item in metrics)
            {
                Console.WriteLine(item);
            }

            return metrics;
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Virtual dispose
        /// </summary>
        /// <param name="disposing">dispose</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            disposed = true;
            if (disposing)
            {
                cancellationToken?.Dispose();
            }
        }

        /// <summary>
        /// Throw if disposed
        /// </summary>
        protected virtual void ThrowIfDisposed()
        {
            if (disposed)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }
        }

        private static string FixedPath(string path)
        {
            if (path.StartsWith("/", StringComparison.OrdinalIgnoreCase))
            {
                path = path.Substring(1);
            }

            return path;
        }
    }
}
