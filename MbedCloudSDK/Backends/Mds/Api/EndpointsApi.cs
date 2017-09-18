/* 
 * <auto-generated>
 * Connect API
 *
 * mbed Cloud Connect API allows web applications to communicate with devices. You can subscribe to device resources and read/write values to them. mbed Cloud Connect makes connectivity to devices easy by queuing requests and caching resource values.
 *
 * OpenAPI spec version: 2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * </auto-generated>
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using mds.Client;
using mds.Model;

namespace mds.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEndpointsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List the resources on an endpoint
        /// </summary>
        /// <remarks>
        /// The list of resources is cached by mbed Cloud Connect, so this call does not create a message to the device.  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints/{device-id} -H &#39;authorization: Bearer {api-key}&#39; 
        /// </remarks>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">A unique mbed Cloud device ID for an endpoint. Note that the ID needs to be an exact match. You cannot use wildcards here. </param>
        /// <returns>List&lt;Resource&gt;</returns>
        List<Resource> V2EndpointsDeviceIdGet (string deviceId);

        /// <summary>
        /// List the resources on an endpoint
        /// </summary>
        /// <remarks>
        /// The list of resources is cached by mbed Cloud Connect, so this call does not create a message to the device.  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints/{device-id} -H &#39;authorization: Bearer {api-key}&#39; 
        /// </remarks>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">A unique mbed Cloud device ID for an endpoint. Note that the ID needs to be an exact match. You cannot use wildcards here. </param>
        /// <returns>ApiResponse of List&lt;Resource&gt;</returns>
        ApiResponse<List<Resource>> V2EndpointsDeviceIdGetWithHttpInfo (string deviceId);
        /// <summary>
        /// List registered endpoints. The number of endpoints is currently limited to 200.
        /// </summary>
        /// <remarks>
        /// Endpoints are physical devices having valid registration to mbed Cloud Connect. All devices despite the registration status can be requested from Device Directory API [&#39;/v3/devices/ ](/docs/v1.2/api-references/device-directory-api.html#v3-devices).  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints -H &#39;authorization: Bearer {api-key}&#39; 
        /// </remarks>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Filter endpoints by endpoint-type. (optional)</param>
        /// <returns>List&lt;Endpoint&gt;</returns>
        List<Endpoint> V2EndpointsGet (string type = null);

        /// <summary>
        /// List registered endpoints. The number of endpoints is currently limited to 200.
        /// </summary>
        /// <remarks>
        /// Endpoints are physical devices having valid registration to mbed Cloud Connect. All devices despite the registration status can be requested from Device Directory API [&#39;/v3/devices/ ](/docs/v1.2/api-references/device-directory-api.html#v3-devices).  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints -H &#39;authorization: Bearer {api-key}&#39; 
        /// </remarks>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Filter endpoints by endpoint-type. (optional)</param>
        /// <returns>ApiResponse of List&lt;Endpoint&gt;</returns>
        ApiResponse<List<Endpoint>> V2EndpointsGetWithHttpInfo (string type = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List the resources on an endpoint
        /// </summary>
        /// <remarks>
        /// The list of resources is cached by mbed Cloud Connect, so this call does not create a message to the device.  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints/{device-id} -H &#39;authorization: Bearer {api-key}&#39; 
        /// </remarks>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">A unique mbed Cloud device ID for an endpoint. Note that the ID needs to be an exact match. You cannot use wildcards here. </param>
        /// <returns>Task of List&lt;Resource&gt;</returns>
        System.Threading.Tasks.Task<List<Resource>> V2EndpointsDeviceIdGetAsync (string deviceId);

        /// <summary>
        /// List the resources on an endpoint
        /// </summary>
        /// <remarks>
        /// The list of resources is cached by mbed Cloud Connect, so this call does not create a message to the device.  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints/{device-id} -H &#39;authorization: Bearer {api-key}&#39; 
        /// </remarks>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">A unique mbed Cloud device ID for an endpoint. Note that the ID needs to be an exact match. You cannot use wildcards here. </param>
        /// <returns>Task of ApiResponse (List&lt;Resource&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Resource>>> V2EndpointsDeviceIdGetAsyncWithHttpInfo (string deviceId);
        /// <summary>
        /// List registered endpoints. The number of endpoints is currently limited to 200.
        /// </summary>
        /// <remarks>
        /// Endpoints are physical devices having valid registration to mbed Cloud Connect. All devices despite the registration status can be requested from Device Directory API [&#39;/v3/devices/ ](/docs/v1.2/api-references/device-directory-api.html#v3-devices).  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints -H &#39;authorization: Bearer {api-key}&#39; 
        /// </remarks>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Filter endpoints by endpoint-type. (optional)</param>
        /// <returns>Task of List&lt;Endpoint&gt;</returns>
        System.Threading.Tasks.Task<List<Endpoint>> V2EndpointsGetAsync (string type = null);

        /// <summary>
        /// List registered endpoints. The number of endpoints is currently limited to 200.
        /// </summary>
        /// <remarks>
        /// Endpoints are physical devices having valid registration to mbed Cloud Connect. All devices despite the registration status can be requested from Device Directory API [&#39;/v3/devices/ ](/docs/v1.2/api-references/device-directory-api.html#v3-devices).  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints -H &#39;authorization: Bearer {api-key}&#39; 
        /// </remarks>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Filter endpoints by endpoint-type. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Endpoint&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Endpoint>>> V2EndpointsGetAsyncWithHttpInfo (string type = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EndpointsApi : IEndpointsApi
    {
        private mds.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EndpointsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = mds.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EndpointsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = mds.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public mds.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// List the resources on an endpoint The list of resources is cached by mbed Cloud Connect, so this call does not create a message to the device.  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints/{device-id} -H &#39;authorization: Bearer {api-key}&#39; 
        /// </summary>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">A unique mbed Cloud device ID for an endpoint. Note that the ID needs to be an exact match. You cannot use wildcards here. </param>
        /// <returns>List&lt;Resource&gt;</returns>
        public List<Resource> V2EndpointsDeviceIdGet (string deviceId)
        {
             ApiResponse<List<Resource>> localVarResponse = V2EndpointsDeviceIdGetWithHttpInfo(deviceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the resources on an endpoint The list of resources is cached by mbed Cloud Connect, so this call does not create a message to the device.  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints/{device-id} -H &#39;authorization: Bearer {api-key}&#39; 
        /// </summary>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">A unique mbed Cloud device ID for an endpoint. Note that the ID needs to be an exact match. You cannot use wildcards here. </param>
        /// <returns>ApiResponse of List&lt;Resource&gt;</returns>
        public ApiResponse< List<Resource> > V2EndpointsDeviceIdGetWithHttpInfo (string deviceId)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling EndpointsApi->V2EndpointsDeviceIdGet");

            var localVarPath = "/v2/endpoints/{device-id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/link-format"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (deviceId != null) localVarPathParams.Add("device-id", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2EndpointsDeviceIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Resource>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Resource>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Resource>)));
            
        }

        /// <summary>
        /// List the resources on an endpoint The list of resources is cached by mbed Cloud Connect, so this call does not create a message to the device.  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints/{device-id} -H &#39;authorization: Bearer {api-key}&#39; 
        /// </summary>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">A unique mbed Cloud device ID for an endpoint. Note that the ID needs to be an exact match. You cannot use wildcards here. </param>
        /// <returns>Task of List&lt;Resource&gt;</returns>
        public async System.Threading.Tasks.Task<List<Resource>> V2EndpointsDeviceIdGetAsync (string deviceId)
        {
             ApiResponse<List<Resource>> localVarResponse = await V2EndpointsDeviceIdGetAsyncWithHttpInfo(deviceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the resources on an endpoint The list of resources is cached by mbed Cloud Connect, so this call does not create a message to the device.  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints/{device-id} -H &#39;authorization: Bearer {api-key}&#39; 
        /// </summary>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">A unique mbed Cloud device ID for an endpoint. Note that the ID needs to be an exact match. You cannot use wildcards here. </param>
        /// <returns>Task of ApiResponse (List&lt;Resource&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Resource>>> V2EndpointsDeviceIdGetAsyncWithHttpInfo (string deviceId)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling EndpointsApi->V2EndpointsDeviceIdGet");

            var localVarPath = "/v2/endpoints/{device-id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/link-format"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (deviceId != null) localVarPathParams.Add("device-id", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2EndpointsDeviceIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Resource>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Resource>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Resource>)));
            
        }

        /// <summary>
        /// List registered endpoints. The number of endpoints is currently limited to 200. Endpoints are physical devices having valid registration to mbed Cloud Connect. All devices despite the registration status can be requested from Device Directory API [&#39;/v3/devices/ ](/docs/v1.2/api-references/device-directory-api.html#v3-devices).  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints -H &#39;authorization: Bearer {api-key}&#39; 
        /// </summary>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Filter endpoints by endpoint-type. (optional)</param>
        /// <returns>List&lt;Endpoint&gt;</returns>
        public List<Endpoint> V2EndpointsGet (string type = null)
        {
             ApiResponse<List<Endpoint>> localVarResponse = V2EndpointsGetWithHttpInfo(type);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List registered endpoints. The number of endpoints is currently limited to 200. Endpoints are physical devices having valid registration to mbed Cloud Connect. All devices despite the registration status can be requested from Device Directory API [&#39;/v3/devices/ ](/docs/v1.2/api-references/device-directory-api.html#v3-devices).  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints -H &#39;authorization: Bearer {api-key}&#39; 
        /// </summary>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Filter endpoints by endpoint-type. (optional)</param>
        /// <returns>ApiResponse of List&lt;Endpoint&gt;</returns>
        public ApiResponse< List<Endpoint> > V2EndpointsGetWithHttpInfo (string type = null)
        {

            var localVarPath = "/v2/endpoints";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/link-format"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2EndpointsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Endpoint>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Endpoint>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Endpoint>)));
            
        }

        /// <summary>
        /// List registered endpoints. The number of endpoints is currently limited to 200. Endpoints are physical devices having valid registration to mbed Cloud Connect. All devices despite the registration status can be requested from Device Directory API [&#39;/v3/devices/ ](/docs/v1.2/api-references/device-directory-api.html#v3-devices).  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints -H &#39;authorization: Bearer {api-key}&#39; 
        /// </summary>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Filter endpoints by endpoint-type. (optional)</param>
        /// <returns>Task of List&lt;Endpoint&gt;</returns>
        public async System.Threading.Tasks.Task<List<Endpoint>> V2EndpointsGetAsync (string type = null)
        {
             ApiResponse<List<Endpoint>> localVarResponse = await V2EndpointsGetAsyncWithHttpInfo(type);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List registered endpoints. The number of endpoints is currently limited to 200. Endpoints are physical devices having valid registration to mbed Cloud Connect. All devices despite the registration status can be requested from Device Directory API [&#39;/v3/devices/ ](/docs/v1.2/api-references/device-directory-api.html#v3-devices).  **Example usage:**      curl -X GET https://api.us-east-1.mbedcloud.com/v2/endpoints -H &#39;authorization: Bearer {api-key}&#39; 
        /// </summary>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Filter endpoints by endpoint-type. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Endpoint&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Endpoint>>> V2EndpointsGetAsyncWithHttpInfo (string type = null)
        {

            var localVarPath = "/v2/endpoints";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/link-format"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2EndpointsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Endpoint>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Endpoint>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Endpoint>)));
            
        }

    }
}
