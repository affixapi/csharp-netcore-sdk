# AffixApi.Api - the C# library for the Affix API

The affixapi.com API documentation.

# Introduction
Affix API is an OAuth 2.1 application that allows developers to access
customer data, without developers needing to manage or maintain
integrations; or collect login credentials or API keys from users for these
third party systems.

# OAuth 2.1
Affix API follows the [OAuth 2.1 spec](https://datatracker.ietf.org/doc/html/draft-ietf-oauth-v2-1-08).

As an OAuth application, Affix API handles not only both the collection of
sensitive user credentials or API keys, but also builds and maintains the
integrations with the providers, so you don't have to.

# How to obtain an access token
in order to get started, you must:
  - register a `client_id`
  - direct your user to the sign in flow  (`https://connect.affixapi.com`
    [with the appropriate query
    parameters](https://github.com/affixapi/starter-kit/tree/master/connect))
  - capture `authorization_code` we will send to your redirect URI after
    the sign in flow is complete and exchange that `authorization_code` for
    a Bearer token

# Sandbox keys (xhr mode)
### dev
```
eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEveGhyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEveGhyL2dyb3VwcyIsIi8yMDIzLTAzLTAxL3hoci9pZGVudGl0eSIsIi8yMDIzLTAzLTAxL3hoci9wYXlydW5zIiwiLzIwMjMtMDMtMDEveGhyL3BheXJ1bnMvOnBheXJ1bl9pZCIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1iYWxhbmNlcyIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1lbnRyaWVzIiwiLzIwMjMtMDMtMDEveGhyL3RpbWVzaGVldHMiLCIvMjAyMy0wMy0wMS94aHIvd29yay1sb2NhdGlvbnMiXSwidG9rZW4iOiIzODIzNTNlMi05N2ZiLTRmMWEtOTYxYy0zZDI5OTViNzYxMTUiLCJpYXQiOjE3MTE4MTA3MTQsImlzcyI6InB1YmxpY2FwaS1pbnRlcm1lZGlhdGUuZGV2LmVuZ2luZWVyaW5nLmFmZml4YXBpLmNvbSIsInN1YiI6InhociIsImF1ZCI6IjNGREFFREY5LTFEQ0E0RjU0LTg3OTQ5RjZBLTQxMDI3NjQzIn0.zUJPaT6IxcIdr8b9iO6u-Rr5I-ohTHPYTrQGrgOFghbEbovItiwr9Wk479GnJVJc3WR8bxAwUMAE4Ul6Okdk6Q
```

#### `employees` endpoint sample:
```
curl - -fail \\
  -X GET \\
  -H 'Authorization: Bearer eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEveGhyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEveGhyL2dyb3VwcyIsIi8yMDIzLTAzLTAxL3hoci9pZGVudGl0eSIsIi8yMDIzLTAzLTAxL3hoci9wYXlydW5zIiwiLzIwMjMtMDMtMDEveGhyL3BheXJ1bnMvOnBheXJ1bl9pZCIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1iYWxhbmNlcyIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1lbnRyaWVzIiwiLzIwMjMtMDMtMDEveGhyL3RpbWVzaGVldHMiLCIvMjAyMy0wMy0wMS94aHIvd29yay1sb2NhdGlvbnMiXSwidG9rZW4iOiIzODIzNTNlMi05N2ZiLTRmMWEtOTYxYy0zZDI5OTViNzYxMTUiLCJpYXQiOjE3MTE4MTA3MTQsImlzcyI6InB1YmxpY2FwaS1pbnRlcm1lZGlhdGUuZGV2LmVuZ2luZWVyaW5nLmFmZml4YXBpLmNvbSIsInN1YiI6InhociIsImF1ZCI6IjNGREFFREY5LTFEQ0E0RjU0LTg3OTQ5RjZBLTQxMDI3NjQzIn0.zUJPaT6IxcIdr8b9iO6u-Rr5I-ohTHPYTrQGrgOFghbEbovItiwr9Wk479GnJVJc3WR8bxAwUMAE4Ul6Okdk6Q' \\
  'https://dev.api.affixapi.com/2023-03-01/xhr/employees'
```

### prod
```
eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEveGhyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEveGhyL2dyb3VwcyIsIi8yMDIzLTAzLTAxL3hoci9pZGVudGl0eSIsIi8yMDIzLTAzLTAxL3hoci9wYXlydW5zIiwiLzIwMjMtMDMtMDEveGhyL3BheXJ1bnMvOnBheXJ1bl9pZCIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1iYWxhbmNlcyIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1lbnRyaWVzIiwiLzIwMjMtMDMtMDEveGhyL3RpbWVzaGVldHMiLCIvMjAyMy0wMy0wMS94aHIvd29yay1sb2NhdGlvbnMiXSwidG9rZW4iOiIzYjg4MDc2NC1kMGFmLTQ5ZDAtOGM5OS00YzIwYjE2MTJjOTMiLCJpYXQiOjE3MTE4MTA4NTgsImlzcyI6InB1YmxpY2FwaS1pbnRlcm1lZGlhdGUucHJvZC5lbmdpbmVlcmluZy5hZmZpeGFwaS5jb20iLCJzdWIiOiJ4aHIiLCJhdWQiOiIwOEJCMDgxRS1EOUFCNEQxNC04REY5OTIzMy02NjYxNUNFOSJ9.n3pJmmfegU21Tko_TyUyCHi4ITvfd75T8NFFTHmf1r8AI8yCUYTWdfNjyZZWcZD6z50I3Wsk2rAd8GDWXn4vlg
```

#### `employees` endpoint sample:
```
curl - -fail \\
  -X GET \\
  -H 'Authorization: Bearer eyJhbGciOiJFUzI1NiIsImtpZCI6Ims5RmxwSFR1YklmZWNsUU5QRVZzeFcxazFZZ0Zfbk1BWllOSGVuOFQxdGciLCJ0eXAiOiJKV1MifQ.eyJwcm92aWRlciI6InNhbmRib3giLCJzY29wZXMiOlsiLzIwMjMtMDMtMDEveGhyL2NvbXBhbnkiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWUiLCIvMjAyMy0wMy0wMS94aHIvZW1wbG95ZWVzIiwiLzIwMjMtMDMtMDEveGhyL2dyb3VwcyIsIi8yMDIzLTAzLTAxL3hoci9pZGVudGl0eSIsIi8yMDIzLTAzLTAxL3hoci9wYXlydW5zIiwiLzIwMjMtMDMtMDEveGhyL3BheXJ1bnMvOnBheXJ1bl9pZCIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1iYWxhbmNlcyIsIi8yMDIzLTAzLTAxL3hoci90aW1lLW9mZi1lbnRyaWVzIiwiLzIwMjMtMDMtMDEveGhyL3RpbWVzaGVldHMiLCIvMjAyMy0wMy0wMS94aHIvd29yay1sb2NhdGlvbnMiXSwidG9rZW4iOiIzYjg4MDc2NC1kMGFmLTQ5ZDAtOGM5OS00YzIwYjE2MTJjOTMiLCJpYXQiOjE3MTE4MTA4NTgsImlzcyI6InB1YmxpY2FwaS1pbnRlcm1lZGlhdGUucHJvZC5lbmdpbmVlcmluZy5hZmZpeGFwaS5jb20iLCJzdWIiOiJ4aHIiLCJhdWQiOiIwOEJCMDgxRS1EOUFCNEQxNC04REY5OTIzMy02NjYxNUNFOSJ9.n3pJmmfegU21Tko_TyUyCHi4ITvfd75T8NFFTHmf1r8AI8yCUYTWdfNjyZZWcZD6z50I3Wsk2rAd8GDWXn4vlg' \\
  'https://api.affixapi.com/2023-03-01/xhr/employees'
```

# Compression
We support `brotli`, `gzip`, and `deflate` compression algorithms.

To enable, pass the `Accept-Encoding` header with one or all of the values:
`br`, `gzip`, `deflate`, or `identity` (no compression)

In the response, you will receive the `Content-Encoding` response header
indicating the compression algorithm used in the data payload to enable you
to decompress the result. If the `Accept-Encoding: identity` header was
passed, no `Content-Encoding` response header is sent back, as no
compression algorithm was used.

# Webhooks
An exciting feature for HR/Payroll modes are webhooks.

If enabled, your `webhook_uri` is set on your `client_id` for the
respective environment: `dev | prod`

Webhooks are configured to make live requests to the underlying integration
1x/hr, and if a difference is detected since the last request, we will send a
request to your `webhook_uri` with this shape:

```
{

  added: <api.v20230301.Employees>[
    <api.v20230301.Employee>{
      ...,
      date_of_birth: '2010-08-06',
      display_full_name: 'Daija Rogahn',
      employee_number: '57993',
      employment_status: 'pending',
      employment_type: 'other',
      employments: [
        {
          currency: 'eur',
          effective_date: '2022-02-25',
          employment_type: 'other',
          job_title: 'Dynamic Implementation Manager',
          pay_frequency: 'semimonthly',
          pay_period: 'YEAR',
          pay_rate: 96000,
        },
      ],
      first_name: 'Daija',
      ...
    }
  ],
  removed: [],
  updated: [
    <api.v20230301.Employee>{
      ...,
      date_of_birth: '2009-11-09',
      display_full_name: 'Lourdes Stiedemann',
      employee_number: '63189',
      employment_status: 'leave',
      employment_type: 'full_time',
      employments: [
        {
          currency: 'gbp',
          effective_date: '2023-01-16',
          employment_type: 'full_time',
          job_title: 'Forward Brand Planner',
          pay_frequency: 'semimonthly',
          pay_period: 'YEAR',
          pay_rate: 86000,
        },
      ],
      first_name: 'Lourdes',
    }
  ]
}
```

the following headers will be sent with webhook requests:

```
x-affix-api-signature: ab8474e609db95d5df3adc39ea3add7a7544bd215c5c520a30a650ae93a2fba7

x-affix-api-origin:  webhooks-employees-webhook

user-agent:  affixapi.com
```

Before trusting the payload, you should sign the payload and verify the
signature matches the signature sent by the `affixapi.com` service.

This secures that the data sent to your `webhook_uri` is from the
`affixapi.com` server.

The signature is created by combining the signing secret (your
`client_secret`) with the body of the request sent using a standard
HMAC-SHA256 keyed hash.

The signature can be created via:
  - create an `HMAC` with your `client_secret`
  - update the `HMAC` with the payload
  - get the hex digest -> this is the signature

Sample `typescript` code that follows this recipe:

```
import { createHmac } from 'crypto';

export const computeSignature = ({
  str,
  signingSecret,
}: {
  signingSecret: string;
  str: string;
}): string => {
  const hmac = createHmac('sha256', signingSecret);
  hmac.update(str);
  const signature = hmac.digest('hex');

  return signature;
};
```

While verifying the Affix API signature header should be your primary
method of confirming validity, you can also whitelist our outbound webhook
static IP addresses.

```
dev:
  - 52.210.169.82
  - 52.210.38.77
  - 3.248.135.204

prod:
  - 52.51.160.102
  - 54.220.83.244
  - 3.254.213.171
```

## Rate limits
Open endpoints (not gated by an API key) (applied at endpoint level):
  - 15 requests every 1 minute (by IP address)
  - 25 requests every 5 minutes (by IP address)

Gated endpoints (require an API key) (applied at endpoint level):
  - 40 requests every 1 minute (by IP address)
  - 40 requests every 5 minutes (by `client_id`)

Things to keep in mind:
  - Open endpoints (not gated by an API key) will likely be called by your
    users, not you, so rate limits generally would not apply to you.
  - As a developer, rate limits are applied at the endpoint granularity.
    - For example, say the rate limits below are 10 requests per minute by ip.
      from that same ip, within 1 minute, you get:
      - 10 requests per minute on `/orders`,
      - another 10 requests per minute on `/items`,
      - and another 10 requests per minute on `/identity`,
      - for a total of 30 requests per minute.


This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 2023-03-01
- SDK version: 1.1.76
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using AffixApi.Api.Api;
using AffixApi.Api.Client;
using AffixApi.Api.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out AffixApi.Api.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AffixApi.Api.Api;
using AffixApi.Api.Client;
using AffixApi.Api.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new Class20230301Api(config);

            try
            {
                // Company
                List<CompanyResponse> result = apiInstance.XhrCompanies20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling Class20230301Api.XhrCompanies20230301: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.affixapi.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*Class20230301Api* | [**XhrCompanies20230301**](docs/Class20230301Api.md#xhrcompanies20230301) | **GET** /2023-03-01/xhr/company | Company
*Class20230301Api* | [**XhrEmployees20230301**](docs/Class20230301Api.md#xhremployees20230301) | **GET** /2023-03-01/xhr/employees | Employees
*Class20230301Api* | [**XhrGroups20230301**](docs/Class20230301Api.md#xhrgroups20230301) | **GET** /2023-03-01/xhr/groups | Groups
*Class20230301Api* | [**XhrIdentity20230301**](docs/Class20230301Api.md#xhridentity20230301) | **GET** /2023-03-01/xhr/identity | Identity
*Class20230301Api* | [**XhrPayruns20230301**](docs/Class20230301Api.md#xhrpayruns20230301) | **GET** /2023-03-01/xhr/payruns | Payruns
*Class20230301Api* | [**XhrPayslips20230301**](docs/Class20230301Api.md#xhrpayslips20230301) | **GET** /2023-03-01/xhr/payruns/{payrun_id} | Payslips
*Class20230301Api* | [**XhrTimeOffBalances20230301**](docs/Class20230301Api.md#xhrtimeoffbalances20230301) | **GET** /2023-03-01/xhr/time-off-balances | Time off balances
*Class20230301Api* | [**XhrTimeOffEntries20230301**](docs/Class20230301Api.md#xhrtimeoffentries20230301) | **GET** /2023-03-01/xhr/time-off-entries | Time off entries
*Class20230301Api* | [**XhrTimesheets20230301**](docs/Class20230301Api.md#xhrtimesheets20230301) | **GET** /2023-03-01/xhr/timesheets | Timesheets
*Class20230301Api* | [**XhrWorkLocations20230301**](docs/Class20230301Api.md#xhrworklocations20230301) | **GET** /2023-03-01/xhr/work-locations | Work locations
*CoreApi* | [**Providers**](docs/CoreApi.md#providers) | **GET** /providers | Providers
*ManagementApi* | [**CallClient**](docs/ManagementApi.md#callclient) | **GET** /2023-03-01/management/client | Client
*ManagementApi* | [**Disconnect**](docs/ManagementApi.md#disconnect) | **POST** /2023-03-01/management/disconnect | Disconnect token
*ManagementApi* | [**Introspect**](docs/ManagementApi.md#introspect) | **GET** /2023-03-01/management/introspect | Inspect token
*ManagementApi* | [**Token**](docs/ManagementApi.md#token) | **POST** /2023-03-01/management/token | Create token
*ManagementApi* | [**Tokens**](docs/ManagementApi.md#tokens) | **GET** /2023-03-01/management/tokens | Tokens
*ManagementApi* | [**UpdateClient**](docs/ManagementApi.md#updateclient) | **POST** /2023-03-01/management/client | Update client
*XHRVerticallyIntegratedApi* | [**XhrCompanies20230301**](docs/XHRVerticallyIntegratedApi.md#xhrcompanies20230301) | **GET** /2023-03-01/xhr/company | Company
*XHRVerticallyIntegratedApi* | [**XhrEmployees20230301**](docs/XHRVerticallyIntegratedApi.md#xhremployees20230301) | **GET** /2023-03-01/xhr/employees | Employees
*XHRVerticallyIntegratedApi* | [**XhrGroups20230301**](docs/XHRVerticallyIntegratedApi.md#xhrgroups20230301) | **GET** /2023-03-01/xhr/groups | Groups
*XHRVerticallyIntegratedApi* | [**XhrIdentity20230301**](docs/XHRVerticallyIntegratedApi.md#xhridentity20230301) | **GET** /2023-03-01/xhr/identity | Identity
*XHRVerticallyIntegratedApi* | [**XhrPayruns20230301**](docs/XHRVerticallyIntegratedApi.md#xhrpayruns20230301) | **GET** /2023-03-01/xhr/payruns | Payruns
*XHRVerticallyIntegratedApi* | [**XhrPayslips20230301**](docs/XHRVerticallyIntegratedApi.md#xhrpayslips20230301) | **GET** /2023-03-01/xhr/payruns/{payrun_id} | Payslips
*XHRVerticallyIntegratedApi* | [**XhrTimeOffBalances20230301**](docs/XHRVerticallyIntegratedApi.md#xhrtimeoffbalances20230301) | **GET** /2023-03-01/xhr/time-off-balances | Time off balances
*XHRVerticallyIntegratedApi* | [**XhrTimeOffEntries20230301**](docs/XHRVerticallyIntegratedApi.md#xhrtimeoffentries20230301) | **GET** /2023-03-01/xhr/time-off-entries | Time off entries
*XHRVerticallyIntegratedApi* | [**XhrTimesheets20230301**](docs/XHRVerticallyIntegratedApi.md#xhrtimesheets20230301) | **GET** /2023-03-01/xhr/timesheets | Timesheets
*XHRVerticallyIntegratedApi* | [**XhrWorkLocations20230301**](docs/XHRVerticallyIntegratedApi.md#xhrworklocations20230301) | **GET** /2023-03-01/xhr/work-locations | Work locations


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddressNoNonNullRequest](docs/AddressNoNonNullRequest.md)
 - [Model.AddressResponse](docs/AddressResponse.md)
 - [Model.ClientRequest](docs/ClientRequest.md)
 - [Model.ClientResponse](docs/ClientResponse.md)
 - [Model.CompanyResponse](docs/CompanyResponse.md)
 - [Model.CompensationHistoryNoNonNullRequest](docs/CompensationHistoryNoNonNullRequest.md)
 - [Model.CompensationHistoryResponse](docs/CompensationHistoryResponse.md)
 - [Model.CreateEmployeeRequest](docs/CreateEmployeeRequest.md)
 - [Model.CreateEmployeeRequestBankAccount](docs/CreateEmployeeRequestBankAccount.md)
 - [Model.CreateEmployeeRequestDependents](docs/CreateEmployeeRequestDependents.md)
 - [Model.CreateEmployeeRequestEmergencyContacts](docs/CreateEmployeeRequestEmergencyContacts.md)
 - [Model.CreateEmployeeRequestManager](docs/CreateEmployeeRequestManager.md)
 - [Model.CurrencyNotNullRequest](docs/CurrencyNotNullRequest.md)
 - [Model.CurrencyResponse](docs/CurrencyResponse.md)
 - [Model.DisconnectResponse](docs/DisconnectResponse.md)
 - [Model.EmployeeResponse](docs/EmployeeResponse.md)
 - [Model.EmployeeResponseManager](docs/EmployeeResponseManager.md)
 - [Model.EmploymentHistoryNoNonNullRequest](docs/EmploymentHistoryNoNonNullRequest.md)
 - [Model.EmploymentHistoryResponse](docs/EmploymentHistoryResponse.md)
 - [Model.EmploymentStatusNotNullNotNullable](docs/EmploymentStatusNotNullNotNullable.md)
 - [Model.EmploymentStatusNotNullRequest](docs/EmploymentStatusNotNullRequest.md)
 - [Model.EmploymentStatusResponse](docs/EmploymentStatusResponse.md)
 - [Model.GroupNoNullEnumRequest](docs/GroupNoNullEnumRequest.md)
 - [Model.GroupResponse](docs/GroupResponse.md)
 - [Model.IdAndMessageResponse](docs/IdAndMessageResponse.md)
 - [Model.IdentityResponse](docs/IdentityResponse.md)
 - [Model.InlineResponse400](docs/InlineResponse400.md)
 - [Model.InlineResponse401](docs/InlineResponse401.md)
 - [Model.InlineResponse409](docs/InlineResponse409.md)
 - [Model.IntrospectResponse](docs/IntrospectResponse.md)
 - [Model.LocationNoNonNullRequest](docs/LocationNoNonNullRequest.md)
 - [Model.LocationResponse](docs/LocationResponse.md)
 - [Model.MessageResponse](docs/MessageResponse.md)
 - [Model.ModeRequest](docs/ModeRequest.md)
 - [Model.ModeResponse](docs/ModeResponse.md)
 - [Model.PayrunResponse](docs/PayrunResponse.md)
 - [Model.PayslipResponse](docs/PayslipResponse.md)
 - [Model.PayslipResponseContributions](docs/PayslipResponseContributions.md)
 - [Model.PayslipResponseDeductions](docs/PayslipResponseDeductions.md)
 - [Model.PayslipResponseEarnings](docs/PayslipResponseEarnings.md)
 - [Model.PayslipResponseTaxes](docs/PayslipResponseTaxes.md)
 - [Model.PolicyTypeResponse](docs/PolicyTypeResponse.md)
 - [Model.ProviderRequest](docs/ProviderRequest.md)
 - [Model.ProviderResponse](docs/ProviderResponse.md)
 - [Model.ScopesRequest](docs/ScopesRequest.md)
 - [Model.ScopesResponse](docs/ScopesResponse.md)
 - [Model.TimeOffBalanceResponse](docs/TimeOffBalanceResponse.md)
 - [Model.TimeOffEntryResponse](docs/TimeOffEntryResponse.md)
 - [Model.TimesheetResponse](docs/TimesheetResponse.md)
 - [Model.TokenRequest](docs/TokenRequest.md)
 - [Model.TokenResponse](docs/TokenResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="access-token"></a>
### access-token

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

<a name="basic"></a>
### basic

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

