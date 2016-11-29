using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using iam.Client;
using iam.Model;

namespace iam.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountAdminApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a new user.
        /// </summary>
        /// <remarks>
        /// Endpoint for creating a new user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A user object with attributes.</param>
        /// <returns>UserInfoResp</returns>
        UserInfoResp CreateUser (UserInfoReq body);
  
        /// <summary>
        /// Create a new user.
        /// </summary>
        /// <remarks>
        /// Endpoint for creating a new user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A user object with attributes.</param>
        /// <returns>ApiResponse of UserInfoResp</returns>
        ApiResponse<UserInfoResp> CreateUserWithHttpInfo (UserInfoReq body);
        
        /// <summary>
        /// Delete a user.
        /// </summary>
        /// <remarks>
        /// Endpoint for deleting a user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user to be deleted.</param>
        /// <returns></returns>
        void DeleteUser (string userId);
  
        /// <summary>
        /// Delete a user.
        /// </summary>
        /// <remarks>
        /// Endpoint for deleting a user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteUserWithHttpInfo (string userId);
        
        /// <summary>
        /// Get the details of all users.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving the details of all users.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserInfoRespList</returns>
        UserInfoRespList GetAllUsers ();
  
        /// <summary>
        /// Get the details of all users.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving the details of all users.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserInfoRespList</returns>
        ApiResponse<UserInfoRespList> GetAllUsersWithHttpInfo ();
        
        /// <summary>
        /// Details of a user.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving the details of a user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID or name of the user whose details are retrieved.</param>
        /// <returns>UserInfoResp</returns>
        UserInfoResp GetUser (string userId);
  
        /// <summary>
        /// Details of a user.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving the details of a user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID or name of the user whose details are retrieved.</param>
        /// <returns>ApiResponse of UserInfoResp</returns>
        ApiResponse<UserInfoResp> GetUserWithHttpInfo (string userId);
        
        /// <summary>
        /// Updates attributes of the account.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating the account.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details of the account to be updated.</param>
        /// <returns>UpdatedResponse</returns>
        UpdatedResponse UpdateMyAccount (AccountUpdateReq body);
  
        /// <summary>
        /// Updates attributes of the account.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating the account.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details of the account to be updated.</param>
        /// <returns>ApiResponse of UpdatedResponse</returns>
        ApiResponse<UpdatedResponse> UpdateMyAccountWithHttpInfo (AccountUpdateReq body);
        
        /// <summary>
        /// Update user details.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating user details.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose details are updated.</param>
        /// <param name="body">A user object with attributes.</param>
        /// <returns>UserInfoResp</returns>
        UserInfoResp UpdateUser (string userId, UserInfoReq body);
  
        /// <summary>
        /// Update user details.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating user details.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose details are updated.</param>
        /// <param name="body">A user object with attributes.</param>
        /// <returns>ApiResponse of UserInfoResp</returns>
        ApiResponse<UserInfoResp> UpdateUserWithHttpInfo (string userId, UserInfoReq body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a new user.
        /// </summary>
        /// <remarks>
        /// Endpoint for creating a new user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A user object with attributes.</param>
        /// <returns>Task of UserInfoResp</returns>
        System.Threading.Tasks.Task<UserInfoResp> CreateUserAsync (UserInfoReq body);

        /// <summary>
        /// Create a new user.
        /// </summary>
        /// <remarks>
        /// Endpoint for creating a new user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A user object with attributes.</param>
        /// <returns>Task of ApiResponse (UserInfoResp)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserInfoResp>> CreateUserAsyncWithHttpInfo (UserInfoReq body);
        
        /// <summary>
        /// Delete a user.
        /// </summary>
        /// <remarks>
        /// Endpoint for deleting a user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteUserAsync (string userId);

        /// <summary>
        /// Delete a user.
        /// </summary>
        /// <remarks>
        /// Endpoint for deleting a user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserAsyncWithHttpInfo (string userId);
        
        /// <summary>
        /// Get the details of all users.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving the details of all users.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserInfoRespList</returns>
        System.Threading.Tasks.Task<UserInfoRespList> GetAllUsersAsync ();

        /// <summary>
        /// Get the details of all users.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving the details of all users.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserInfoRespList)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserInfoRespList>> GetAllUsersAsyncWithHttpInfo ();
        
        /// <summary>
        /// Details of a user.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving the details of a user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID or name of the user whose details are retrieved.</param>
        /// <returns>Task of UserInfoResp</returns>
        System.Threading.Tasks.Task<UserInfoResp> GetUserAsync (string userId);

        /// <summary>
        /// Details of a user.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving the details of a user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID or name of the user whose details are retrieved.</param>
        /// <returns>Task of ApiResponse (UserInfoResp)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserInfoResp>> GetUserAsyncWithHttpInfo (string userId);
        
        /// <summary>
        /// Updates attributes of the account.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating the account.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details of the account to be updated.</param>
        /// <returns>Task of UpdatedResponse</returns>
        System.Threading.Tasks.Task<UpdatedResponse> UpdateMyAccountAsync (AccountUpdateReq body);

        /// <summary>
        /// Updates attributes of the account.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating the account.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details of the account to be updated.</param>
        /// <returns>Task of ApiResponse (UpdatedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpdatedResponse>> UpdateMyAccountAsyncWithHttpInfo (AccountUpdateReq body);
        
        /// <summary>
        /// Update user details.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating user details.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose details are updated.</param>
        /// <param name="body">A user object with attributes.</param>
        /// <returns>Task of UserInfoResp</returns>
        System.Threading.Tasks.Task<UserInfoResp> UpdateUserAsync (string userId, UserInfoReq body);

        /// <summary>
        /// Update user details.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating user details.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose details are updated.</param>
        /// <param name="body">A user object with attributes.</param>
        /// <returns>Task of ApiResponse (UserInfoResp)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserInfoResp>> UpdateUserAsyncWithHttpInfo (string userId, UserInfoReq body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountAdminApi : IAccountAdminApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAdminApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountAdminApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAdminApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountAdminApi(Configuration configuration = null)
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
        /// Create a new user. Endpoint for creating a new user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A user object with attributes.</param> 
        /// <returns>UserInfoResp</returns>
        public UserInfoResp CreateUser (UserInfoReq body)
        {
             ApiResponse<UserInfoResp> localVarResponse = CreateUserWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new user. Endpoint for creating a new user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A user object with attributes.</param> 
        /// <returns>ApiResponse of UserInfoResp</returns>
        public ApiResponse< UserInfoResp > CreateUserWithHttpInfo (UserInfoReq body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AccountAdminApi->CreateUser");
            
    
            var localVarPath = "/v3/users";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

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
                throw new ApiException (localVarStatusCode, "Error calling CreateUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfoResp)));
            
        }

        
        /// <summary>
        /// Create a new user. Endpoint for creating a new user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A user object with attributes.</param>
        /// <returns>Task of UserInfoResp</returns>
        public async System.Threading.Tasks.Task<UserInfoResp> CreateUserAsync (UserInfoReq body)
        {
             ApiResponse<UserInfoResp> localVarResponse = await CreateUserAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new user. Endpoint for creating a new user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A user object with attributes.</param>
        /// <returns>Task of ApiResponse (UserInfoResp)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserInfoResp>> CreateUserAsyncWithHttpInfo (UserInfoReq body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateUser");
            
    
            var localVarPath = "/v3/users";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
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
                throw new ApiException (localVarStatusCode, "Error calling CreateUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfoResp)));
            
        }
        
        /// <summary>
        /// Delete a user. Endpoint for deleting a user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user to be deleted.</param> 
        /// <returns></returns>
        public void DeleteUser (string userId)
        {
             DeleteUserWithHttpInfo(userId);
        }

        /// <summary>
        /// Delete a user. Endpoint for deleting a user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteUserWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AccountAdminApi->DeleteUser");
            
    
            var localVarPath = "/v3/users/{user-id}";
    
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
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (userId != null) localVarPathParams.Add("user-id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a user. Endpoint for deleting a user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteUserAsync (string userId)
        {
             await DeleteUserAsyncWithHttpInfo(userId);

        }

        /// <summary>
        /// Delete a user. Endpoint for deleting a user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling DeleteUser");
            
    
            var localVarPath = "/v3/users/{user-id}";
    
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
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (userId != null) localVarPathParams.Add("user-id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get the details of all users. Endpoint for retrieving the details of all users.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserInfoRespList</returns>
        public UserInfoRespList GetAllUsers ()
        {
             ApiResponse<UserInfoRespList> localVarResponse = GetAllUsersWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the details of all users. Endpoint for retrieving the details of all users.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserInfoRespList</returns>
        public ApiResponse< UserInfoRespList > GetAllUsersWithHttpInfo ()
        {
            
    
            var localVarPath = "/v3/users";
    
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
                "application/json"
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAllUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAllUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserInfoRespList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfoRespList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfoRespList)));
            
        }

        
        /// <summary>
        /// Get the details of all users. Endpoint for retrieving the details of all users.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserInfoRespList</returns>
        public async System.Threading.Tasks.Task<UserInfoRespList> GetAllUsersAsync ()
        {
             ApiResponse<UserInfoRespList> localVarResponse = await GetAllUsersAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the details of all users. Endpoint for retrieving the details of all users.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserInfoRespList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserInfoRespList>> GetAllUsersAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/v3/users";
    
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
                "application/json"
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAllUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAllUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserInfoRespList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfoRespList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfoRespList)));
            
        }
        
        /// <summary>
        /// Details of a user. Endpoint for retrieving the details of a user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID or name of the user whose details are retrieved.</param> 
        /// <returns>UserInfoResp</returns>
        public UserInfoResp GetUser (string userId)
        {
             ApiResponse<UserInfoResp> localVarResponse = GetUserWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Details of a user. Endpoint for retrieving the details of a user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID or name of the user whose details are retrieved.</param> 
        /// <returns>ApiResponse of UserInfoResp</returns>
        public ApiResponse< UserInfoResp > GetUserWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AccountAdminApi->GetUser");
            
    
            var localVarPath = "/v3/users/{user-id}";
    
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
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (userId != null) localVarPathParams.Add("user-id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfoResp)));
            
        }

        
        /// <summary>
        /// Details of a user. Endpoint for retrieving the details of a user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID or name of the user whose details are retrieved.</param>
        /// <returns>Task of UserInfoResp</returns>
        public async System.Threading.Tasks.Task<UserInfoResp> GetUserAsync (string userId)
        {
             ApiResponse<UserInfoResp> localVarResponse = await GetUserAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Details of a user. Endpoint for retrieving the details of a user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID or name of the user whose details are retrieved.</param>
        /// <returns>Task of ApiResponse (UserInfoResp)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserInfoResp>> GetUserAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUser");
            
    
            var localVarPath = "/v3/users/{user-id}";
    
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
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (userId != null) localVarPathParams.Add("user-id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfoResp)));
            
        }
        
        /// <summary>
        /// Updates attributes of the account. Endpoint for updating the account.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details of the account to be updated.</param> 
        /// <returns>UpdatedResponse</returns>
        public UpdatedResponse UpdateMyAccount (AccountUpdateReq body)
        {
             ApiResponse<UpdatedResponse> localVarResponse = UpdateMyAccountWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates attributes of the account. Endpoint for updating the account.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details of the account to be updated.</param> 
        /// <returns>ApiResponse of UpdatedResponse</returns>
        public ApiResponse< UpdatedResponse > UpdateMyAccountWithHttpInfo (AccountUpdateReq body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AccountAdminApi->UpdateMyAccount");
            
    
            var localVarPath = "/v3/accounts/me";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

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
                throw new ApiException (localVarStatusCode, "Error calling UpdateMyAccount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateMyAccount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UpdatedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdatedResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdatedResponse)));
            
        }

        
        /// <summary>
        /// Updates attributes of the account. Endpoint for updating the account.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details of the account to be updated.</param>
        /// <returns>Task of UpdatedResponse</returns>
        public async System.Threading.Tasks.Task<UpdatedResponse> UpdateMyAccountAsync (AccountUpdateReq body)
        {
             ApiResponse<UpdatedResponse> localVarResponse = await UpdateMyAccountAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates attributes of the account. Endpoint for updating the account.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Details of the account to be updated.</param>
        /// <returns>Task of ApiResponse (UpdatedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpdatedResponse>> UpdateMyAccountAsyncWithHttpInfo (AccountUpdateReq body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMyAccount");
            
    
            var localVarPath = "/v3/accounts/me";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateMyAccount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateMyAccount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UpdatedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdatedResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdatedResponse)));
            
        }
        
        /// <summary>
        /// Update user details. Endpoint for updating user details.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose details are updated.</param> 
        /// <param name="body">A user object with attributes.</param> 
        /// <returns>UserInfoResp</returns>
        public UserInfoResp UpdateUser (string userId, UserInfoReq body)
        {
             ApiResponse<UserInfoResp> localVarResponse = UpdateUserWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update user details. Endpoint for updating user details.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose details are updated.</param> 
        /// <param name="body">A user object with attributes.</param> 
        /// <returns>ApiResponse of UserInfoResp</returns>
        public ApiResponse< UserInfoResp > UpdateUserWithHttpInfo (string userId, UserInfoReq body)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AccountAdminApi->UpdateUser");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AccountAdminApi->UpdateUser");
            
    
            var localVarPath = "/v3/users/{user-id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (userId != null) localVarPathParams.Add("user-id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

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
                throw new ApiException (localVarStatusCode, "Error calling UpdateUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfoResp)));
            
        }

        
        /// <summary>
        /// Update user details. Endpoint for updating user details.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose details are updated.</param>
        /// <param name="body">A user object with attributes.</param>
        /// <returns>Task of UserInfoResp</returns>
        public async System.Threading.Tasks.Task<UserInfoResp> UpdateUserAsync (string userId, UserInfoReq body)
        {
             ApiResponse<UserInfoResp> localVarResponse = await UpdateUserAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update user details. Endpoint for updating user details.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose details are updated.</param>
        /// <param name="body">A user object with attributes.</param>
        /// <returns>Task of ApiResponse (UserInfoResp)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserInfoResp>> UpdateUserAsyncWithHttpInfo (string userId, UserInfoReq body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateUser");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateUser");
            
    
            var localVarPath = "/v3/users/{user-id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (userId != null) localVarPathParams.Add("user-id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfoResp)));
            
        }
        
    }
    
}
