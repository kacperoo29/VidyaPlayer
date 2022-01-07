# OpenSubtitles.Api.DiscoverApi

All URIs are relative to *https://api.opensubtitles.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Latest**](DiscoverApi.md#latest) | **GET** /discover/latest | Latest subtitles
[**MostDownloaded**](DiscoverApi.md#mostdownloaded) | **GET** /discover/most_downloaded | Most downloaded subtitles
[**Popular**](DiscoverApi.md#popular) | **GET** /discover/popular | Popular features



## Latest

> InlineResponse2004 Latest (string languages = null, string type = null)

Latest subtitles

Lists 60 latest uploaded subtitles

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenSubtitles.Api;
using OpenSubtitles.Client;
using OpenSubtitles.Model;

namespace Example
{
    public class LatestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.opensubtitles.com/api/v1";
            // Configure API key authorization: Api-Key
            Configuration.Default.AddApiKey("Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Api-Key", "Bearer");

            var apiInstance = new DiscoverApi(Configuration.Default);
            var languages = languages_example;  // string | Language code(s), coma separated (en,fr) or \"all\" (optional) 
            var type = type_example;  // string | Type (movie or tvshow) (optional) 

            try
            {
                // Latest subtitles
                InlineResponse2004 result = apiInstance.Latest(languages, type);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DiscoverApi.Latest: " + e.Message );
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
 **languages** | **string**| Language code(s), coma separated (en,fr) or \&quot;all\&quot; | [optional] 
 **type** | **string**| Type (movie or tvshow) | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

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


## MostDownloaded

> InlineResponse2005 MostDownloaded (string languages = null, string type = null)

Most downloaded subtitles

Discover popular subtitles, according to last 30 days downloads on opensubtitles.com. This list can be filtered by language code or feature type (movie, episode)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenSubtitles.Api;
using OpenSubtitles.Client;
using OpenSubtitles.Model;

namespace Example
{
    public class MostDownloadedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.opensubtitles.com/api/v1";
            // Configure API key authorization: Api-Key
            Configuration.Default.AddApiKey("Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Api-Key", "Bearer");

            var apiInstance = new DiscoverApi(Configuration.Default);
            var languages = languages_example;  // string | Language code(s), coma separated (en,fr), or \"all\" (optional) 
            var type = type_example;  // string | Type (movie or tvshow) (optional) 

            try
            {
                // Most downloaded subtitles
                InlineResponse2005 result = apiInstance.MostDownloaded(languages, type);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DiscoverApi.MostDownloaded: " + e.Message );
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
 **languages** | **string**| Language code(s), coma separated (en,fr), or \&quot;all\&quot; | [optional] 
 **type** | **string**| Type (movie or tvshow) | [optional] 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[Api-Key](../README.md#Api-Key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, example


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Lists most downloaded movie subtitles  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Popular

> Subtitle Popular (string languages = null, string type = null)

Popular features

Discover popular features on opensubtitles.com, according to last 30 days downloads.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenSubtitles.Api;
using OpenSubtitles.Client;
using OpenSubtitles.Model;

namespace Example
{
    public class PopularExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.opensubtitles.com/api/v1";
            // Configure API key authorization: Api-Key
            Configuration.Default.AddApiKey("Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Api-Key", "Bearer");

            var apiInstance = new DiscoverApi(Configuration.Default);
            var languages = languages_example;  // string | Language code(s), coma separated (en,fr) or \"all\" (optional) 
            var type = type_example;  // string | Type (movie or tvshow) (optional) 

            try
            {
                // Popular features
                Subtitle result = apiInstance.Popular(languages, type);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DiscoverApi.Popular: " + e.Message );
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
 **languages** | **string**| Language code(s), coma separated (en,fr) or \&quot;all\&quot; | [optional] 
 **type** | **string**| Type (movie or tvshow) | [optional] 

### Return type

[**Subtitle**](Subtitle.md)

### Authorization

[Api-Key](../README.md#Api-Key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

