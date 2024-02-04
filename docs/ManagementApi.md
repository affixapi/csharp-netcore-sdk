# Org.OpenAPITools.Api.ManagementApi

All URIs are relative to *https://api.affixapi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CallClient**](ManagementApi.md#callclient) | **GET** /2023-03-01/management/client | Client
[**Disconnect**](ManagementApi.md#disconnect) | **POST** /2023-03-01/management/disconnect | Disconnect token
[**Introspect**](ManagementApi.md#introspect) | **GET** /2023-03-01/management/introspect | Inspect token
[**Token**](ManagementApi.md#token) | **POST** /2023-03-01/management/token | Create token
[**Tokens**](ManagementApi.md#tokens) | **GET** /2023-03-01/management/tokens | Tokens
[**UpdateClient**](ManagementApi.md#updateclient) | **POST** /2023-03-01/management/client | Update client


<a name="callclient"></a>
# **CallClient**
> ClientResponse CallClient ()

Client

View client attributes 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CallClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: basic
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // Client
                ClientResponse result = apiInstance.CallClient();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.CallClient: " + e.Message );
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

[**ClientResponse**](ClientResponse.md)

### Authorization

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Authentication Error |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disconnect"></a>
# **Disconnect**
> DisconnectResponse Disconnect ()

Disconnect token

Disconnect the token. A disconnected token will no longer return data. Data requests with a disconnected token will return a 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DisconnectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // Disconnect token
                DisconnectResponse result = apiInstance.Disconnect();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.Disconnect: " + e.Message );
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

[**DisconnectResponse**](DisconnectResponse.md)

### Authorization

[access-token](../README.md#access-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="introspect"></a>
# **Introspect**
> IntrospectResponse Introspect ()

Inspect token

Retrieve data about the token, such as `scopes`, `mode`, `provider`, and if it is active 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IntrospectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: access-token
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // Inspect token
                IntrospectResponse result = apiInstance.Introspect();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.Introspect: " + e.Message );
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

[**IntrospectResponse**](IntrospectResponse.md)

### Authorization

[access-token](../README.md#access-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="token"></a>
# **Token**
> TokenResponse Token (TokenRequest tokenRequest)

Create token

Exchange an `authorization_code` for an `access_token` after receiving on from the `redirect_uri` you specifiy after a successful user connection 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            var apiInstance = new ManagementApi(config);
            var tokenRequest = new TokenRequest(); // TokenRequest | 

            try
            {
                // Create token
                TokenResponse result = apiInstance.Token(tokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.Token: " + e.Message );
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
 **tokenRequest** | [**TokenRequest**](TokenRequest.md)|  | 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **409** | Not Found |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tokens"></a>
# **Tokens**
> List&lt;Object&gt; Tokens ()

Tokens

View tokens and token status for respective client 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: basic
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);

            try
            {
                // Tokens
                List<Object> result = apiInstance.Tokens();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.Tokens: " + e.Message );
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

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **409** | Not Found |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateclient"></a>
# **UpdateClient**
> ClientResponse UpdateClient (ClientRequest clientRequest)

Update client

Update attributes of the client.  Update the `name`, `client_secret`, or `webhook_uri` of the client 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.affixapi.com";
            // Configure API key authorization: basic
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ManagementApi(config);
            var clientRequest = new ClientRequest(); // ClientRequest | 

            try
            {
                // Update client
                ClientResponse result = apiInstance.UpdateClient(clientRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagementApi.UpdateClient: " + e.Message );
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
 **clientRequest** | [**ClientRequest**](ClientRequest.md)|  | 

### Return type

[**ClientResponse**](ClientResponse.md)

### Authorization

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Authentication Error |  -  |
| **409** | Not Found |  -  |
| **429** | Rate Limited / Too Many Requests |  * Retry-After - Retry your call after the specified amount of seconds <br>  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

