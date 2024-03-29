# AffixApi.Api.Api.CoreApi

All URIs are relative to *https://api.affixapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Providers**](CoreApi.md#providers) | **GET** /providers | Providers


<a name="providers"></a>
# **Providers**
> List&lt;Object&gt; Providers ()

Providers

Retrieve the api modes (official, xhr) and providers for the respective modes 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AffixApi.Api.Api;
using AffixApi.Api.Client;
using AffixApi.Api.Model;

namespace Example
{
    public class ProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            var apiInstance = new CoreApi(config);

            try
            {
                // Providers
                List<Object> result = apiInstance.Providers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.Providers: " + e.Message );
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

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

