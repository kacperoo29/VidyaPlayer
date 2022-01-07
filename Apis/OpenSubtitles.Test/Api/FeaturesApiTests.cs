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
    ///  Class for testing FeaturesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FeaturesApiTests
    {
        private FeaturesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FeaturesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeaturesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' FeaturesApi
            //Assert.IsInstanceOf(typeof(FeaturesApi), instance);
        }

        
        /// <summary>
        /// Test Features
        /// </summary>
        [Test]
        public void FeaturesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //string type = null;
            //int? featureId = null;
            //string imdbId = null;
            //string tmdbId = null;
            //int? year = null;
            //var response = instance.Features(query, type, featureId, imdbId, tmdbId, year);
            //Assert.IsInstanceOf(typeof(InlineResponse2006), response, "response is InlineResponse2006");
        }
        
    }

}
