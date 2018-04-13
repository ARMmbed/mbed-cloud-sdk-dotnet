// <copyright file="NotificationMessage.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
namespace MbedCloudSDK.Connect.Model.Notifications
{
    using System.Collections.Generic;
    using System.Linq;
    using MbedCloudSDK.Connect.Api.Subscribe.Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Notification Message
    /// </summary>
    public class NotificationMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationMessage"/> class.
        /// </summary>
        public NotificationMessage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationMessage"/> class.
        /// </summary>
        /// <param name="registrations">The registrations.</param>
        /// <param name="asyncResponses">The asynchronous responses.</param>
        /// <param name="deRegistrations">The de registrations.</param>
        /// <param name="registrationUpdates">The registration updates.</param>
        /// <param name="notifications">The notifications.</param>
        /// <param name="registrationsExpired">The registrations expired.</param>
        public NotificationMessage(
            List<DeviceEventData> registrations = null,
            List<AsyncIdResponse> asyncResponses = null,
            List<DeviceEventData> deRegistrations = null,
            List<DeviceEventData> registrationUpdates = null,
            List<NotificationData> notifications = null,
            List<DeviceEventData> registrationsExpired = null)
        {
            Registrations = registrations ?? new List<DeviceEventData>();
            AsyncResponses = asyncResponses ?? new List<AsyncIdResponse>();
            DeRegistrations = deRegistrations ?? new List<DeviceEventData>();
            RegistrationUpdates = registrationUpdates ?? new List<DeviceEventData>();
            Notifications = notifications ?? new List<NotificationData>();
            RegistrationsExpired = registrationsExpired ?? new List<DeviceEventData>();
        }

        /// <summary>
        /// Gets the AsyncResponses
        /// </summary>
        /// <returns>AsyncResponses</returns>
        [JsonProperty("async-responses")]
        public List<AsyncIdResponse> AsyncResponses { get; private set; } = new List<AsyncIdResponse>();

        /// <summary>
        /// Gets the DeRegistrations
        /// </summary>
        /// <returns>DeRegistrations</returns>
        [JsonProperty("de-registrations")]
        public List<DeviceEventData> DeRegistrations { get; private set; } = new List<DeviceEventData>();

        /// <summary>
        /// Gets the RegistrationUpdates
        /// </summary>
        /// <returns>RegistrationUpdates</returns>
        [JsonProperty("reg-updates")]
        public List<DeviceEventData> RegistrationUpdates { get; private set; } = new List<DeviceEventData>();

        /// <summary>
        /// Gets the Registrations
        /// </summary>
        /// <returns>Registrations</returns>
        [JsonProperty("registrations")]
        public List<DeviceEventData> Registrations { get; private set; } = new List<DeviceEventData>();

        /// <summary>
        /// Gets the Notifications
        /// </summary>
        /// <returns>Notifications</returns>
        [JsonProperty("notifications")]
        public List<NotificationData> Notifications { get; private set; } = new List<NotificationData>();

        /// <summary>
        /// Gets the RegistrationsExpired
        /// </summary>
        /// <returns>RegistrationsExpired</returns>
        [JsonProperty("registrations-expired")]
        public List<DeviceEventData> RegistrationsExpired { get; private set; } = new List<DeviceEventData>();

        /// <summary>
        /// Map the notification message
        /// </summary>
        /// <param name="data">Notification Message Data</param>
        /// <returns>The Notification Message</returns>
        public static NotificationMessage Map(mds.Model.NotificationMessage data)
        {
            var notificationMessage = new NotificationMessage
            {
                AsyncResponses = data?.AsyncResponses?.Select(a => AsyncIdResponse.Map(a))?.ToList() ?? Enumerable.Empty<AsyncIdResponse>().ToList(),
                DeRegistrations = data?.DeRegistrations?.Select(r => new DeviceEventData { DeviceId = r, State = DeviceEventEnum.DeRegistration })?.ToList() ?? Enumerable.Empty<DeviceEventData>().ToList(),
                RegistrationUpdates = data?.RegUpdates?.Select(r => DeviceEventData.Map(r, DeviceEventEnum.RegistrationUpdate))?.ToList() ?? Enumerable.Empty<DeviceEventData>().ToList(),
                Registrations = data?.Registrations?.Select(r => DeviceEventData.Map(r, DeviceEventEnum.Registration))?.ToList() ?? Enumerable.Empty<DeviceEventData>().ToList(),
                Notifications = data?.Notifications?.Select(n => NotificationData.Map(n))?.ToList() ?? Enumerable.Empty<NotificationData>().ToList(),
                RegistrationsExpired = data?.RegistrationsExpired?.Select(r => new DeviceEventData { DeviceId = r, State = DeviceEventEnum.ExpiredRegistration })?.ToList() ?? Enumerable.Empty<DeviceEventData>().ToList(),
            };

            return notificationMessage;
        }
    }
}