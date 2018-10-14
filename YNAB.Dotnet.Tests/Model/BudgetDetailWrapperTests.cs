/* 
 * YNAB API Endpoints
 *
 * Our API uses a REST based design, leverages the JSON data format, and relies upon HTTPS for transport. We respond with meaningful HTTP response codes and if an error occurs, we include error details in the response body.  API Documentation is at https://api.youneedabudget.com
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using YNAB.Dotnet.Api;
using YNAB.Dotnet.Model;
using YNAB.Dotnet.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace YNAB.Dotnet.Tests
{
    /// <summary>
    ///  Class for testing BudgetDetailWrapper
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class BudgetDetailWrapperTests
    {
        // TODO uncomment below to declare an instance variable for BudgetDetailWrapper
        //private BudgetDetailWrapper instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BudgetDetailWrapper
            //instance = new BudgetDetailWrapper();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BudgetDetailWrapper
        /// </summary>
        [Test]
        public void BudgetDetailWrapperInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BudgetDetailWrapper
            //Assert.IsInstanceOfType<BudgetDetailWrapper> (instance, "variable 'instance' is a BudgetDetailWrapper");
        }


        /// <summary>
        /// Test the property 'Budget'
        /// </summary>
        [Test]
        public void BudgetTest()
        {
            // TODO unit test for the property 'Budget'
        }
        /// <summary>
        /// Test the property 'ServerKnowledge'
        /// </summary>
        [Test]
        public void ServerKnowledgeTest()
        {
            // TODO unit test for the property 'ServerKnowledge'
        }

    }

}
