2.2.1 (2019-07-19)
==================

### Bugfixes

- Change exceptions in startNotifications to logs. (#1807191541)

- Add DeliveryMethod option to ConnectConfig (#1807191542)

### Improved Documentation

- Update examples of the subscribe interface (#1707191610)

### Misc

- #1106191635


2.2.0 (2019-06-07)
==================

### Features

- Add support for branding in foundation (#2031)

- add timeout to connect functions (#2363)

### Improved Documentation

- Add legacy examples to common documentation (#1931)


# Changelog

The application is hosted on Nuget at https://www.nuget.org/packages/Mbed.Cloud.SDK and can be installed using the dotnet cli:

```
$ dotnet add package Mbed.Cloud.SDK
```

This news file contains a log of notable changes to the SDK. Please see [nuget history for mbed-cloud-sdk](https://www.nuget.org/packages/Mbed.Cloud.SDK/) for 
a list of versions that have been released.

[//]: # (begin_release_notes)

2.1.0 (2019-05-17)
======================

### Features

- First to Claim - to bulk upload for Enrolment Identities added to the
  _Foundation Interface_. (#1162)

- Backwards compatibility update for field renames in the Enrollment API.
  (#1392)

- First to Claim - to bulk delete for Enrolment Identities added to the
  _Foundation Interface_. (#1432)

- Certificate entities added to the _Foundation Interface_. (#1438)

- Update Campaigns statistics summary and events added to the _Foundation
  Interface_. (#1467)

- Introduction of the _Foundation Interface_ which adds a new 'Entities' based
  interface. (#1567)

- Addition of server credentials entity to the _Foundation Interface_ including
  ability to get all credentials in a single resource. (#1604)

- Account Management entities to support Aggregators / Sub-Tenant accounts
  added to the _Foundation Interface_. (#1605)

- Device Events entity added to the _Foundation Interface_. (#1768)

- Addition of device entity to the _Foundation SDK_ and support added for
  Certificate Renew. (#1827)

- Pelion Device Management rebranding (previously Mbed Cloud). (#1915)

- Support for Certificate Blacklist (Enrolment Denials) added to the
  _Foundation Interface_. (#1997)

- Device Update support added to the _Foundation Interface_. (#2004)

- Support for filtering list endpoints added to the _Foundation Interface_.
  (#2039)

- Pre-Shared Key (PSK) added to the _Foundation Interface_. (#2339)

### Bugfixes

- Stop 404 being thrown by list resources instead of null (#1)

- use default or minimum value for int default (#2291)

### Misc

- #1951


2.0.2 (2018-11-30)
==================

### Bugfixes

- SetResourceValue and ExecuteResourceValue now use DeviceRequests Api (#1718)

- Now retries for HTTP Status 500 without stopping the notifications up to ~2
  mins (#1891)


2.0.1 (2018-11-22)
==================

### Bugfixes

- Fix issue where paginator can get stuck in infinite loop when paging (#1857)


2.0.0 (2018-08-06)
==================

### Features

- circle 2 (#373)

- Configuration can now be set using a .env file (#927)

- Support for phase two billing endpoints (#1398)


1.2.12 (2018-07-06)
===================

### Features

- Add support for billing endpoints GetReportOverview, GetServicePackages,
  GetQuotaHistory and GetQuotaRemaining. (#1210)
  
### Bugfixes

- ApiClient no longer double serializes a string. (#gh-192)

1.2.11 (2018-06-26)
===================

### Features

- Remove 'CustomProperties' from Account and User. (#1362)

- Support List Pre Shared Keys endpoint. (#631)

1.2.10 (2018-06-01)
=============

### Features

- PaginatedResponse objects used in API list endpoints now takes `MaxResults`
  and `PageSize` to remove the ambiguity of the `limit` parameter. Data
  property in PaginatedResponse has been removed. Please use the iterator
  instead. (#1296)

### Bug Fixes

- Generate TPIP report as part of build. (#1014)

- Update online documentation and fix links to GitHub. (#1097)

- When creating subsequent observers, the SDK nolonger resets subscriptions for all observers. (#1284)

- Remove old value from mfaStatues enum. (#918)

1.2.9 (2018-05-22)
=============

### Features

- Add device bootstrap API. This provides the ability to set Pre-Shared Keys
  for device bring-up. (#1075, #1099)

- Added resource values to subscribe module. See examples folder for usage.
  (#1101)

- New API updates for IAM. (#1225)

- New API updates for MDS. (#1235)

- Manifest upload supports upload of keytable file (#522)

### Improved Documentation

- Add security recommendations to PSK documentation. (#742)


1.2.8 (2018-04-13)
=============

### Features

- Add ability to subscribe to devicve events using the Subscribe interface. See
  Examples folder for usage. (#722)


1.2.7 (2018-04-06)
=============

### Features

- The HTTP header User-Agent is now configured by to contain SDK version
  information, which is passed to the Mbed Cloud. (#634)

- Add ability to subscribe to devicve events using the Subscribe interface. See
  Examples folder for usage. (#722)

# Older Releases:

## 1.2.6

## Deliverables

The application is hosted on Nuget at https://www.nuget.org/packages/Mbed.Cloud.SDK and can be installed using the dotnet cli:

```
$ dotnet add package Mbed.Cloud.SDK --version 1.2.6
```

## Changes

Support Connector Enrollment Service API in SDK
Features supported

- Upload a DeviceId to claim
- View status of claimed devices

### Update

- Uploaded images now have the correct filename on the server

### AccountManagement

- Add new fields to Account 
    - ContractNumber
    - CustomerNumber
    - ExpiryWarning
    - MultifactorAuthenticationStatus
    - NotificationEmails
    - ReferenceNote
    - UpdatedAt
    - CustomProperties
    - SalesContactEmail

- remove following fields from Group
    - LastUpdateTime
    - CreationTime

- Add following fields to Group
    - UpdatedAt

- Add following fields to User
    - CustomProperties

- Following fields on User can be UpdatedAt
    - Password,
    - CustomProperties
    - TwoFactorAuthentication
    - Status
    - Groups

### Certificates

- Add EnrollmentMode field

### ConnectApi

- DeleteSubscriptions now deletes subscribtions by iterating over connected devices.
- Use a different backend api in GetResourceValue to fix the issue with getting a value from cache.

### All modules

- All get and delete methods now return null if not found, instead of throwing an exception

## 1.2.5

### Changes

- Added 'ClaimedAt' field to Device
- Various other minor bug fixes

## 1.2.4

## Deliverables

The application is hosted on Nuget at https://www.nuget.org/packages/Mbed.Cloud.SDK and can be installed using the dotnet cli:

```
$ dotnet add package Mbed.Cloud.SDK --version 1.2.4
```

### Changes

- Upgraded project to .NET Core 2.0!
- Passing 50 new integration tests
- Various bug fixes

### Known Issues

- Testing shows that `get_resource_value` will fail
when the cloud service returns a value directly, rather than
through an open notification channel. This affects all previous versions.
- The only known workaround at present is to ensure the cloud cache is not used by:
- Waiting between calls to get_resource_value
- Reducing [the configured TTL](https://cloud.mbed.com/docs/latest/collecting/handle-resources.html#working-with-the-server-cache) on the cloud client image on the device

## 1.2.3

### Deliverables

The application is hosted on Nuget at https://www.nuget.org/packages/Mbed.Cloud.SDK and can be installed using nuget:

```
$ nuget install Mbed.Cloud.SDK
```

### Changes

- Added webhook notification handler
- Added callbacks to resource subscriptions
- Various bugfixes

### Known Issues

- Testing shows that `get_resource_value` will fail
when the cloud service returns a value directly, rather than
through an open notification channel. This affects all previous versions.
- The only known workaround at present is to ensure the cloud cache is not used by:
- Waiting between calls to get_resource_value
- Reducing [the configured TTL](https://cloud.mbed.com/docs/latest/collecting/handle-resources.html#working-with-the-server-cache) on the cloud client image on the device

## 1.2.2

### Deliverables

The application is hosted on GitHub at https://github.com/ARMmbed/mbed-cloud-sdk-dotnet and can be installed using nuget:

```
$ nuget install Mbed.Cloud.SDK
```

### Changes

- Initial release tracking Mbed Cloud 1.2 APIs
- APIs supported:
  - Account Management
  - Certificates
  - Connect
  - Device Diectory
  - Update
- Environments supported:
  - .Net 4.61

- New API updates for MDS. (#1235)

- Manifest upload supports upload of keytable file (#522)

### Improved Documentation

- Add security recommendations to PSK documentation. (#742)
