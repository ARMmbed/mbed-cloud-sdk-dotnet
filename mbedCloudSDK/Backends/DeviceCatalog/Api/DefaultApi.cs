using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using device_catalog.Client;
using device_catalog.Model;

namespace device_catalog.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Create device&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DeviceSerializer</returns>
        DeviceSerializer DeviceCreate ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Create device&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DeviceSerializer</returns>
        ApiResponse<DeviceSerializer> DeviceCreateWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Delete device&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param>
        /// <returns>DeviceSerializer</returns>
        DeviceSerializer DeviceDestroy (string deviceId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Delete device&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param>
        /// <returns>ApiResponse of DeviceSerializer</returns>
        ApiResponse<DeviceSerializer> DeviceDestroyWithHttpInfo (string deviceId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all update devices. The result is paged into pages of 100.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>DeviceSerializer</returns>
        DeviceSerializer DeviceList (int? limit = null, string order = null, string after = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all update devices. The result is paged into pages of 100.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>ApiResponse of DeviceSerializer</returns>
        ApiResponse<DeviceSerializer> DeviceListWithHttpInfo (int? limit = null, string order = null, string after = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all device logs.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>DeviceLogSerializer</returns>
        DeviceLogSerializer DeviceLogList (int? limit = null, string order = null, string after = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all device logs.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>ApiResponse of DeviceLogSerializer</returns>
        ApiResponse<DeviceLogSerializer> DeviceLogListWithHttpInfo (int? limit = null, string order = null, string after = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device log.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceLogId"></param>
        /// <returns>DeviceLogSerializer</returns>
        DeviceLogSerializer DeviceLogRetrieve (string deviceLogId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device log.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceLogId"></param>
        /// <returns>ApiResponse of DeviceLogSerializer</returns>
        ApiResponse<DeviceLogSerializer> DeviceLogRetrieveWithHttpInfo (string deviceLogId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device fields&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param>
        /// <returns>DeviceSerializer</returns>
        DeviceSerializer DevicePartialUpdate (string deviceId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device fields&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param>
        /// <returns>ApiResponse of DeviceSerializer</returns>
        ApiResponse<DeviceSerializer> DevicePartialUpdateWithHttpInfo (string deviceId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param>
        /// <returns>DeviceSerializer</returns>
        DeviceSerializer DeviceRetrieve (string deviceId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param>
        /// <returns>ApiResponse of DeviceSerializer</returns>
        ApiResponse<DeviceSerializer> DeviceRetrieveWithHttpInfo (string deviceId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param>
        /// <returns>DeviceSerializer</returns>
        DeviceSerializer DeviceUpdate (string deviceId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param>
        /// <returns>ApiResponse of DeviceSerializer</returns>
        ApiResponse<DeviceSerializer> DeviceUpdateWithHttpInfo (string deviceId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Create device&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DeviceSerializer</returns>
        System.Threading.Tasks.Task<DeviceSerializer> DeviceCreateAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Create device&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DeviceSerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceSerializer>> DeviceCreateAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Delete device&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param>
        /// <returns>Task of DeviceSerializer</returns>
        System.Threading.Tasks.Task<DeviceSerializer> DeviceDestroyAsync (string deviceId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Delete device&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param>
        /// <returns>Task of ApiResponse (DeviceSerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceSerializer>> DeviceDestroyAsyncWithHttpInfo (string deviceId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all update devices. The result is paged into pages of 100.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>Task of DeviceSerializer</returns>
        System.Threading.Tasks.Task<DeviceSerializer> DeviceListAsync (int? limit = null, string order = null, string after = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all update devices. The result is paged into pages of 100.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>Task of ApiResponse (DeviceSerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceSerializer>> DeviceListAsyncWithHttpInfo (int? limit = null, string order = null, string after = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all device logs.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>Task of DeviceLogSerializer</returns>
        System.Threading.Tasks.Task<DeviceLogSerializer> DeviceLogListAsync (int? limit = null, string order = null, string after = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all device logs.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>Task of ApiResponse (DeviceLogSerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceLogSerializer>> DeviceLogListAsyncWithHttpInfo (int? limit = null, string order = null, string after = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device log.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceLogId"></param>
        /// <returns>Task of DeviceLogSerializer</returns>
        System.Threading.Tasks.Task<DeviceLogSerializer> DeviceLogRetrieveAsync (string deviceLogId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device log.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceLogId"></param>
        /// <returns>Task of ApiResponse (DeviceLogSerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceLogSerializer>> DeviceLogRetrieveAsyncWithHttpInfo (string deviceLogId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device fields&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param>
        /// <returns>Task of DeviceSerializer</returns>
        System.Threading.Tasks.Task<DeviceSerializer> DevicePartialUpdateAsync (string deviceId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device fields&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param>
        /// <returns>Task of ApiResponse (DeviceSerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceSerializer>> DevicePartialUpdateAsyncWithHttpInfo (string deviceId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param>
        /// <returns>Task of DeviceSerializer</returns>
        System.Threading.Tasks.Task<DeviceSerializer> DeviceRetrieveAsync (string deviceId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param>
        /// <returns>Task of ApiResponse (DeviceSerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceSerializer>> DeviceRetrieveAsyncWithHttpInfo (string deviceId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param>
        /// <returns>Task of DeviceSerializer</returns>
        System.Threading.Tasks.Task<DeviceSerializer> DeviceUpdateAsync (string deviceId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param>
        /// <returns>Task of ApiResponse (DeviceSerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceSerializer>> DeviceUpdateAsyncWithHttpInfo (string deviceId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

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
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Create device&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DeviceSerializer</returns>
        public DeviceSerializer DeviceCreate ()
        {
             ApiResponse<DeviceSerializer> localVarResponse = DeviceCreateWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Create device&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DeviceSerializer</returns>
        public ApiResponse< DeviceSerializer > DeviceCreateWithHttpInfo ()
        {
            
    
            var localVarPath = "/v3/devices/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeviceCreate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceCreate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceSerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Create device&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DeviceSerializer</returns>
        public async System.Threading.Tasks.Task<DeviceSerializer> DeviceCreateAsync ()
        {
             ApiResponse<DeviceSerializer> localVarResponse = await DeviceCreateAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Create device&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DeviceSerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceSerializer>> DeviceCreateAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/v3/devices/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeviceCreate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceCreate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceSerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Delete device&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param> 
        /// <returns>DeviceSerializer</returns>
        public DeviceSerializer DeviceDestroy (string deviceId)
        {
             ApiResponse<DeviceSerializer> localVarResponse = DeviceDestroyWithHttpInfo(deviceId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Delete device&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param> 
        /// <returns>ApiResponse of DeviceSerializer</returns>
        public ApiResponse< DeviceSerializer > DeviceDestroyWithHttpInfo (string deviceId)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling DefaultApi->DeviceDestroy");
            
    
            var localVarPath = "/v3/devices/{device_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (deviceId != null) localVarPathParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeviceDestroy: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceDestroy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceSerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Delete device&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param>
        /// <returns>Task of DeviceSerializer</returns>
        public async System.Threading.Tasks.Task<DeviceSerializer> DeviceDestroyAsync (string deviceId)
        {
             ApiResponse<DeviceSerializer> localVarResponse = await DeviceDestroyAsyncWithHttpInfo(deviceId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Delete device&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param>
        /// <returns>Task of ApiResponse (DeviceSerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceSerializer>> DeviceDestroyAsyncWithHttpInfo (string deviceId)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling DeviceDestroy");
            
    
            var localVarPath = "/v3/devices/{device_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (deviceId != null) localVarPathParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

            
            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeviceDestroy: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceDestroy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceSerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all update devices. The result is paged into pages of 100.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param> 
        /// <param name="order"> (optional)</param> 
        /// <param name="after"> (optional)</param> 
        /// <returns>DeviceSerializer</returns>
        public DeviceSerializer DeviceList (int? limit = null, string order = null, string after = null)
        {
             ApiResponse<DeviceSerializer> localVarResponse = DeviceListWithHttpInfo(limit, order, after);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all update devices. The result is paged into pages of 100.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param> 
        /// <param name="order"> (optional)</param> 
        /// <param name="after"> (optional)</param> 
        /// <returns>ApiResponse of DeviceSerializer</returns>
        public ApiResponse< DeviceSerializer > DeviceListWithHttpInfo (int? limit = null, string order = null, string after = null)
        {
            
    
            var localVarPath = "/v3/devices/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (order != null) localVarQueryParams.Add("order", Configuration.ApiClient.ParameterToString(order)); // query parameter
            if (after != null) localVarQueryParams.Add("after", Configuration.ApiClient.ParameterToString(after)); // query parameter
            
            
            
            

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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeviceList: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceList: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceSerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all update devices. The result is paged into pages of 100.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>Task of DeviceSerializer</returns>
        public async System.Threading.Tasks.Task<DeviceSerializer> DeviceListAsync (int? limit = null, string order = null, string after = null)
        {
             ApiResponse<DeviceSerializer> localVarResponse = await DeviceListAsyncWithHttpInfo(limit, order, after);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all update devices. The result is paged into pages of 100.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>Task of ApiResponse (DeviceSerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceSerializer>> DeviceListAsyncWithHttpInfo (int? limit = null, string order = null, string after = null)
        {
            
    
            var localVarPath = "/v3/devices/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (order != null) localVarQueryParams.Add("order", Configuration.ApiClient.ParameterToString(order)); // query parameter
            if (after != null) localVarQueryParams.Add("after", Configuration.ApiClient.ParameterToString(after)); // query parameter
            
            
            
            

            
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
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeviceList: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceList: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceSerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all device logs.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param> 
        /// <param name="order"> (optional)</param> 
        /// <param name="after"> (optional)</param> 
        /// <returns>DeviceLogSerializer</returns>
        public DeviceLogSerializer DeviceLogList (int? limit = null, string order = null, string after = null)
        {
             ApiResponse<DeviceLogSerializer> localVarResponse = DeviceLogListWithHttpInfo(limit, order, after);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all device logs.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param> 
        /// <param name="order"> (optional)</param> 
        /// <param name="after"> (optional)</param> 
        /// <returns>ApiResponse of DeviceLogSerializer</returns>
        public ApiResponse< DeviceLogSerializer > DeviceLogListWithHttpInfo (int? limit = null, string order = null, string after = null)
        {
            
    
            var localVarPath = "/v3/devicelog/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (order != null) localVarQueryParams.Add("order", Configuration.ApiClient.ParameterToString(order)); // query parameter
            if (after != null) localVarQueryParams.Add("after", Configuration.ApiClient.ParameterToString(after)); // query parameter
            
            
            
            

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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeviceLogList: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceLogList: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceLogSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceLogSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceLogSerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all device logs.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>Task of DeviceLogSerializer</returns>
        public async System.Threading.Tasks.Task<DeviceLogSerializer> DeviceLogListAsync (int? limit = null, string order = null, string after = null)
        {
             ApiResponse<DeviceLogSerializer> localVarResponse = await DeviceLogListAsyncWithHttpInfo(limit, order, after);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;List all device logs.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <returns>Task of ApiResponse (DeviceLogSerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceLogSerializer>> DeviceLogListAsyncWithHttpInfo (int? limit = null, string order = null, string after = null)
        {
            
    
            var localVarPath = "/v3/devicelog/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (order != null) localVarQueryParams.Add("order", Configuration.ApiClient.ParameterToString(order)); // query parameter
            if (after != null) localVarQueryParams.Add("after", Configuration.ApiClient.ParameterToString(after)); // query parameter
            
            
            
            

            
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
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeviceLogList: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceLogList: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceLogSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceLogSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceLogSerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device log.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceLogId"></param> 
        /// <returns>DeviceLogSerializer</returns>
        public DeviceLogSerializer DeviceLogRetrieve (string deviceLogId)
        {
             ApiResponse<DeviceLogSerializer> localVarResponse = DeviceLogRetrieveWithHttpInfo(deviceLogId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device log.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceLogId"></param> 
        /// <returns>ApiResponse of DeviceLogSerializer</returns>
        public ApiResponse< DeviceLogSerializer > DeviceLogRetrieveWithHttpInfo (string deviceLogId)
        {
            
            // verify the required parameter 'deviceLogId' is set
            if (deviceLogId == null)
                throw new ApiException(400, "Missing required parameter 'deviceLogId' when calling DefaultApi->DeviceLogRetrieve");
            
    
            var localVarPath = "/v3/devicelog/{device_log_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (deviceLogId != null) localVarPathParams.Add("device_log_id", Configuration.ApiClient.ParameterToString(deviceLogId)); // path parameter
            
            
            
            
            

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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeviceLogRetrieve: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceLogRetrieve: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceLogSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceLogSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceLogSerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device log.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceLogId"></param>
        /// <returns>Task of DeviceLogSerializer</returns>
        public async System.Threading.Tasks.Task<DeviceLogSerializer> DeviceLogRetrieveAsync (string deviceLogId)
        {
             ApiResponse<DeviceLogSerializer> localVarResponse = await DeviceLogRetrieveAsyncWithHttpInfo(deviceLogId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device log.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceLogId"></param>
        /// <returns>Task of ApiResponse (DeviceLogSerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceLogSerializer>> DeviceLogRetrieveAsyncWithHttpInfo (string deviceLogId)
        {
            // verify the required parameter 'deviceLogId' is set
            if (deviceLogId == null) throw new ApiException(400, "Missing required parameter 'deviceLogId' when calling DeviceLogRetrieve");
            
    
            var localVarPath = "/v3/devicelog/{device_log_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (deviceLogId != null) localVarPathParams.Add("device_log_id", Configuration.ApiClient.ParameterToString(deviceLogId)); // path parameter
            
            
            
            
            

            
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
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeviceLogRetrieve: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceLogRetrieve: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceLogSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceLogSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceLogSerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device fields&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param> 
        /// <returns>DeviceSerializer</returns>
        public DeviceSerializer DevicePartialUpdate (string deviceId)
        {
             ApiResponse<DeviceSerializer> localVarResponse = DevicePartialUpdateWithHttpInfo(deviceId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device fields&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param> 
        /// <returns>ApiResponse of DeviceSerializer</returns>
        public ApiResponse< DeviceSerializer > DevicePartialUpdateWithHttpInfo (string deviceId)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling DefaultApi->DevicePartialUpdate");
            
    
            var localVarPath = "/v3/devices/{device_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (deviceId != null) localVarPathParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DevicePartialUpdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DevicePartialUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceSerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device fields&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param>
        /// <returns>Task of DeviceSerializer</returns>
        public async System.Threading.Tasks.Task<DeviceSerializer> DevicePartialUpdateAsync (string deviceId)
        {
             ApiResponse<DeviceSerializer> localVarResponse = await DevicePartialUpdateAsyncWithHttpInfo(deviceId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device fields&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param>
        /// <returns>Task of ApiResponse (DeviceSerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceSerializer>> DevicePartialUpdateAsyncWithHttpInfo (string deviceId)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling DevicePartialUpdate");
            
    
            var localVarPath = "/v3/devices/{device_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (deviceId != null) localVarPathParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

            
            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DevicePartialUpdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DevicePartialUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceSerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param> 
        /// <returns>DeviceSerializer</returns>
        public DeviceSerializer DeviceRetrieve (string deviceId)
        {
             ApiResponse<DeviceSerializer> localVarResponse = DeviceRetrieveWithHttpInfo(deviceId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param> 
        /// <returns>ApiResponse of DeviceSerializer</returns>
        public ApiResponse< DeviceSerializer > DeviceRetrieveWithHttpInfo (string deviceId)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling DefaultApi->DeviceRetrieve");
            
    
            var localVarPath = "/v3/devices/{device_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (deviceId != null) localVarPathParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeviceRetrieve: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceRetrieve: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceSerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param>
        /// <returns>Task of DeviceSerializer</returns>
        public async System.Threading.Tasks.Task<DeviceSerializer> DeviceRetrieveAsync (string deviceId)
        {
             ApiResponse<DeviceSerializer> localVarResponse = await DeviceRetrieveAsyncWithHttpInfo(deviceId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Retrieve device.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId"></param>
        /// <returns>Task of ApiResponse (DeviceSerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceSerializer>> DeviceRetrieveAsyncWithHttpInfo (string deviceId)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling DeviceRetrieve");
            
    
            var localVarPath = "/v3/devices/{device_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (deviceId != null) localVarPathParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

            
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
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeviceRetrieve: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceRetrieve: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceSerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param> 
        /// <returns>DeviceSerializer</returns>
        public DeviceSerializer DeviceUpdate (string deviceId)
        {
             ApiResponse<DeviceSerializer> localVarResponse = DeviceUpdateWithHttpInfo(deviceId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param> 
        /// <returns>ApiResponse of DeviceSerializer</returns>
        public ApiResponse< DeviceSerializer > DeviceUpdateWithHttpInfo (string deviceId)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling DefaultApi->DeviceUpdate");
            
    
            var localVarPath = "/v3/devices/{device_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (deviceId != null) localVarPathParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeviceUpdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceSerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param>
        /// <returns>Task of DeviceSerializer</returns>
        public async System.Threading.Tasks.Task<DeviceSerializer> DeviceUpdateAsync (string deviceId)
        {
             ApiResponse<DeviceSerializer> localVarResponse = await DeviceUpdateAsyncWithHttpInfo(deviceId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating devices.  &lt;/p&gt;\n&lt;p&gt;Update device.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The ID of the device</param>
        /// <returns>Task of ApiResponse (DeviceSerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceSerializer>> DeviceUpdateAsyncWithHttpInfo (string deviceId)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling DeviceUpdate");
            
    
            var localVarPath = "/v3/devices/{device_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (deviceId != null) localVarPathParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            
            
            
            
            

            
            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeviceUpdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceSerializer)));
            
        }
        
    }
    
}
