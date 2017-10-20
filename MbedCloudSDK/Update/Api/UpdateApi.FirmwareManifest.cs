﻿// <copyright file="UpdateApi.FirmwareManifest.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>

namespace MbedCloudSDK.Update.Api
{
    using System.IO;
    using MbedCloudSDK.Common;
    using MbedCloudSDK.Common.Query;
    using MbedCloudSDK.Exceptions;
    using MbedCloudSDK.Update.Model.FirmwareManifest;

    /// <summary>
    /// Update Api
    /// </summary>
    public partial class UpdateApi
    {
        /// <summary>
        /// List Firmware Images.
        /// </summary>
        /// <param name="options">Query options.</param>
        /// <returns>Paginated Response of Firmware Manifests</returns>
        public PaginatedResponse<FirmwareManifest> ListFirmwareManifests(QueryOptions options = null)
        {
            if (options == null)
            {
                options = new QueryOptions();
            }

            try
            {
                return new PaginatedResponse<FirmwareManifest>(ListFirmwareManifestsFun, options);
            }
            catch (CloudApiException)
            {
                throw;
            }
        }

        private ResponsePage<FirmwareManifest> ListFirmwareManifestsFun(QueryOptions options = null)
        {
            if (options == null)
            {
                options = new QueryOptions();
            }

            try
            {
                var resp = api.FirmwareManifestList(limit: options.Limit, order: options.Order, after: options.After, filter: options.Filter?.FilterString, include: options.Include);
                var respManifests = new ResponsePage<FirmwareManifest>(resp.After, resp.HasMore, resp.Limit, resp.Order.ToString(), resp.TotalCount);
                foreach (var manifest in resp.Data)
                {
                    respManifests.Data.Add(FirmwareManifest.Map(manifest));
                }

                return respManifests;
            }
            catch (update_service.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        /// <summary>
        /// Get manifest with provided manifest_id.
        /// </summary>
        /// <param name="manifestId">ID of manifest to retrieve.</param>
        /// <returns>Firmware Manifest</returns>
        public FirmwareManifest GetFirmwareManifest(string manifestId)
        {
            try
            {
                return FirmwareManifest.Map(api.FirmwareManifestRetrieve(manifestId));
            }
            catch (update_service.Client.ApiException ex)
            {
                throw new CloudApiException(ex.ErrorCode, ex.Message, ex.ErrorContent);
            }
        }

        /// <summary>
        /// Add Firmware Manifest.
        /// </summary>
        /// <param name="dataFile">Stream to the manifest file.</param>
        /// <param name="name">Name of the firmware manifest.</param>
        /// <param name="description">Description for the firmware manifest.</param>
        /// <returns>Firmware Manifest</returns>
        public FirmwareManifest AddFirmwareManifest(string dataFile, string name, string description = null)
        {
            try
            {
                using (var fs = File.Open(dataFile, FileMode.Open))
                {
                    var result = api.FirmwareManifestCreate(fs, name, description);
                    return FirmwareManifest.Map(result);
                }
            }
            catch (update_service.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        /// <summary>
        /// Delete firmware manifest.
        /// </summary>
        /// <param name="manifestId">Id of the manifest to be deleted.</param>
        public void DeleteFirmwareManifest(string manifestId)
        {
            try
            {
                api.FirmwareManifestDestroy(manifestId);
            }
            catch (update_service.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}