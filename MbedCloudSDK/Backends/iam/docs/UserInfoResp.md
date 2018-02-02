# iam.Model.UserInfoResp
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of the user. ENROLLING state indicates that the user is in the middle of the enrollment process. INVITED means that the user has not accepted the invitation request. RESET means that the password must be changed immediately. INACTIVE users are locked out and not permitted to use the system. | 
**Username** | **string** | A username containing alphanumerical letters and -,._@+&#x3D; characters. | [optional] 
**Groups** | **List&lt;string&gt;** | A list of IDs of the groups this user belongs to. | [optional] 
**PasswordChangedTime** | **long?** | A timestamp of the latest change of the user password, in milliseconds. | [optional] 
**EmailVerified** | **bool?** | A flag indicating whether the user&#39;s email address has been verified or not. | [optional] 
**CreatedAt** | **DateTime?** | Creation UTC time RFC3339. | [optional] 
**_Object** | **string** | Entity name: always &#39;user&#39; | 
**IsGtcAccepted** | **bool?** | A flag indicating that the General Terms and Conditions has been accepted. | [optional] 
**AccountId** | **string** | The UUID of the account. | 
**Email** | **string** | The email address. | 
**LoginHistory** | [**List&lt;LoginHistory&gt;**](LoginHistory.md) | Timestamps, succeedings, IP addresses and user agent information of the last five logins of the user, with timestamps in RFC3339 format. | [optional] 
**IsTotpEnabled** | **bool?** | A flag indicating whether 2-factor authentication (TOTP) has been enabled. | [optional] 
**IsMarketingAccepted** | **bool?** | A flag indicating that receiving marketing information has been accepted. | [optional] 
**Etag** | **string** | API resource entity version. | 
**FullName** | **string** | The full name of the user. | [optional] 
**Address** | **string** | Address. | [optional] 
**CreationTime** | **long?** | A timestamp of the user creation in the storage, in milliseconds. | [optional] 
**Password** | **string** | The password when creating a new user. It will be generated when not present in the request. | [optional] 
**PhoneNumber** | **string** | Phone number. | [optional] 
**Id** | **string** | The UUID of the user. | 
**LastLoginTime** | **long?** | A timestamp of the latest login of the user, in milliseconds. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
