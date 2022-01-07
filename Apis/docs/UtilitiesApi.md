# OpenSubtitles.Api.UtilitiesApi

All URIs are relative to *https://api.opensubtitles.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Guessit**](UtilitiesApi.md#guessit) | **GET** /utilities/guessit | Guessit



## Guessit

> InlineResponse2009 Guessit (string filename = null)

Guessit

Extracts as much information as possible from a video filename.  It has a very powerful matcher that allows to guess properties from a video using its filename only. This matcher works with both movies and tv shows episodes.  This is a simple implementation of the python guessit library. https://doc.guessit.io  Find examples of the returned data. https://doc.guessit.io/properties/

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenSubtitles.Api;
using OpenSubtitles.Client;
using OpenSubtitles.Model;

namespace Example
{
    public class GuessitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.opensubtitles.com/api/v1";
            // Configure API key authorization: Api-Key
            Configuration.Default.AddApiKey("Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Api-Key", "Bearer");

            var apiInstance = new UtilitiesApi(Configuration.Default);
            var filename = filename_example;  // string | File name (optional) 

            try
            {
                // Guessit
                InlineResponse2009 result = apiInstance.Guessit(filename);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UtilitiesApi.Guessit: " + e.Message );
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
 **filename** | **string**| File name | [optional] 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

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

