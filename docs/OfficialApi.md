# Org.OpenAPITools.Api.OfficialApi

All URIs are relative to *https://api.affixapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OfficialCompanies20230301**](OfficialApi.md#officialcompanies20230301) | **GET** /2023-03-01/official/company | Company
[**OfficialCreateEmployee20230301**](OfficialApi.md#officialcreateemployee20230301) | **POST** /2023-03-01/official/employee | Create Employee
[**OfficialEmployees20230301**](OfficialApi.md#officialemployees20230301) | **GET** /2023-03-01/official/employees | Employees
[**OfficialGroups20230301**](OfficialApi.md#officialgroups20230301) | **GET** /2023-03-01/official/groups | Groups
[**OfficialTimeOffBalances20230301**](OfficialApi.md#officialtimeoffbalances20230301) | **GET** /2023-03-01/official/time-off-balances | Time off balances
[**OfficialTimeOffEntries20230301**](OfficialApi.md#officialtimeoffentries20230301) | **GET** /2023-03-01/official/time-off-entries | Time off entries
[**OfficialTimesheets20230301**](OfficialApi.md#officialtimesheets20230301) | **GET** /2023-03-01/official/timesheets | Timesheets
[**OfficialWorkLocations20230301**](OfficialApi.md#officialworklocations20230301) | **GET** /2023-03-01/official/work-locations | Work locations
[**Officialdentity20230301**](OfficialApi.md#officialdentity20230301) | **GET** /2023-03-01/official/identity | Identity


<a name="officialcompanies20230301"></a>
# **OfficialCompanies20230301**
> List&lt;CompanyResponse&gt; OfficialCompanies20230301 ()

Company

Retrieve company information 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OfficialCompanies20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfficialApi(config);

            try
            {
                // Company
                List<CompanyResponse> result = apiInstance.OfficialCompanies20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OfficialApi.OfficialCompanies20230301: " + e.Message );
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

<a name="officialcreateemployee20230301"></a>
# **OfficialCreateEmployee20230301**
> EmployeeResponse OfficialCreateEmployee20230301 (CreateEmployeeRequest createEmployeeRequest)

Create Employee

Creates a new Employee 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OfficialCreateEmployee20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfficialApi(config);
            var createEmployeeRequest = new CreateEmployeeRequest(); // CreateEmployeeRequest | 

            try
            {
                // Create Employee
                EmployeeResponse result = apiInstance.OfficialCreateEmployee20230301(createEmployeeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OfficialApi.OfficialCreateEmployee20230301: " + e.Message );
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
 **createEmployeeRequest** | [**CreateEmployeeRequest**](CreateEmployeeRequest.md)|  | 

### Return type

[**EmployeeResponse**](EmployeeResponse.md)

### Authorization

[access-token](../README.md#access-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | Bad Request |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |
| **501** | Not Implemented |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="officialemployees20230301"></a>
# **OfficialEmployees20230301**
> List&lt;EmployeeResponse&gt; OfficialEmployees20230301 ()

Employees

List the individuals (employees, contractors, accountants, and others) listed in the HRIS/Payroll software 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OfficialEmployees20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfficialApi(config);

            try
            {
                // Employees
                List<EmployeeResponse> result = apiInstance.OfficialEmployees20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OfficialApi.OfficialEmployees20230301: " + e.Message );
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

<a name="officialgroups20230301"></a>
# **OfficialGroups20230301**
> List&lt;GroupResponse&gt; OfficialGroups20230301 ()

Groups

The Group object is used to represent any subset of employees, such as PayGroup, Team, or Department. Employees can be in multiple Groups. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OfficialGroups20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfficialApi(config);

            try
            {
                // Groups
                List<GroupResponse> result = apiInstance.OfficialGroups20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OfficialApi.OfficialGroups20230301: " + e.Message );
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

<a name="officialtimeoffbalances20230301"></a>
# **OfficialTimeOffBalances20230301**
> List&lt;TimeOffBalanceResponse&gt; OfficialTimeOffBalances20230301 ()

Time off balances

Retrieve all time off balances. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OfficialTimeOffBalances20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfficialApi(config);

            try
            {
                // Time off balances
                List<TimeOffBalanceResponse> result = apiInstance.OfficialTimeOffBalances20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OfficialApi.OfficialTimeOffBalances20230301: " + e.Message );
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

<a name="officialtimeoffentries20230301"></a>
# **OfficialTimeOffEntries20230301**
> List&lt;TimeOffEntryResponse&gt; OfficialTimeOffEntries20230301 ()

Time off entries

Retrieve time off / absence entries 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OfficialTimeOffEntries20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfficialApi(config);

            try
            {
                // Time off entries
                List<TimeOffEntryResponse> result = apiInstance.OfficialTimeOffEntries20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OfficialApi.OfficialTimeOffEntries20230301: " + e.Message );
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

<a name="officialtimesheets20230301"></a>
# **OfficialTimesheets20230301**
> List&lt;TimesheetResponse&gt; OfficialTimesheets20230301 ()

Timesheets

Retrieve Timesheets 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OfficialTimesheets20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfficialApi(config);

            try
            {
                // Timesheets
                List<TimesheetResponse> result = apiInstance.OfficialTimesheets20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OfficialApi.OfficialTimesheets20230301: " + e.Message );
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

<a name="officialworklocations20230301"></a>
# **OfficialWorkLocations20230301**
> List&lt;LocationResponse&gt; OfficialWorkLocations20230301 ()

Work locations

The Location object is used to represent an address that can be associated with an employee 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OfficialWorkLocations20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfficialApi(config);

            try
            {
                // Work locations
                List<LocationResponse> result = apiInstance.OfficialWorkLocations20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OfficialApi.OfficialWorkLocations20230301: " + e.Message );
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

<a name="officialdentity20230301"></a>
# **Officialdentity20230301**
> IdentityResponse Officialdentity20230301 ()

Identity

List information of the user for the respective account 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Officialdentity20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OfficialApi(config);

            try
            {
                // Identity
                IdentityResponse result = apiInstance.Officialdentity20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OfficialApi.Officialdentity20230301: " + e.Message );
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

