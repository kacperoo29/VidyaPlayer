# OpenSubtitles.Api.SubtitlesApi

All URIs are relative to *https://api.opensubtitles.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Subtitles**](SubtitlesApi.md#subtitles) | **GET** /subtitles | Search for subtitles



## Subtitles

> InlineResponse2007 Subtitles (int? id = null, int? imdbId = null, int? tmdbId = null, string type = null, string query = null, string languages = null, string moviehash = null, int? userId = null, string hearingImpaired = null, string foreignPartsOnly = null, string trustedSources = null, string machineTranslated = null, string aiTranslated = null, string orderBy = null, string orderDirection = null, int? parentFeatureId = null, int? parentImdbId = null, int? parentTmdbId = null, int? seasonNumber = null, int? episodeNumber = null, int? year = null, string moviehashMatch = null, int? page = null)

Search for subtitles

Find subtitle for a video file. All parameters can be combined following various logics: searching by a specific external id (imdb, tmdb), a file moviehash, or a simple text query.  Implement the logic that best fit your needs, remembering that: - if you can get moviehash from file - send it - if you know the ID, IMDB or TMDB, send this rather than a query, an ID will always be more precise - if you search for TV show episodes, sending the parent ID, episode and season number will give best results - send the filename as query parameter together with the moviehash for better results. If your filenames are generally irrelevant, for example a dynamically generated filename from a streaming service, no need to send it. - you can combine all together (send everything what you have and we will take of rest)   > Avoid http redirection by sending request parameters sorted and without default values, and send all queries in lowercase. Remove leading zeroes in IMDB ID  ### Moviehash  If a moviehash is sent with a request, a \"moviehash_match\" boolean field will be added to the response.  The matching subtitles will always come first in the response.   ### Ordering You can order the results using the *order_by* parameter. Ordering is possible on the following fields: _ language, download_count, new_download_count, hearing_impaired, hd, format, fps, votes, points, ratings, from_trusted, foreign_parts_only, ai_translated, machine_translated, upload_date, release, comments _  Change the order direction with *order_direction* (asc/desc)  

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenSubtitles.Api;
using OpenSubtitles.Client;
using OpenSubtitles.Model;

namespace Example
{
    public class SubtitlesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.opensubtitles.com/api/v1";
            // Configure API key authorization: Api-Key
            Configuration.Default.AddApiKey("Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Api-Key", "Bearer");

            var apiInstance = new SubtitlesApi(Configuration.Default);
            var id = 56;  // int? | ID of the movie or episode (optional) 
            var imdbId = 56;  // int? | IMDB ID of the movie or episode (optional) 
            var tmdbId = 56;  // int? | TMDB ID of the movie or episode (optional) 
            var type = type_example;  // string | movie, episode or all, (default: all)  (optional) 
            var query = query_example;  // string | file name or text search (optional) 
            var languages = languages_example;  // string | Language code(s), coma separated (en,fr) (optional) 
            var moviehash = moviehash_example;  // string | Moviehash of the movie (optional) 
            var userId = 56;  // int? | To be used alone - for user uploads listing (optional) 
            var hearingImpaired = hearingImpaired_example;  // string | include, exclude, only. (default: include) (optional) 
            var foreignPartsOnly = foreignPartsOnly_example;  // string | exclude, include, only (default: include) (optional) 
            var trustedSources = trustedSources_example;  // string | include, only (default: include) (optional) 
            var machineTranslated = machineTranslated_example;  // string | exclude, include  (default: exclude) (optional) 
            var aiTranslated = aiTranslated_example;  // string | exclude, include  (default: exclude) (optional) 
            var orderBy = orderBy_example;  // string | Order of the returned results, accept any of above fields (optional) 
            var orderDirection = orderDirection_example;  // string | Order direction of the returned results (asc,desc) (optional) 
            var parentFeatureId = 56;  // int? | For Tvshows (optional) 
            var parentImdbId = 56;  // int? | For Tvshows (optional) 
            var parentTmdbId = 56;  // int? | For Tvshows (optional) 
            var seasonNumber = 56;  // int? | For Tvshows  (optional) 
            var episodeNumber = 56;  // int? | For Tvshows (optional) 
            var year = 56;  // int? | Filter by movie/episode year (optional) 
            var moviehashMatch = moviehashMatch_example;  // string | include, only (default: include) (optional) 
            var page = 56;  // int? | Results page to display (optional) 

            try
            {
                // Search for subtitles
                InlineResponse2007 result = apiInstance.Subtitles(id, imdbId, tmdbId, type, query, languages, moviehash, userId, hearingImpaired, foreignPartsOnly, trustedSources, machineTranslated, aiTranslated, orderBy, orderDirection, parentFeatureId, parentImdbId, parentTmdbId, seasonNumber, episodeNumber, year, moviehashMatch, page);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubtitlesApi.Subtitles: " + e.Message );
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
 **id** | **int?**| ID of the movie or episode | [optional] 
 **imdbId** | **int?**| IMDB ID of the movie or episode | [optional] 
 **tmdbId** | **int?**| TMDB ID of the movie or episode | [optional] 
 **type** | **string**| movie, episode or all, (default: all)  | [optional] 
 **query** | **string**| file name or text search | [optional] 
 **languages** | **string**| Language code(s), coma separated (en,fr) | [optional] 
 **moviehash** | **string**| Moviehash of the movie | [optional] 
 **userId** | **int?**| To be used alone - for user uploads listing | [optional] 
 **hearingImpaired** | **string**| include, exclude, only. (default: include) | [optional] 
 **foreignPartsOnly** | **string**| exclude, include, only (default: include) | [optional] 
 **trustedSources** | **string**| include, only (default: include) | [optional] 
 **machineTranslated** | **string**| exclude, include  (default: exclude) | [optional] 
 **aiTranslated** | **string**| exclude, include  (default: exclude) | [optional] 
 **orderBy** | **string**| Order of the returned results, accept any of above fields | [optional] 
 **orderDirection** | **string**| Order direction of the returned results (asc,desc) | [optional] 
 **parentFeatureId** | **int?**| For Tvshows | [optional] 
 **parentImdbId** | **int?**| For Tvshows | [optional] 
 **parentTmdbId** | **int?**| For Tvshows | [optional] 
 **seasonNumber** | **int?**| For Tvshows  | [optional] 
 **episodeNumber** | **int?**| For Tvshows | [optional] 
 **year** | **int?**| Filter by movie/episode year | [optional] 
 **moviehashMatch** | **string**| include, only (default: include) | [optional] 
 **page** | **int?**| Results page to display | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[Api-Key](../README.md#Api-Key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Find subtitles for a video file  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

