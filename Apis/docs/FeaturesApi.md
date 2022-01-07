# OpenSubtitles.Api.FeaturesApi

All URIs are relative to *https://api.opensubtitles.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Features**](FeaturesApi.md#features) | **GET** /features | Search for features



## Features

> InlineResponse2006 Features (string query = null, string type = null, int? featureId = null, string imdbId = null, string tmdbId = null, int? year = null)

Search for features

With the \"query\" parameter, search for a Feature from a simple text input. Typically used for a text search or autocomplete.  With an ID, get basic information and subtitles count for a specific title.  <!- - theme: warning - ->  > ### Watch Out! > > If you create an autocomplete, don't set a too small refresh limit, remember you must not go over 40 requests per 10 seconds!

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenSubtitles.Api;
using OpenSubtitles.Client;
using OpenSubtitles.Model;

namespace Example
{
    public class FeaturesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.opensubtitles.com/api/v1";
            // Configure API key authorization: Api-Key
            Configuration.Default.AddApiKey("Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Api-Key", "Bearer");

            var apiInstance = new FeaturesApi(Configuration.Default);
            var query = query_example;  // string | quary to search (optional) 
            var type = type_example;  // string | empty to list all or **movie**, **tvshow** or **episode**. (optional) 
            var featureId = 56;  // int? | opensubtitles **feature_id** (optional) 
            var imdbId = imdbId_example;  // string | IMDB ID, delete leading zeroes (optional) 
            var tmdbId = tmdbId_example;  // string | TheMovieDB ID - combine with type to avoid errors (optional) 
            var year = 56;  // int? | Filter by year. Can only be used in combination with a query (optional) 

            try
            {
                // Search for features
                InlineResponse2006 result = apiInstance.Features(query, type, featureId, imdbId, tmdbId, year);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FeaturesApi.Features: " + e.Message );
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
 **query** | **string**| quary to search | [optional] 
 **type** | **string**| empty to list all or **movie**, **tvshow** or **episode**. | [optional] 
 **featureId** | **int?**| opensubtitles **feature_id** | [optional] 
 **imdbId** | **string**| IMDB ID, delete leading zeroes | [optional] 
 **tmdbId** | **string**| TheMovieDB ID - combine with type to avoid errors | [optional] 
 **year** | **int?**| Filter by year. Can only be used in combination with a query | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[Api-Key](../README.md#Api-Key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, example


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Search for a feature |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

