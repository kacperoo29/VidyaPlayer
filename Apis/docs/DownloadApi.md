# OpenSubtitles.Api.DownloadApi

All URIs are relative to *https://api.opensubtitles.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Download**](DownloadApi.md#download) | **POST** /download | Download



## Download

> InlineResponse2008 Download (string contentType, InlineObject1 body = null)

Download

Request a download url for a subtitle.    > The download count is calculated on this action, not the file download itself  > IN and OUT FPS must be indicated for subtitle conversions, we want to make sure you know what you are doing, and therefore collected the current FPS from the subtitle search result, or calculated it somehow.  <!- - theme: warning - ->  > The download URL is temporary, and cannot be used more than 3 hours, so do not cache it, but you can download the file more than once if needed.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenSubtitles.Api;
using OpenSubtitles.Client;
using OpenSubtitles.Model;

namespace Example
{
    public class DownloadExample
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

            var apiInstance = new DownloadApi(Configuration.Default);
            var contentType = contentType_example;  // string | application/json (default to "application/json")
            var body = new InlineObject1(); // InlineObject1 |  (optional) 

            try
            {
                // Download
                InlineResponse2008 result = apiInstance.Download(contentType, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DownloadApi.Download: " + e.Message );
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
 **body** | [**InlineObject1**](InlineObject1.md)|  | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[Api-Key](../README.md#Api-Key), [Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request a download url for a subtitle.   |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

