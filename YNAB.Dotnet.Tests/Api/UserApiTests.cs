/* 
 * YNAB API Endpoints
 *
 * Our API uses a REST based design, leverages the JSON data format, and relies upon HTTPS for transport. We respond with meaningful HTTP response codes and if an error occurs, we include error details in the response body.  API Documentation is at https://api.youneedabudget.com
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using YNAB.Dotnet.Client;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Model;

namespace YNAB.Dotnet.Tests
{
    /// <summary>
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserApiTests
    {
        private UserApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserApi
            //Assert.IsInstanceOfType(typeof(UserApi), instance, "instance is a UserApi");
        }

        
        /// <summary>
        /// Test GetUser
        /// </summary>
        [Test]
        public void GetUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUser();
            //Assert.IsInstanceOf<UserResponse> (response, "response is UserResponse");
        }
        
    }

}
