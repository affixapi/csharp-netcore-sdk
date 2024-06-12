# AffixApi.Api.Api.XHRVerticallyIntegratedApi

All URIs are relative to *https://api.affixapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**XhrCompanies20230301**](XHRVerticallyIntegratedApi.md#xhrcompanies20230301) | **GET** /2023-03-01/xhr/company | Company
[**XhrEmployees20230301**](XHRVerticallyIntegratedApi.md#xhremployees20230301) | **GET** /2023-03-01/xhr/employees | Employees
[**XhrGroups20230301**](XHRVerticallyIntegratedApi.md#xhrgroups20230301) | **GET** /2023-03-01/xhr/groups | Groups
[**XhrIdentity20230301**](XHRVerticallyIntegratedApi.md#xhridentity20230301) | **GET** /2023-03-01/xhr/identity | Identity
[**XhrPayruns20230301**](XHRVerticallyIntegratedApi.md#xhrpayruns20230301) | **GET** /2023-03-01/xhr/payruns | Payruns
[**XhrPayslips20230301**](XHRVerticallyIntegratedApi.md#xhrpayslips20230301) | **GET** /2023-03-01/xhr/payruns/{payrun_id} | Payslips
[**XhrTimeOffBalances20230301**](XHRVerticallyIntegratedApi.md#xhrtimeoffbalances20230301) | **GET** /2023-03-01/xhr/time-off-balances | Time off balances
[**XhrTimeOffEntries20230301**](XHRVerticallyIntegratedApi.md#xhrtimeoffentries20230301) | **GET** /2023-03-01/xhr/time-off-entries | Time off entries
[**XhrTimesheets20230301**](XHRVerticallyIntegratedApi.md#xhrtimesheets20230301) | **GET** /2023-03-01/xhr/timesheets | Timesheets
[**XhrWorkLocations20230301**](XHRVerticallyIntegratedApi.md#xhrworklocations20230301) | **GET** /2023-03-01/xhr/work-locations | Work locations


<a name="xhrcompanies20230301"></a>
# **XhrCompanies20230301**
> List&lt;CompanyResponse&gt; XhrCompanies20230301 ()

Company

Retrieve company information 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AffixApi.Api.Api;
using AffixApi.Api.Client;
using AffixApi.Api.Model;

namespace Example
{
    public class XhrCompanies20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XHRVerticallyIntegratedApi(config);

            try
            {
                // Company
                List<CompanyResponse> result = apiInstance.XhrCompanies20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XHRVerticallyIntegratedApi.XhrCompanies20230301: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;CompanyResponse&gt;**](CompanyResponse.md)

### Authorization

[access-token](../README.md#access-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **202** | Accepted + pending (async job started) |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **401** | Authentication Error |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |
| **501** | Not Implemented |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="xhremployees20230301"></a>
# **XhrEmployees20230301**
> List&lt;EmployeeResponse&gt; XhrEmployees20230301 (EmploymentStatusNotNullNotNullable? employmentStatus = null)

Employees

List the individuals (employees, contractors, accountants, and others) listed in the HRIS/Payroll software 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AffixApi.Api.Api;
using AffixApi.Api.Client;
using AffixApi.Api.Model;

namespace Example
{
    public class XhrEmployees20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XHRVerticallyIntegratedApi(config);
            var employmentStatus = ;  // EmploymentStatusNotNullNotNullable? | Optional query parameter. Use to enable server-side filtering of the `employment_status` attribute. Will only include individuals with that attribute explicitly set (ie if an individuals has a `null`, it will not be returned if this parameter is set)  (optional) 

            try
            {
                // Employees
                List<EmployeeResponse> result = apiInstance.XhrEmployees20230301(employmentStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XHRVerticallyIntegratedApi.XhrEmployees20230301: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **employmentStatus** | **EmploymentStatusNotNullNotNullable?**| Optional query parameter. Use to enable server-side filtering of the &#x60;employment_status&#x60; attribute. Will only include individuals with that attribute explicitly set (ie if an individuals has a &#x60;null&#x60;, it will not be returned if this parameter is set)  | [optional] 

### Return type

[**List&lt;EmployeeResponse&gt;**](EmployeeResponse.md)

### Authorization

[access-token](../README.md#access-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **202** | Accepted + pending (async job started) |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **401** | Authentication Error |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |
| **501** | Not Implemented |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="xhrgroups20230301"></a>
# **XhrGroups20230301**
> List&lt;GroupResponse&gt; XhrGroups20230301 ()

Groups

The Group object is used to represent any subset of employees, such as PayGroup, Team, or Department. Employees can be in multiple Groups. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AffixApi.Api.Api;
using AffixApi.Api.Client;
using AffixApi.Api.Model;

namespace Example
{
    public class XhrGroups20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XHRVerticallyIntegratedApi(config);

            try
            {
                // Groups
                List<GroupResponse> result = apiInstance.XhrGroups20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XHRVerticallyIntegratedApi.XhrGroups20230301: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;GroupResponse&gt;**](GroupResponse.md)

### Authorization

[access-token](../README.md#access-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **202** | Accepted + pending (async job started) |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **401** | Authentication Error |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |
| **501** | Not Implemented |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="xhridentity20230301"></a>
# **XhrIdentity20230301**
> IdentityResponse XhrIdentity20230301 ()

Identity

List information of the user for the respective account 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AffixApi.Api.Api;
using AffixApi.Api.Client;
using AffixApi.Api.Model;

namespace Example
{
    public class XhrIdentity20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XHRVerticallyIntegratedApi(config);

            try
            {
                // Identity
                IdentityResponse result = apiInstance.XhrIdentity20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XHRVerticallyIntegratedApi.XhrIdentity20230301: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**IdentityResponse**](IdentityResponse.md)

### Authorization

[access-token](../README.md#access-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Authentication Error |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="xhrpayruns20230301"></a>
# **XhrPayruns20230301**
> List&lt;PayrunResponse&gt; XhrPayruns20230301 (DateTime startDate, DateTime endDate)

Payruns

List all the pay runs that occurred during the respective period.  Supported integrations:   - brain payroll   - brightpay connect   - deel   - gusto   - justworks   - moorepay   - onpay   - oyster   - parolla.ie   - paycircle   - payfit   - pento.io   - quickbooks online   - remote.com   # - rippling   - sageone   - shape payroll   - simplepay.ie   - staffology   - xero uk 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AffixApi.Api.Api;
using AffixApi.Api.Client;
using AffixApi.Api.Model;

namespace Example
{
    public class XhrPayruns20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XHRVerticallyIntegratedApi(config);
            var startDate = 2013-10-20;  // DateTime | The start date of the search period
            var endDate = 2013-10-20;  // DateTime | The end date of the search period

            try
            {
                // Payruns
                List<PayrunResponse> result = apiInstance.XhrPayruns20230301(startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XHRVerticallyIntegratedApi.XhrPayruns20230301: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime**| The start date of the search period | 
 **endDate** | **DateTime**| The end date of the search period | 

### Return type

[**List&lt;PayrunResponse&gt;**](PayrunResponse.md)

### Authorization

[access-token](../README.md#access-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **202** | Accepted + pending (async job started) |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **401** | Authentication Error |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |
| **501** | Not Implemented |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="xhrpayslips20230301"></a>
# **XhrPayslips20230301**
> List&lt;PayslipResponse&gt; XhrPayslips20230301 (string payrunId)

Payslips

Retrieves payslips from a specific payrun.  Supported integrations:   - brain payroll   - brightpay connect   - deel   - gusto   - justworks   - moorepay   - onpay   - oyster   - parolla.ie   - paycircle   - payfit   - pento.io   - quickbooks online   - remote.com   # - rippling   - sageone   - shape payroll   - simplepay.ie   - staffology   - xero uk 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AffixApi.Api.Api;
using AffixApi.Api.Client;
using AffixApi.Api.Model;

namespace Example
{
    public class XhrPayslips20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XHRVerticallyIntegratedApi(config);
            var payrunId = payrunId_example;  // string | The id of the payrun.

            try
            {
                // Payslips
                List<PayslipResponse> result = apiInstance.XhrPayslips20230301(payrunId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XHRVerticallyIntegratedApi.XhrPayslips20230301: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payrunId** | **string**| The id of the payrun. | 

### Return type

[**List&lt;PayslipResponse&gt;**](PayslipResponse.md)

### Authorization

[access-token](../README.md#access-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **202** | Accepted + pending (async job started) |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **401** | Authentication Error |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |
| **501** | Not Implemented |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="xhrtimeoffbalances20230301"></a>
# **XhrTimeOffBalances20230301**
> List&lt;TimeOffBalanceResponse&gt; XhrTimeOffBalances20230301 ()

Time off balances

Retrieve all time off balances. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AffixApi.Api.Api;
using AffixApi.Api.Client;
using AffixApi.Api.Model;

namespace Example
{
    public class XhrTimeOffBalances20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XHRVerticallyIntegratedApi(config);

            try
            {
                // Time off balances
                List<TimeOffBalanceResponse> result = apiInstance.XhrTimeOffBalances20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XHRVerticallyIntegratedApi.XhrTimeOffBalances20230301: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;TimeOffBalanceResponse&gt;**](TimeOffBalanceResponse.md)

### Authorization

[access-token](../README.md#access-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **202** | Accepted + pending (async job started) |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **401** | Authentication Error |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |
| **501** | Not Implemented |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="xhrtimeoffentries20230301"></a>
# **XhrTimeOffEntries20230301**
> List&lt;TimeOffEntryResponse&gt; XhrTimeOffEntries20230301 (DateTime startDate, DateTime endDate)

Time off entries

Retrieve time off / absence entries 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AffixApi.Api.Api;
using AffixApi.Api.Client;
using AffixApi.Api.Model;

namespace Example
{
    public class XhrTimeOffEntries20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XHRVerticallyIntegratedApi(config);
            var startDate = 2013-10-20;  // DateTime | The start date of the search period
            var endDate = 2013-10-20;  // DateTime | The end date of the search period

            try
            {
                // Time off entries
                List<TimeOffEntryResponse> result = apiInstance.XhrTimeOffEntries20230301(startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XHRVerticallyIntegratedApi.XhrTimeOffEntries20230301: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime**| The start date of the search period | 
 **endDate** | **DateTime**| The end date of the search period | 

### Return type

[**List&lt;TimeOffEntryResponse&gt;**](TimeOffEntryResponse.md)

### Authorization

[access-token](../README.md#access-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **202** | Accepted + pending (async job started) |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **401** | Authentication Error |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |
| **501** | Not Implemented |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="xhrtimesheets20230301"></a>
# **XhrTimesheets20230301**
> List&lt;TimesheetResponse&gt; XhrTimesheets20230301 (DateTime startDate, DateTime endDate)

Timesheets

Retrieve Timesheets 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AffixApi.Api.Api;
using AffixApi.Api.Client;
using AffixApi.Api.Model;

namespace Example
{
    public class XhrTimesheets20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XHRVerticallyIntegratedApi(config);
            var startDate = 2013-10-20;  // DateTime | The start date of the search period
            var endDate = 2013-10-20;  // DateTime | The end date of the search period

            try
            {
                // Timesheets
                List<TimesheetResponse> result = apiInstance.XhrTimesheets20230301(startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XHRVerticallyIntegratedApi.XhrTimesheets20230301: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime**| The start date of the search period | 
 **endDate** | **DateTime**| The end date of the search period | 

### Return type

[**List&lt;TimesheetResponse&gt;**](TimesheetResponse.md)

### Authorization

[access-token](../README.md#access-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **202** | Accepted + pending (async job started) |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **401** | Authentication Error |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |
| **501** | Not Implemented |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="xhrworklocations20230301"></a>
# **XhrWorkLocations20230301**
> List&lt;LocationResponse&gt; XhrWorkLocations20230301 ()

Work locations

The Location object is used to represent an address that can be associated with an employee 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AffixApi.Api.Api;
using AffixApi.Api.Client;
using AffixApi.Api.Model;

namespace Example
{
    public class XhrWorkLocations20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XHRVerticallyIntegratedApi(config);

            try
            {
                // Work locations
                List<LocationResponse> result = apiInstance.XhrWorkLocations20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XHRVerticallyIntegratedApi.XhrWorkLocations20230301: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;LocationResponse&gt;**](LocationResponse.md)

### Authorization

[access-token](../README.md#access-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **202** | Accepted + pending (async job started) |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **401** | Authentication Error |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |
| **501** | Not Implemented |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

