// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="DeviceRepository.cs" company="Arm">
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
    /// DeviceRepository
    /// </summary>
    public class DeviceRepository : Repository, IDeviceRepository
    {
        public DeviceRepository()
        {
        }

        public DeviceRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task AddToGroup(string deviceGroupId, Device request)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "device-group-id", deviceGroupId }, };
                var bodyParams = new Device { Id = request.Id, };
                await Client.CallApi<Device>(path: "/v3/device-groups/{device-group-id}/devices/add/", pathParams: pathParams, bodyParams: bodyParams, objectToUnpack: request, method: HttpMethods.POST);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<Device> Create(Device request)
        {
            try
            {
                var bodyParams = new Device { AutoUpdate = request.AutoUpdate, BootstrapExpirationDate = request.BootstrapExpirationDate, CaId = request.CaId, ConnectorExpirationDate = request.ConnectorExpirationDate, CustomAttributes = request.CustomAttributes, Deployment = request.Deployment, Description = request.Description, DeviceClass = request.DeviceClass, DeviceExecutionMode = request.DeviceExecutionMode, DeviceKey = request.DeviceKey, EndpointName = request.EndpointName, EndpointType = request.EndpointType, HostGateway = request.HostGateway, IssuerFingerprint = request.IssuerFingerprint, Manifest = request.Manifest, Mechanism = request.Mechanism, MechanismUrl = request.MechanismUrl, Name = request.Name, SerialNumber = request.SerialNumber, State = request.State, VendorId = request.VendorId, };
                return await Client.CallApi<Device>(path: "/v3/devices/", bodyParams: bodyParams, objectToUnpack: request, method: HttpMethods.POST);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task Delete(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "id", id }, };
                await Client.CallApi<Device>(path: "/v3/devices/{id}/", pathParams: pathParams, method: HttpMethods.DELETE);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<IDeviceDeviceListOptions, Device> List(IDeviceDeviceListOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new DeviceDeviceListOptions();
                }

                Func<IDeviceDeviceListOptions, Task<ResponsePage<Device>>> paginatedFunc = async (IDeviceDeviceListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, { "account_id__eq", _options.Filter.GetEncodedValue("account_id", "$eq") }, { "account_id__neq", _options.Filter.GetEncodedValue("account_id", "$neq") }, { "account_id__in", _options.Filter.GetEncodedValue("account_id", "$in") }, { "account_id__nin", _options.Filter.GetEncodedValue("account_id", "$nin") }, { "auto_update__eq", _options.Filter.GetEncodedValue("auto_update", "$eq") }, { "auto_update__neq", _options.Filter.GetEncodedValue("auto_update", "$neq") }, { "bootstrap_expiration_date__in", _options.Filter.GetEncodedValue("bootstrap_expiration_date", "$in") }, { "bootstrap_expiration_date__nin", _options.Filter.GetEncodedValue("bootstrap_expiration_date", "$nin") }, { "bootstrap_expiration_date__lte", _options.Filter.GetEncodedValue("bootstrap_expiration_date", "$lte") }, { "bootstrap_expiration_date__gte", _options.Filter.GetEncodedValue("bootstrap_expiration_date", "$gte") }, { "bootstrapped_timestamp__in", _options.Filter.GetEncodedValue("bootstrapped_timestamp", "$in") }, { "bootstrapped_timestamp__nin", _options.Filter.GetEncodedValue("bootstrapped_timestamp", "$nin") }, { "bootstrapped_timestamp__lte", _options.Filter.GetEncodedValue("bootstrapped_timestamp", "$lte") }, { "bootstrapped_timestamp__gte", _options.Filter.GetEncodedValue("bootstrapped_timestamp", "$gte") }, { "ca_id__eq", _options.Filter.GetEncodedValue("ca_id", "$eq") }, { "ca_id__neq", _options.Filter.GetEncodedValue("ca_id", "$neq") }, { "ca_id__in", _options.Filter.GetEncodedValue("ca_id", "$in") }, { "ca_id__nin", _options.Filter.GetEncodedValue("ca_id", "$nin") }, { "connector_expiration_date__in", _options.Filter.GetEncodedValue("connector_expiration_date", "$in") }, { "connector_expiration_date__nin", _options.Filter.GetEncodedValue("connector_expiration_date", "$nin") }, { "connector_expiration_date__lte", _options.Filter.GetEncodedValue("connector_expiration_date", "$lte") }, { "connector_expiration_date__gte", _options.Filter.GetEncodedValue("connector_expiration_date", "$gte") }, { "created_at__in", _options.Filter.GetEncodedValue("created_at", "$in") }, { "created_at__nin", _options.Filter.GetEncodedValue("created_at", "$nin") }, { "created_at__lte", _options.Filter.GetEncodedValue("created_at", "$lte") }, { "created_at__gte", _options.Filter.GetEncodedValue("created_at", "$gte") }, { "deployed_state__eq", _options.Filter.GetEncodedValue("deployed_state", "$eq") }, { "deployed_state__neq", _options.Filter.GetEncodedValue("deployed_state", "$neq") }, { "deployed_state__in", _options.Filter.GetEncodedValue("deployed_state", "$in") }, { "deployed_state__nin", _options.Filter.GetEncodedValue("deployed_state", "$nin") }, { "deployment__eq", _options.Filter.GetEncodedValue("deployment", "$eq") }, { "deployment__neq", _options.Filter.GetEncodedValue("deployment", "$neq") }, { "deployment__in", _options.Filter.GetEncodedValue("deployment", "$in") }, { "deployment__nin", _options.Filter.GetEncodedValue("deployment", "$nin") }, { "description__eq", _options.Filter.GetEncodedValue("description", "$eq") }, { "description__neq", _options.Filter.GetEncodedValue("description", "$neq") }, { "description__in", _options.Filter.GetEncodedValue("description", "$in") }, { "description__nin", _options.Filter.GetEncodedValue("description", "$nin") }, { "device_class__eq", _options.Filter.GetEncodedValue("device_class", "$eq") }, { "device_class__neq", _options.Filter.GetEncodedValue("device_class", "$neq") }, { "device_class__in", _options.Filter.GetEncodedValue("device_class", "$in") }, { "device_class__nin", _options.Filter.GetEncodedValue("device_class", "$nin") }, { "device_execution_mode__eq", _options.Filter.GetEncodedValue("device_execution_mode", "$eq") }, { "device_execution_mode__neq", _options.Filter.GetEncodedValue("device_execution_mode", "$neq") }, { "device_execution_mode__in", _options.Filter.GetEncodedValue("device_execution_mode", "$in") }, { "device_execution_mode__nin", _options.Filter.GetEncodedValue("device_execution_mode", "$nin") }, { "device_key__eq", _options.Filter.GetEncodedValue("device_key", "$eq") }, { "device_key__neq", _options.Filter.GetEncodedValue("device_key", "$neq") }, { "device_key__in", _options.Filter.GetEncodedValue("device_key", "$in") }, { "device_key__nin", _options.Filter.GetEncodedValue("device_key", "$nin") }, { "endpoint_name__eq", _options.Filter.GetEncodedValue("endpoint_name", "$eq") }, { "endpoint_name__neq", _options.Filter.GetEncodedValue("endpoint_name", "$neq") }, { "endpoint_name__in", _options.Filter.GetEncodedValue("endpoint_name", "$in") }, { "endpoint_name__nin", _options.Filter.GetEncodedValue("endpoint_name", "$nin") }, { "endpoint_type__eq", _options.Filter.GetEncodedValue("endpoint_type", "$eq") }, { "endpoint_type__neq", _options.Filter.GetEncodedValue("endpoint_type", "$neq") }, { "endpoint_type__in", _options.Filter.GetEncodedValue("endpoint_type", "$in") }, { "endpoint_type__nin", _options.Filter.GetEncodedValue("endpoint_type", "$nin") }, { "enrolment_list_timestamp__in", _options.Filter.GetEncodedValue("enrolment_list_timestamp", "$in") }, { "enrolment_list_timestamp__nin", _options.Filter.GetEncodedValue("enrolment_list_timestamp", "$nin") }, { "enrolment_list_timestamp__lte", _options.Filter.GetEncodedValue("enrolment_list_timestamp", "$lte") }, { "enrolment_list_timestamp__gte", _options.Filter.GetEncodedValue("enrolment_list_timestamp", "$gte") }, { "firmware_checksum__eq", _options.Filter.GetEncodedValue("firmware_checksum", "$eq") }, { "firmware_checksum__neq", _options.Filter.GetEncodedValue("firmware_checksum", "$neq") }, { "firmware_checksum__in", _options.Filter.GetEncodedValue("firmware_checksum", "$in") }, { "firmware_checksum__nin", _options.Filter.GetEncodedValue("firmware_checksum", "$nin") }, { "host_gateway__eq", _options.Filter.GetEncodedValue("host_gateway", "$eq") }, { "host_gateway__neq", _options.Filter.GetEncodedValue("host_gateway", "$neq") }, { "host_gateway__in", _options.Filter.GetEncodedValue("host_gateway", "$in") }, { "host_gateway__nin", _options.Filter.GetEncodedValue("host_gateway", "$nin") }, { "id__eq", _options.Filter.GetEncodedValue("id", "$eq") }, { "id__neq", _options.Filter.GetEncodedValue("id", "$neq") }, { "id__in", _options.Filter.GetEncodedValue("id", "$in") }, { "id__nin", _options.Filter.GetEncodedValue("id", "$nin") }, { "manifest__eq", _options.Filter.GetEncodedValue("manifest", "$eq") }, { "manifest__neq", _options.Filter.GetEncodedValue("manifest", "$neq") }, { "manifest__in", _options.Filter.GetEncodedValue("manifest", "$in") }, { "manifest__nin", _options.Filter.GetEncodedValue("manifest", "$nin") }, { "manifest_timestamp__in", _options.Filter.GetEncodedValue("manifest_timestamp", "$in") }, { "manifest_timestamp__nin", _options.Filter.GetEncodedValue("manifest_timestamp", "$nin") }, { "manifest_timestamp__lte", _options.Filter.GetEncodedValue("manifest_timestamp", "$lte") }, { "manifest_timestamp__gte", _options.Filter.GetEncodedValue("manifest_timestamp", "$gte") }, { "mechanism__eq", _options.Filter.GetEncodedValue("mechanism", "$eq") }, { "mechanism__neq", _options.Filter.GetEncodedValue("mechanism", "$neq") }, { "mechanism__in", _options.Filter.GetEncodedValue("mechanism", "$in") }, { "mechanism__nin", _options.Filter.GetEncodedValue("mechanism", "$nin") }, { "mechanism_url__eq", _options.Filter.GetEncodedValue("mechanism_url", "$eq") }, { "mechanism_url__neq", _options.Filter.GetEncodedValue("mechanism_url", "$neq") }, { "mechanism_url__in", _options.Filter.GetEncodedValue("mechanism_url", "$in") }, { "mechanism_url__nin", _options.Filter.GetEncodedValue("mechanism_url", "$nin") }, { "name__eq", _options.Filter.GetEncodedValue("name", "$eq") }, { "name__neq", _options.Filter.GetEncodedValue("name", "$neq") }, { "name__in", _options.Filter.GetEncodedValue("name", "$in") }, { "name__nin", _options.Filter.GetEncodedValue("name", "$nin") }, { "serial_number__eq", _options.Filter.GetEncodedValue("serial_number", "$eq") }, { "serial_number__neq", _options.Filter.GetEncodedValue("serial_number", "$neq") }, { "serial_number__in", _options.Filter.GetEncodedValue("serial_number", "$in") }, { "serial_number__nin", _options.Filter.GetEncodedValue("serial_number", "$nin") }, { "state__eq", _options.Filter.GetEncodedValue("state", "$eq") }, { "state__neq", _options.Filter.GetEncodedValue("state", "$neq") }, { "state__in", _options.Filter.GetEncodedValue("state", "$in") }, { "state__nin", _options.Filter.GetEncodedValue("state", "$nin") }, { "updated_at__in", _options.Filter.GetEncodedValue("updated_at", "$in") }, { "updated_at__nin", _options.Filter.GetEncodedValue("updated_at", "$nin") }, { "updated_at__lte", _options.Filter.GetEncodedValue("updated_at", "$lte") }, { "updated_at__gte", _options.Filter.GetEncodedValue("updated_at", "$gte") }, { "vendor_id__eq", _options.Filter.GetEncodedValue("vendor_id", "$eq") }, { "vendor_id__neq", _options.Filter.GetEncodedValue("vendor_id", "$neq") }, { "vendor_id__in", _options.Filter.GetEncodedValue("vendor_id", "$in") }, { "vendor_id__nin", _options.Filter.GetEncodedValue("vendor_id", "$nin") }, }; return await Client.CallApi<ResponsePage<Device>>(path: "/v3/devices/", queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<IDeviceDeviceListOptions, Device>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<Device> Read(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "id", id }, };
                return await Client.CallApi<Device>(path: "/v3/devices/{id}/", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task RemoveFromGroup(string deviceGroupId, Device request)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "device-group-id", deviceGroupId }, };
                var bodyParams = new Device { Id = request.Id, };
                await Client.CallApi<Device>(path: "/v3/device-groups/{device-group-id}/devices/remove/", pathParams: pathParams, bodyParams: bodyParams, objectToUnpack: request, method: HttpMethods.POST);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<CertificateEnrollment> RenewCertificate(string certificateName, string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "certificate-name", certificateName }, { "device-id", id }, };
                return await Client.CallApi<CertificateEnrollment>(path: "/v3/devices/{device-id}/certificates/{certificate-name}/renew", pathParams: pathParams, method: HttpMethods.POST);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<Device> Update(string id, Device request)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "id", id }, };
                var bodyParams = new Device { AutoUpdate = request.AutoUpdate, CaId = request.CaId, CustomAttributes = request.CustomAttributes, Description = request.Description, DeviceKey = request.DeviceKey, EndpointName = request.EndpointName, EndpointType = request.EndpointType, HostGateway = request.HostGateway, Name = request.Name, };
                return await Client.CallApi<Device>(path: "/v3/devices/{id}/", pathParams: pathParams, bodyParams: bodyParams, objectToUnpack: request, method: HttpMethods.PUT);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}