/*
 * OpenSubtitles API
 *
 * Explore subtitles API here
 *
 * The version of the OpenAPI document: 1.0.1
 * Contact: support@opensubtitles.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using OpenSubtitles.Client;
using OpenSubtitles.Api;
using OpenSubtitles.Model;

namespace OpenSubtitles.Test
{
    /// <summary>
    ///  Class for testing SubtitlesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SubtitlesApiTests
    {
        private SubtitlesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SubtitlesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubtitlesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' SubtitlesApi
            //Assert.IsInstanceOf(typeof(SubtitlesApi), instance);
        }

        
        /// <summary>
        /// Test Subtitles
        /// </summary>
        [Test]
        public void SubtitlesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //int? imdbId = null;
            //int? tmdbId = null;
            //string type = null;
            //string query = null;
            //string languages = null;
            //string moviehash = null;
            //int? userId = null;
            //string hearingImpaired = null;
            //string foreignPartsOnly = null;
            //string trustedSources = null;
            //string machineTranslated = null;
            //string aiTranslated = null;
            //string orderBy = null;
            //string orderDirection = null;
            //int? parentFeatureId = null;
            //int? parentImdbId = null;
            //int? parentTmdbId = null;
            //int? seasonNumber = null;
            //int? episodeNumber = null;
            //int? year = null;
            //string moviehashMatch = null;
            //int? page = null;
            //var response = instance.Subtitles(id, imdbId, tmdbId, type, query, languages, moviehash, userId, hearingImpaired, foreignPartsOnly, trustedSources, machineTranslated, aiTranslated, orderBy, orderDirection, parentFeatureId, parentImdbId, parentTmdbId, seasonNumber, episodeNumber, year, moviehashMatch, page);
            //Assert.IsInstanceOf(typeof(InlineResponse2007), response, "response is InlineResponse2007");
        }
        
    }

}
