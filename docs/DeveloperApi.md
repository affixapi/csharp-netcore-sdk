# Org.OpenAPITools.Api.DeveloperApi

All URIs are relative to *https://api.affixapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeveloperCompanies20230301**](DeveloperApi.md#developercompanies20230301) | **GET** /2023-03-01/developer/company | Company
[**DeveloperCreateEmployee20230301**](DeveloperApi.md#developercreateemployee20230301) | **POST** /2023-03-01/developer/employee | Create employee
[**DeveloperEmployees20230301**](DeveloperApi.md#developeremployees20230301) | **GET** /2023-03-01/developer/employees | Employees
[**DeveloperGroups20230301**](DeveloperApi.md#developergroups20230301) | **GET** /2023-03-01/developer/groups | Groups
[**DeveloperIdentity20230301**](DeveloperApi.md#developeridentity20230301) | **GET** /2023-03-01/developer/identity | Identity
[**DeveloperPayruns20230301**](DeveloperApi.md#developerpayruns20230301) | **GET** /2023-03-01/developer/payruns | Payruns
[**DeveloperPayslips20230301**](DeveloperApi.md#developerpayslips20230301) | **GET** /2023-03-01/developer/payruns/{payrun_id} | Payslips
[**DeveloperTimeOffBalances20230301**](DeveloperApi.md#developertimeoffbalances20230301) | **GET** /2023-03-01/developer/time-off-balances | Time off balances
[**DeveloperTimeOffEntries20230301**](DeveloperApi.md#developertimeoffentries20230301) | **GET** /2023-03-01/developer/time-off-entries | Time off entries
[**DeveloperTimesheets20230301**](DeveloperApi.md#developertimesheets20230301) | **GET** /2023-03-01/developer/timesheets | Timesheets
[**DeveloperWorkLocations20230301**](DeveloperApi.md#developerworklocations20230301) | **GET** /2023-03-01/developer/work-locations | Work locations


<a name="developercompanies20230301"></a>
# **DeveloperCompanies20230301**
> List&lt;CompanyResponse&gt; DeveloperCompanies20230301 ()

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
    public class DeveloperCompanies20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeveloperApi(config);

            try
            {
                // Company
                List<CompanyResponse> result = apiInstance.DeveloperCompanies20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperApi.DeveloperCompanies20230301: " + e.Message );
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

<a name="developercreateemployee20230301"></a>
# **DeveloperCreateEmployee20230301**
> EmployeeResponse DeveloperCreateEmployee20230301 (CreateEmployeeRequest createEmployeeRequest)

Create employee

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
    public class DeveloperCreateEmployee20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeveloperApi(config);
            var createEmployeeRequest = new CreateEmployeeRequest(); // CreateEmployeeRequest | 

            try
            {
                // Create employee
                EmployeeResponse result = apiInstance.DeveloperCreateEmployee20230301(createEmployeeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperApi.DeveloperCreateEmployee20230301: " + e.Message );
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

<a name="developeremployees20230301"></a>
# **DeveloperEmployees20230301**
> List&lt;EmployeeResponse&gt; DeveloperEmployees20230301 ()

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
    public class DeveloperEmployees20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeveloperApi(config);

            try
            {
                // Employees
                List<EmployeeResponse> result = apiInstance.DeveloperEmployees20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperApi.DeveloperEmployees20230301: " + e.Message );
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

<a name="developergroups20230301"></a>
# **DeveloperGroups20230301**
> List&lt;GroupResponse&gt; DeveloperGroups20230301 ()

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
    public class DeveloperGroups20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeveloperApi(config);

            try
            {
                // Groups
                List<GroupResponse> result = apiInstance.DeveloperGroups20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperApi.DeveloperGroups20230301: " + e.Message );
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

<a name="developeridentity20230301"></a>
# **DeveloperIdentity20230301**
> IdentityResponse DeveloperIdentity20230301 ()

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
    public class DeveloperIdentity20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeveloperApi(config);

            try
            {
                // Identity
                IdentityResponse result = apiInstance.DeveloperIdentity20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperApi.DeveloperIdentity20230301: " + e.Message );
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

<a name="developerpayruns20230301"></a>
# **DeveloperPayruns20230301**
> List&lt;PayrunResponse&gt; DeveloperPayruns20230301 (DateTime startDate, DateTime endDate)

Payruns

List all the pay runs that occurred during the respective period.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeveloperPayruns20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeveloperApi(config);
            var startDate = 2013-10-20;  // DateTime | The start date of the search period
            var endDate = 2013-10-20;  // DateTime | The end date of the search period

            try
            {
                // Payruns
                List<PayrunResponse> result = apiInstance.DeveloperPayruns20230301(startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperApi.DeveloperPayruns20230301: " + e.Message );
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

<a name="developerpayslips20230301"></a>
# **DeveloperPayslips20230301**
> List&lt;PayslipResponse&gt; DeveloperPayslips20230301 (string payrunId)

Payslips

Retrieves payslips from a specific payrun.  Supported integrations:   - sageone   - simplepay.ie   - brightpay connect 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeveloperPayslips20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeveloperApi(config);
            var payrunId = payrunId_example;  // string | The id of the payrun.

            try
            {
                // Payslips
                List<PayslipResponse> result = apiInstance.DeveloperPayslips20230301(payrunId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperApi.DeveloperPayslips20230301: " + e.Message );
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

<a name="developertimeoffbalances20230301"></a>
# **DeveloperTimeOffBalances20230301**
> List&lt;TimeOffBalanceResponse&gt; DeveloperTimeOffBalances20230301 ()

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
    public class DeveloperTimeOffBalances20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeveloperApi(config);

            try
            {
                // Time off balances
                List<TimeOffBalanceResponse> result = apiInstance.DeveloperTimeOffBalances20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperApi.DeveloperTimeOffBalances20230301: " + e.Message );
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

<a name="developertimeoffentries20230301"></a>
# **DeveloperTimeOffEntries20230301**
> List&lt;TimeOffEntryResponse&gt; DeveloperTimeOffEntries20230301 ()

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
    public class DeveloperTimeOffEntries20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeveloperApi(config);

            try
            {
                // Time off entries
                List<TimeOffEntryResponse> result = apiInstance.DeveloperTimeOffEntries20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperApi.DeveloperTimeOffEntries20230301: " + e.Message );
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

<a name="developertimesheets20230301"></a>
# **DeveloperTimesheets20230301**
> List&lt;TimesheetResponse&gt; DeveloperTimesheets20230301 ()

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
    public class DeveloperTimesheets20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeveloperApi(config);

            try
            {
                // Timesheets
                List<TimesheetResponse> result = apiInstance.DeveloperTimesheets20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperApi.DeveloperTimesheets20230301: " + e.Message );
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

<a name="developerworklocations20230301"></a>
# **DeveloperWorkLocations20230301**
> List&lt;LocationResponse&gt; DeveloperWorkLocations20230301 ()

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
    public class DeveloperWorkLocations20230301Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeveloperApi(config);

            try
            {
                // Work locations
                List<LocationResponse> result = apiInstance.DeveloperWorkLocations20230301();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeveloperApi.DeveloperWorkLocations20230301: " + e.Message );
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

