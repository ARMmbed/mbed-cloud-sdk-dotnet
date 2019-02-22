# connector_ca - the C# library for the Connect CA API

mbed Cloud Connect CA API allows services to get device credentials.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 3
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using connector_ca.Api;
using connector_ca.Client;
using connector_ca.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out connector_ca.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using connector_ca.Api;
using connector_ca.Client;
using connector_ca.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DeveloperCertificateApi();
            var authorization = authorization_example;  // string | Bearer {Access Token}. 
            var body = new DeveloperCertificateRequestData(); // DeveloperCertificateRequestData | 

            try
            {
                // Create a new developer certificate to connect to the bootstrap server.
                DeveloperCertificateResponseData result = apiInstance.CreateDeveloperCertificate(authorization, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeveloperCertificateApi.CreateDeveloperCertificate: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://api.us-east-1.mbedcloud.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DeveloperCertificateApi* | [**CreateDeveloperCertificate**](docs/DeveloperCertificateApi.md#createdevelopercertificate) | **POST** /v3/developer-certificates | Create a new developer certificate to connect to the bootstrap server.
*DeveloperCertificateApi* | [**GetDeveloperCertificate**](docs/DeveloperCertificateApi.md#getdevelopercertificate) | **GET** /v3/developer-certificates/{developerCertificateId} | Fetch an existing developer certificate to connect to the bootstrap server.
*ServerCredentialsApi* | [**GetAllServerCredentials**](docs/ServerCredentialsApi.md#getallservercredentials) | **GET** /v3/server-credentials | Fetch all (Bootstrap and LWM2M) server credentials.
*ServerCredentialsApi* | [**GetBootstrapServerCredentials**](docs/ServerCredentialsApi.md#getbootstrapservercredentials) | **GET** /v3/server-credentials/bootstrap | Fetch bootstrap server credentials.
*ServerCredentialsApi* | [**GetL2M2MServerCredentials**](docs/ServerCredentialsApi.md#getl2m2mservercredentials) | **GET** /v3/server-credentials/lwm2m | Fetch LWM2M server credentials.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AllServerCredentialsResponseData](docs/AllServerCredentialsResponseData.md)
 - [Model.CredentialsResponseData](docs/CredentialsResponseData.md)
 - [Model.DeveloperCertificateRequestData](docs/DeveloperCertificateRequestData.md)
 - [Model.DeveloperCertificateResponseData](docs/DeveloperCertificateResponseData.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.Field](docs/Field.md)
 - [Model.ServerCredentialsResponseData](docs/ServerCredentialsResponseData.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Bearer"></a>
### Bearer

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header
