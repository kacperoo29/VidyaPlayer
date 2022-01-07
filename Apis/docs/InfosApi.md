# OpenSubtitles.Api.InfosApi

All URIs are relative to *https://api.opensubtitles.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Formats**](InfosApi.md#formats) | **GET** /infos/formats | Subtitle Formats
[**Languages**](InfosApi.md#languages) | **GET** /infos/languages | Languages
[**Userinfo**](InfosApi.md#userinfo) | **GET** /infos/user | User Informations



## Formats

> InlineResponse2001 Formats ()

Subtitle Formats

List subtitle formats recognized by the API  

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenSubtitles.Api;
using OpenSubtitles.Client;
using OpenSubtitles.Model;

namespace Example
{
    public class FormatsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.opensubtitles.com/api/v1";
            // Configure API key authorization: Api-Key
            Configuration.Default.AddApiKey("Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Api-Key", "Bearer");

            var apiInstance = new InfosApi(Configuration.Default);

            try
            {
                // Subtitle Formats
                InlineResponse2001 result = apiInstance.Formats();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InfosApi.Formats: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[Api-Key](../README.md#Api-Key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, example


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Languages

> InlineResponse2002 Languages ()

Languages

Get the languages information

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenSubtitles.Api;
using OpenSubtitles.Client;
using OpenSubtitles.Model;

namespace Example
{
    public class LanguagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.opensubtitles.com/api/v1";
            // Configure API key authorization: Api-Key
            Configuration.Default.AddApiKey("Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Api-Key", "Bearer");

            var apiInstance = new InfosApi(Configuration.Default);

            try
            {
                // Languages
                InlineResponse2002 result = apiInstance.Languages();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InfosApi.Languages: " + e.Message );
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

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[Api-Key](../README.md#Api-Key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, example


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get the languages table containing the codes and names used through the API |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Userinfo

> InlineResponse2003 Userinfo ()

User Informations

Gather informations about the user authenticated by a bearer token. User information are already sent when user is authenticated, and the remaining downloads is returned with each download, but you can also get these information here.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenSubtitles.Api;
using OpenSubtitles.Client;
using OpenSubtitles.Model;

namespace Example
{
    public class UserinfoExample
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

            var apiInstance = new InfosApi(Configuration.Default);

            try
            {
                // User Informations
                InlineResponse2003 result = apiInstance.Userinfo();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InfosApi.Userinfo: " + e.Message );
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

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[Api-Key](../README.md#Api-Key), [Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get user data |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

