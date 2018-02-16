# enrollment - the C# library for the Enrollment API

Mbed Cloud Connect Enrollment Service allows users to claim the ownership of a device which is not yet assigned to an account. A device without an assigned account can be a device purchased from the open market (OEM dealer) or a device trasferred from an account to another. More information in [Device overship: First-to-claim](TODO: link needed) document. 

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
using enrollment.Api;
using enrollment.Client;
using enrollment.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out enrollment.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using enrollment.Api;
using enrollment.Client;
using enrollment.Model;

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

            var apiInstance = new PublicAPIApi();
            var limit = 56;  // int? | Number of results to be returned. Between 2 and 1000, inclusive. (optional) 
            var after = after_example;  // string | Entity ID to fetch after. (optional) 
            var order = order_example;  // string | ASC or DESC (optional)  (default to ASC)
            var include = include_example;  // string | Comma separate additional data to return. Currently supported: total_count (optional) 

            try
            {
                // Get enrollment list.
                EnrollmentIdentities result = apiInstance.V3DeviceEnrollmentsGet(limit, after, order, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicAPIApi.V3DeviceEnrollmentsGet: " + e.Message );
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
*PublicAPIApi* | [**V3DeviceEnrollmentsGet**](docs/PublicAPIApi.md#v3deviceenrollmentsget) | **GET** /v3/device-enrollments | Get enrollment list.
*PublicAPIApi* | [**V3DeviceEnrollmentsIdDelete**](docs/PublicAPIApi.md#v3deviceenrollmentsiddelete) | **DELETE** /v3/device-enrollments/{id} | Delete an enrollment by ID.
*PublicAPIApi* | [**V3DeviceEnrollmentsIdGet**](docs/PublicAPIApi.md#v3deviceenrollmentsidget) | **GET** /v3/device-enrollments/{id} | Get details of an enrollment by ID.
*PublicAPIApi* | [**V3DeviceEnrollmentsPost**](docs/PublicAPIApi.md#v3deviceenrollmentspost) | **POST** /v3/device-enrollments | Place an enrollment claim for one or several devices.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.EnrollmentId](docs/EnrollmentId.md)
 - [Model.EnrollmentIdentities](docs/EnrollmentIdentities.md)
 - [Model.EnrollmentIdentity](docs/EnrollmentIdentity.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.Field](docs/Field.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Bearer"></a>
### Bearer

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header
