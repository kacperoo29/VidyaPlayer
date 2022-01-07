# OpenSubtitles.Api.AuthenticationApi

All URIs are relative to *https://api.opensubtitles.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Login**](AuthenticationApi.md#login) | **POST** /login | Login
[**Logout**](AuthenticationApi.md#logout) | **DELETE** /logout | Logout



## Login

> InlineResponse200 Login (string contentType, InlineObject inlineObject = null)

Login

Create a token to authenticate a user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenSubtitles.Api;
using OpenSubtitles.Client;
using OpenSubtitles.Model;

namespace Example
{
    public class LoginExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.opensubtitles.com/api/v1";
            // Configure API key authorization: Api-Key
            Configuration.Default.AddApiKey("Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Api-Key", "Bearer");

            var apiInstance = new AuthenticationApi(Configuration.Default);
            var contentType = contentType_example;  // string | application/json (default to "application/json")
            var inlineObject = new InlineObject(); // InlineObject |  (optional) 

            try
            {
                // Login
                InlineResponse200 result = apiInstance.Login(contentType, inlineObject);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Login: " + e.Message );
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
 **contentType** | **string**| application/json | [default to &quot;application/json&quot;]
 **inlineObject** | [**InlineObject**](InlineObject.md)|  | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[Api-Key](../README.md#Api-Key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Create session and token |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Logout

> Object Logout ()

Logout

Destroy a user token to end a session. Bearer token is required for this endpoint.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenSubtitles.Api;
using OpenSubtitles.Client;
using OpenSubtitles.Model;

namespace Example
{
    public class LogoutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.opensubtitles.com/api/v1";
            // Configure API key authorization: Api-Key
            Configuration.Default.AddApiKey("Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Api-Key", "Bearer");
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi(Configuration.Default);

            try
            {
                // Logout
                Object result = apiInstance.Logout();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Logout: " + e.Message );
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

**Object**

### Authorization

[Api-Key](../README.md#Api-Key), [Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Destroy session and current token |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

