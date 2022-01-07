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
    ///  Class for testing AuthenticationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuthenticationApiTests
    {
        private AuthenticationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuthenticationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuthenticationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' AuthenticationApi
            //Assert.IsInstanceOf(typeof(AuthenticationApi), instance);
        }

        
        /// <summary>
        /// Test Login
        /// </summary>
        [Test]
        public void LoginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //InlineObject inlineObject = null;
            //var response = instance.Login(contentType, inlineObject);
            //Assert.IsInstanceOf(typeof(InlineResponse200), response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test Logout
        /// </summary>
        [Test]
        public void LogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Logout();
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
    }

}