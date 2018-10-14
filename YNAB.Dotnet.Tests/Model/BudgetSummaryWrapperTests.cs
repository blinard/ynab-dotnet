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
    ///  Class for testing BudgetSummaryWrapper
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class BudgetSummaryWrapperTests
    {
        // TODO uncomment below to declare an instance variable for BudgetSummaryWrapper
        //private BudgetSummaryWrapper instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BudgetSummaryWrapper
            //instance = new BudgetSummaryWrapper();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BudgetSummaryWrapper
        /// </summary>
        [Test]
        public void BudgetSummaryWrapperInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BudgetSummaryWrapper
            //Assert.IsInstanceOfType<BudgetSummaryWrapper> (instance, "variable 'instance' is a BudgetSummaryWrapper");
        }


        /// <summary>
        /// Test the property 'Budgets'
        /// </summary>
        [Test]
        public void BudgetsTest()
        {
            // TODO unit test for the property 'Budgets'
        }

    }

}
