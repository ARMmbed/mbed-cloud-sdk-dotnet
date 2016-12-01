using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using device_query_service.Client;
using device_query_service.Model;

namespace device_query_service.Api
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
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Create device query&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the query</param>
        /// <param name="query">The device query</param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="queryId">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>DeviceQuerySerializer</returns>
        DeviceQuerySerializer DeviceQueryCreate (string name, string query, string description = null, string _object = null, string queryId = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Create device query&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the query</param>
        /// <param name="query">The device query</param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="queryId">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>ApiResponse of DeviceQuerySerializer</returns>
        ApiResponse<DeviceQuerySerializer> DeviceQueryCreateWithHttpInfo (string name, string query, string description = null, string _object = null, string queryId = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Delete device query&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <returns>DeviceQuerySerializer</returns>
        DeviceQuerySerializer DeviceQueryDestroy (string queryId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Delete device query&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <returns>ApiResponse of DeviceQuerySerializer</returns>
        ApiResponse<DeviceQuerySerializer> DeviceQueryDestroyWithHttpInfo (string queryId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;List all device queries. The result will be paged into pages of 100.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="query"> (optional)</param>
        /// <param name="queryId"> (optional)</param>
        /// <returns>List&lt;DeviceQuerySerializer&gt;</returns>
        List<DeviceQuerySerializer> DeviceQueryList (string description = null, string createdAt = null, string updatedAt = null, string etag = null, string name = null, string _object = null, string query = null, string queryId = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;List all device queries. The result will be paged into pages of 100.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="query"> (optional)</param>
        /// <param name="queryId"> (optional)</param>
        /// <returns>ApiResponse of List&lt;DeviceQuerySerializer&gt;</returns>
        ApiResponse<List<DeviceQuerySerializer>> DeviceQueryListWithHttpInfo (string description = null, string createdAt = null, string updatedAt = null, string etag = null, string name = null, string _object = null, string query = null, string queryId = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query fields&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="name">The name of the query (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="query">The device query (optional)</param>
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>DeviceQuerySerializer</returns>
        DeviceQuerySerializer DeviceQueryPartialUpdate (string queryId, string description = null, string name = null, string _object = null, string query = null, string queryId2 = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query fields&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="name">The name of the query (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="query">The device query (optional)</param>
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>ApiResponse of DeviceQuerySerializer</returns>
        ApiResponse<DeviceQuerySerializer> DeviceQueryPartialUpdateWithHttpInfo (string queryId, string description = null, string name = null, string _object = null, string query = null, string queryId2 = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Retrieve device query.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <returns>DeviceQuerySerializer</returns>
        DeviceQuerySerializer DeviceQueryRetrieve (string queryId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Retrieve device query.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <returns>ApiResponse of DeviceQuerySerializer</returns>
        ApiResponse<DeviceQuerySerializer> DeviceQueryRetrieveWithHttpInfo (string queryId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <param name="name">The name of the query</param>
        /// <param name="query">The device query</param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>DeviceQuerySerializer</returns>
        DeviceQuerySerializer DeviceQueryUpdate (string queryId, string name, string query, string description = null, string _object = null, string queryId2 = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <param name="name">The name of the query</param>
        /// <param name="query">The device query</param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>ApiResponse of DeviceQuerySerializer</returns>
        ApiResponse<DeviceQuerySerializer> DeviceQueryUpdateWithHttpInfo (string queryId, string name, string query, string description = null, string _object = null, string queryId2 = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Create device query&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the query</param>
        /// <param name="query">The device query</param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="queryId">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>Task of DeviceQuerySerializer</returns>
        System.Threading.Tasks.Task<DeviceQuerySerializer> DeviceQueryCreateAsync (string name, string query, string description = null, string _object = null, string queryId = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Create device query&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the query</param>
        /// <param name="query">The device query</param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="queryId">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>Task of ApiResponse (DeviceQuerySerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceQuerySerializer>> DeviceQueryCreateAsyncWithHttpInfo (string name, string query, string description = null, string _object = null, string queryId = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Delete device query&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <returns>Task of DeviceQuerySerializer</returns>
        System.Threading.Tasks.Task<DeviceQuerySerializer> DeviceQueryDestroyAsync (string queryId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Delete device query&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <returns>Task of ApiResponse (DeviceQuerySerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceQuerySerializer>> DeviceQueryDestroyAsyncWithHttpInfo (string queryId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;List all device queries. The result will be paged into pages of 100.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="query"> (optional)</param>
        /// <param name="queryId"> (optional)</param>
        /// <returns>Task of List&lt;DeviceQuerySerializer&gt;</returns>
        System.Threading.Tasks.Task<List<DeviceQuerySerializer>> DeviceQueryListAsync (string description = null, string createdAt = null, string updatedAt = null, string etag = null, string name = null, string _object = null, string query = null, string queryId = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;List all device queries. The result will be paged into pages of 100.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="query"> (optional)</param>
        /// <param name="queryId"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;DeviceQuerySerializer&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<DeviceQuerySerializer>>> DeviceQueryListAsyncWithHttpInfo (string description = null, string createdAt = null, string updatedAt = null, string etag = null, string name = null, string _object = null, string query = null, string queryId = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query fields&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="name">The name of the query (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="query">The device query (optional)</param>
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>Task of DeviceQuerySerializer</returns>
        System.Threading.Tasks.Task<DeviceQuerySerializer> DeviceQueryPartialUpdateAsync (string queryId, string description = null, string name = null, string _object = null, string query = null, string queryId2 = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query fields&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="name">The name of the query (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="query">The device query (optional)</param>
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>Task of ApiResponse (DeviceQuerySerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceQuerySerializer>> DeviceQueryPartialUpdateAsyncWithHttpInfo (string queryId, string description = null, string name = null, string _object = null, string query = null, string queryId2 = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Retrieve device query.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <returns>Task of DeviceQuerySerializer</returns>
        System.Threading.Tasks.Task<DeviceQuerySerializer> DeviceQueryRetrieveAsync (string queryId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Retrieve device query.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <returns>Task of ApiResponse (DeviceQuerySerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceQuerySerializer>> DeviceQueryRetrieveAsyncWithHttpInfo (string queryId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <param name="name">The name of the query</param>
        /// <param name="query">The device query</param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>Task of DeviceQuerySerializer</returns>
        System.Threading.Tasks.Task<DeviceQuerySerializer> DeviceQueryUpdateAsync (string queryId, string name, string query, string description = null, string _object = null, string queryId2 = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <param name="name">The name of the query</param>
        /// <param name="query">The device query</param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>Task of ApiResponse (DeviceQuerySerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeviceQuerySerializer>> DeviceQueryUpdateAsyncWithHttpInfo (string queryId, string name, string query, string description = null, string _object = null, string queryId2 = null);
        
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
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Create device query&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the query</param> 
        /// <param name="query">The device query</param> 
        /// <param name="description">The description of the object (optional)</param> 
        /// <param name="_object">The API resource entity (optional)</param> 
        /// <param name="queryId">DEPRECATED: The ID of the query (optional)</param> 
        /// <returns>DeviceQuerySerializer</returns>
        public DeviceQuerySerializer DeviceQueryCreate (string name, string query, string description = null, string _object = null, string queryId = null)
        {
             ApiResponse<DeviceQuerySerializer> localVarResponse = DeviceQueryCreateWithHttpInfo(name, query, description, _object, queryId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Create device query&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the query</param> 
        /// <param name="query">The device query</param> 
        /// <param name="description">The description of the object (optional)</param> 
        /// <param name="_object">The API resource entity (optional)</param> 
        /// <param name="queryId">DEPRECATED: The ID of the query (optional)</param> 
        /// <returns>ApiResponse of DeviceQuerySerializer</returns>
        public ApiResponse< DeviceQuerySerializer > DeviceQueryCreateWithHttpInfo (string name, string query, string description = null, string _object = null, string queryId = null)
        {
            
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling DefaultApi->DeviceQueryCreate");
            
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling DefaultApi->DeviceQueryCreate");
            
    
            var localVarPath = "/v3/device-queries/";
    
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
            
            
            
            if (description != null) localVarFormParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // form parameter
            if (name != null) localVarFormParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (_object != null) localVarFormParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // form parameter
            if (query != null) localVarFormParams.Add("query", Configuration.ApiClient.ParameterToString(query)); // form parameter
            if (queryId != null) localVarFormParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId)); // form parameter
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryCreate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryCreate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceQuerySerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceQuerySerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceQuerySerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Create device query&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the query</param>
        /// <param name="query">The device query</param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="queryId">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>Task of DeviceQuerySerializer</returns>
        public async System.Threading.Tasks.Task<DeviceQuerySerializer> DeviceQueryCreateAsync (string name, string query, string description = null, string _object = null, string queryId = null)
        {
             ApiResponse<DeviceQuerySerializer> localVarResponse = await DeviceQueryCreateAsyncWithHttpInfo(name, query, description, _object, queryId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Create device query&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the query</param>
        /// <param name="query">The device query</param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="queryId">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>Task of ApiResponse (DeviceQuerySerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceQuerySerializer>> DeviceQueryCreateAsyncWithHttpInfo (string name, string query, string description = null, string _object = null, string queryId = null)
        {
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeviceQueryCreate");
            // verify the required parameter 'query' is set
            if (query == null) throw new ApiException(400, "Missing required parameter 'query' when calling DeviceQueryCreate");
            
    
            var localVarPath = "/v3/device-queries/";
    
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
            
            
            
            if (description != null) localVarFormParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // form parameter
            if (name != null) localVarFormParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (_object != null) localVarFormParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // form parameter
            if (query != null) localVarFormParams.Add("query", Configuration.ApiClient.ParameterToString(query)); // form parameter
            if (queryId != null) localVarFormParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId)); // form parameter
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryCreate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryCreate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceQuerySerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceQuerySerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceQuerySerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Delete device query&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param> 
        /// <returns>DeviceQuerySerializer</returns>
        public DeviceQuerySerializer DeviceQueryDestroy (string queryId)
        {
             ApiResponse<DeviceQuerySerializer> localVarResponse = DeviceQueryDestroyWithHttpInfo(queryId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Delete device query&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param> 
        /// <returns>ApiResponse of DeviceQuerySerializer</returns>
        public ApiResponse< DeviceQuerySerializer > DeviceQueryDestroyWithHttpInfo (string queryId)
        {
            
            // verify the required parameter 'queryId' is set
            if (queryId == null)
                throw new ApiException(400, "Missing required parameter 'queryId' when calling DefaultApi->DeviceQueryDestroy");
            
    
            var localVarPath = "/v3/device-queries/{query_id}/";
    
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
            if (queryId != null) localVarPathParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryDestroy: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryDestroy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceQuerySerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceQuerySerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceQuerySerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Delete device query&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <returns>Task of DeviceQuerySerializer</returns>
        public async System.Threading.Tasks.Task<DeviceQuerySerializer> DeviceQueryDestroyAsync (string queryId)
        {
             ApiResponse<DeviceQuerySerializer> localVarResponse = await DeviceQueryDestroyAsyncWithHttpInfo(queryId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Delete device query&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <returns>Task of ApiResponse (DeviceQuerySerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceQuerySerializer>> DeviceQueryDestroyAsyncWithHttpInfo (string queryId)
        {
            // verify the required parameter 'queryId' is set
            if (queryId == null) throw new ApiException(400, "Missing required parameter 'queryId' when calling DeviceQueryDestroy");
            
    
            var localVarPath = "/v3/device-queries/{query_id}/";
    
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
            if (queryId != null) localVarPathParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryDestroy: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryDestroy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceQuerySerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceQuerySerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceQuerySerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;List all device queries. The result will be paged into pages of 100.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description"> (optional)</param> 
        /// <param name="createdAt"> (optional)</param> 
        /// <param name="updatedAt"> (optional)</param> 
        /// <param name="etag"> (optional)</param> 
        /// <param name="name"> (optional)</param> 
        /// <param name="_object"> (optional)</param> 
        /// <param name="query"> (optional)</param> 
        /// <param name="queryId"> (optional)</param> 
        /// <returns>List&lt;DeviceQuerySerializer&gt;</returns>
        public List<DeviceQuerySerializer> DeviceQueryList (string description = null, string createdAt = null, string updatedAt = null, string etag = null, string name = null, string _object = null, string query = null, string queryId = null)
        {
             ApiResponse<List<DeviceQuerySerializer>> localVarResponse = DeviceQueryListWithHttpInfo(description, createdAt, updatedAt, etag, name, _object, query, queryId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;List all device queries. The result will be paged into pages of 100.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description"> (optional)</param> 
        /// <param name="createdAt"> (optional)</param> 
        /// <param name="updatedAt"> (optional)</param> 
        /// <param name="etag"> (optional)</param> 
        /// <param name="name"> (optional)</param> 
        /// <param name="_object"> (optional)</param> 
        /// <param name="query"> (optional)</param> 
        /// <param name="queryId"> (optional)</param> 
        /// <returns>ApiResponse of List&lt;DeviceQuerySerializer&gt;</returns>
        public ApiResponse< List<DeviceQuerySerializer> > DeviceQueryListWithHttpInfo (string description = null, string createdAt = null, string updatedAt = null, string etag = null, string name = null, string _object = null, string query = null, string queryId = null)
        {
            
    
            var localVarPath = "/v3/device-queries/";
    
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
            
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (etag != null) localVarQueryParams.Add("etag", Configuration.ApiClient.ParameterToString(etag)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (_object != null) localVarQueryParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // query parameter
            if (query != null) localVarQueryParams.Add("query", Configuration.ApiClient.ParameterToString(query)); // query parameter
            if (queryId != null) localVarQueryParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryList: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryList: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<DeviceQuerySerializer>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DeviceQuerySerializer>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DeviceQuerySerializer>)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;List all device queries. The result will be paged into pages of 100.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="query"> (optional)</param>
        /// <param name="queryId"> (optional)</param>
        /// <returns>Task of List&lt;DeviceQuerySerializer&gt;</returns>
        public async System.Threading.Tasks.Task<List<DeviceQuerySerializer>> DeviceQueryListAsync (string description = null, string createdAt = null, string updatedAt = null, string etag = null, string name = null, string _object = null, string query = null, string queryId = null)
        {
             ApiResponse<List<DeviceQuerySerializer>> localVarResponse = await DeviceQueryListAsyncWithHttpInfo(description, createdAt, updatedAt, etag, name, _object, query, queryId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;List all device queries. The result will be paged into pages of 100.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="description"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="query"> (optional)</param>
        /// <param name="queryId"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;DeviceQuerySerializer&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<DeviceQuerySerializer>>> DeviceQueryListAsyncWithHttpInfo (string description = null, string createdAt = null, string updatedAt = null, string etag = null, string name = null, string _object = null, string query = null, string queryId = null)
        {
            
    
            var localVarPath = "/v3/device-queries/";
    
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
            
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (etag != null) localVarQueryParams.Add("etag", Configuration.ApiClient.ParameterToString(etag)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (_object != null) localVarQueryParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // query parameter
            if (query != null) localVarQueryParams.Add("query", Configuration.ApiClient.ParameterToString(query)); // query parameter
            if (queryId != null) localVarQueryParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryList: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryList: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<DeviceQuerySerializer>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DeviceQuerySerializer>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DeviceQuerySerializer>)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query fields&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param> 
        /// <param name="description">The description of the object (optional)</param> 
        /// <param name="name">The name of the query (optional)</param> 
        /// <param name="_object">The API resource entity (optional)</param> 
        /// <param name="query">The device query (optional)</param> 
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param> 
        /// <returns>DeviceQuerySerializer</returns>
        public DeviceQuerySerializer DeviceQueryPartialUpdate (string queryId, string description = null, string name = null, string _object = null, string query = null, string queryId2 = null)
        {
             ApiResponse<DeviceQuerySerializer> localVarResponse = DeviceQueryPartialUpdateWithHttpInfo(queryId, description, name, _object, query, queryId2);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query fields&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param> 
        /// <param name="description">The description of the object (optional)</param> 
        /// <param name="name">The name of the query (optional)</param> 
        /// <param name="_object">The API resource entity (optional)</param> 
        /// <param name="query">The device query (optional)</param> 
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param> 
        /// <returns>ApiResponse of DeviceQuerySerializer</returns>
        public ApiResponse< DeviceQuerySerializer > DeviceQueryPartialUpdateWithHttpInfo (string queryId, string description = null, string name = null, string _object = null, string query = null, string queryId2 = null)
        {
            
            // verify the required parameter 'queryId' is set
            if (queryId == null)
                throw new ApiException(400, "Missing required parameter 'queryId' when calling DefaultApi->DeviceQueryPartialUpdate");
            
    
            var localVarPath = "/v3/device-queries/{query_id}/";
    
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
            if (queryId != null) localVarPathParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId)); // path parameter
            
            
            
            if (description != null) localVarFormParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // form parameter
            if (name != null) localVarFormParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (_object != null) localVarFormParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // form parameter
            if (query != null) localVarFormParams.Add("query", Configuration.ApiClient.ParameterToString(query)); // form parameter
            if (queryId2 != null) localVarFormParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId2)); // form parameter
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryPartialUpdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryPartialUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceQuerySerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceQuerySerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceQuerySerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query fields&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="name">The name of the query (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="query">The device query (optional)</param>
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>Task of DeviceQuerySerializer</returns>
        public async System.Threading.Tasks.Task<DeviceQuerySerializer> DeviceQueryPartialUpdateAsync (string queryId, string description = null, string name = null, string _object = null, string query = null, string queryId2 = null)
        {
             ApiResponse<DeviceQuerySerializer> localVarResponse = await DeviceQueryPartialUpdateAsyncWithHttpInfo(queryId, description, name, _object, query, queryId2);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query fields&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="name">The name of the query (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="query">The device query (optional)</param>
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>Task of ApiResponse (DeviceQuerySerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceQuerySerializer>> DeviceQueryPartialUpdateAsyncWithHttpInfo (string queryId, string description = null, string name = null, string _object = null, string query = null, string queryId2 = null)
        {
            // verify the required parameter 'queryId' is set
            if (queryId == null) throw new ApiException(400, "Missing required parameter 'queryId' when calling DeviceQueryPartialUpdate");
            
    
            var localVarPath = "/v3/device-queries/{query_id}/";
    
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
            if (queryId != null) localVarPathParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId)); // path parameter
            
            
            
            if (description != null) localVarFormParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // form parameter
            if (name != null) localVarFormParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (_object != null) localVarFormParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // form parameter
            if (query != null) localVarFormParams.Add("query", Configuration.ApiClient.ParameterToString(query)); // form parameter
            if (queryId2 != null) localVarFormParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId2)); // form parameter
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryPartialUpdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryPartialUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceQuerySerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceQuerySerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceQuerySerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Retrieve device query.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param> 
        /// <returns>DeviceQuerySerializer</returns>
        public DeviceQuerySerializer DeviceQueryRetrieve (string queryId)
        {
             ApiResponse<DeviceQuerySerializer> localVarResponse = DeviceQueryRetrieveWithHttpInfo(queryId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Retrieve device query.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param> 
        /// <returns>ApiResponse of DeviceQuerySerializer</returns>
        public ApiResponse< DeviceQuerySerializer > DeviceQueryRetrieveWithHttpInfo (string queryId)
        {
            
            // verify the required parameter 'queryId' is set
            if (queryId == null)
                throw new ApiException(400, "Missing required parameter 'queryId' when calling DefaultApi->DeviceQueryRetrieve");
            
    
            var localVarPath = "/v3/device-queries/{query_id}/";
    
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
            if (queryId != null) localVarPathParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryRetrieve: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryRetrieve: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceQuerySerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceQuerySerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceQuerySerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Retrieve device query.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <returns>Task of DeviceQuerySerializer</returns>
        public async System.Threading.Tasks.Task<DeviceQuerySerializer> DeviceQueryRetrieveAsync (string queryId)
        {
             ApiResponse<DeviceQuerySerializer> localVarResponse = await DeviceQueryRetrieveAsyncWithHttpInfo(queryId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Retrieve device query.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <returns>Task of ApiResponse (DeviceQuerySerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceQuerySerializer>> DeviceQueryRetrieveAsyncWithHttpInfo (string queryId)
        {
            // verify the required parameter 'queryId' is set
            if (queryId == null) throw new ApiException(400, "Missing required parameter 'queryId' when calling DeviceQueryRetrieve");
            
    
            var localVarPath = "/v3/device-queries/{query_id}/";
    
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
            if (queryId != null) localVarPathParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryRetrieve: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryRetrieve: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceQuerySerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceQuerySerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceQuerySerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param> 
        /// <param name="name">The name of the query</param> 
        /// <param name="query">The device query</param> 
        /// <param name="description">The description of the object (optional)</param> 
        /// <param name="_object">The API resource entity (optional)</param> 
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param> 
        /// <returns>DeviceQuerySerializer</returns>
        public DeviceQuerySerializer DeviceQueryUpdate (string queryId, string name, string query, string description = null, string _object = null, string queryId2 = null)
        {
             ApiResponse<DeviceQuerySerializer> localVarResponse = DeviceQueryUpdateWithHttpInfo(queryId, name, query, description, _object, queryId2);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param> 
        /// <param name="name">The name of the query</param> 
        /// <param name="query">The device query</param> 
        /// <param name="description">The description of the object (optional)</param> 
        /// <param name="_object">The API resource entity (optional)</param> 
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param> 
        /// <returns>ApiResponse of DeviceQuerySerializer</returns>
        public ApiResponse< DeviceQuerySerializer > DeviceQueryUpdateWithHttpInfo (string queryId, string name, string query, string description = null, string _object = null, string queryId2 = null)
        {
            
            // verify the required parameter 'queryId' is set
            if (queryId == null)
                throw new ApiException(400, "Missing required parameter 'queryId' when calling DefaultApi->DeviceQueryUpdate");
            
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling DefaultApi->DeviceQueryUpdate");
            
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling DefaultApi->DeviceQueryUpdate");
            
    
            var localVarPath = "/v3/device-queries/{query_id}/";
    
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
            if (queryId != null) localVarPathParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId)); // path parameter
            
            
            
            if (description != null) localVarFormParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // form parameter
            if (name != null) localVarFormParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (_object != null) localVarFormParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // form parameter
            if (query != null) localVarFormParams.Add("query", Configuration.ApiClient.ParameterToString(query)); // form parameter
            if (queryId2 != null) localVarFormParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId2)); // form parameter
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryUpdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeviceQuerySerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceQuerySerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceQuerySerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <param name="name">The name of the query</param>
        /// <param name="query">The device query</param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>Task of DeviceQuerySerializer</returns>
        public async System.Threading.Tasks.Task<DeviceQuerySerializer> DeviceQueryUpdateAsync (string queryId, string name, string query, string description = null, string _object = null, string queryId2 = null)
        {
             ApiResponse<DeviceQuerySerializer> localVarResponse = await DeviceQueryUpdateAsyncWithHttpInfo(queryId, name, query, description, _object, queryId2);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating device queries.  &lt;/p&gt;\n&lt;p&gt;Update device query.&lt;/p&gt;
        /// </summary>
        /// <exception cref="device_query_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryId"></param>
        /// <param name="name">The name of the query</param>
        /// <param name="query">The device query</param>
        /// <param name="description">The description of the object (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="queryId2">DEPRECATED: The ID of the query (optional)</param>
        /// <returns>Task of ApiResponse (DeviceQuerySerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeviceQuerySerializer>> DeviceQueryUpdateAsyncWithHttpInfo (string queryId, string name, string query, string description = null, string _object = null, string queryId2 = null)
        {
            // verify the required parameter 'queryId' is set
            if (queryId == null) throw new ApiException(400, "Missing required parameter 'queryId' when calling DeviceQueryUpdate");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeviceQueryUpdate");
            // verify the required parameter 'query' is set
            if (query == null) throw new ApiException(400, "Missing required parameter 'query' when calling DeviceQueryUpdate");
            
    
            var localVarPath = "/v3/device-queries/{query_id}/";
    
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
            if (queryId != null) localVarPathParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId)); // path parameter
            
            
            
            if (description != null) localVarFormParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // form parameter
            if (name != null) localVarFormParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (_object != null) localVarFormParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // form parameter
            if (query != null) localVarFormParams.Add("query", Configuration.ApiClient.ParameterToString(query)); // form parameter
            if (queryId2 != null) localVarFormParams.Add("query_id", Configuration.ApiClient.ParameterToString(queryId2)); // form parameter
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryUpdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeviceQueryUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeviceQuerySerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeviceQuerySerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeviceQuerySerializer)));
            
        }
        
    }
    
}
