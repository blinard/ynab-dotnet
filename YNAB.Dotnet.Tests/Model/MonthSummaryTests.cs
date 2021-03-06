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
    ///  Class for testing MonthSummary
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MonthSummaryTests
    {
        // TODO uncomment below to declare an instance variable for MonthSummary
        //private MonthSummary instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MonthSummary
            //instance = new MonthSummary();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MonthSummary
        /// </summary>
        [Test]
        public void MonthSummaryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MonthSummary
            //Assert.IsInstanceOfType<MonthSummary> (instance, "variable 'instance' is a MonthSummary");
        }


        /// <summary>
        /// Test the property 'Month'
        /// </summary>
        [Test]
        public void MonthTest()
        {
            // TODO unit test for the property 'Month'
        }
        /// <summary>
        /// Test the property 'Note'
        /// </summary>
        [Test]
        public void NoteTest()
        {
            // TODO unit test for the property 'Note'
        }
        /// <summary>
        /// Test the property 'Income'
        /// </summary>
        [Test]
        public void IncomeTest()
        {
            // TODO unit test for the property 'Income'
        }
        /// <summary>
        /// Test the property 'Budgeted'
        /// </summary>
        [Test]
        public void BudgetedTest()
        {
            // TODO unit test for the property 'Budgeted'
        }
        /// <summary>
        /// Test the property 'Activity'
        /// </summary>
        [Test]
        public void ActivityTest()
        {
            // TODO unit test for the property 'Activity'
        }
        /// <summary>
        /// Test the property 'ToBeBudgeted'
        /// </summary>
        [Test]
        public void ToBeBudgetedTest()
        {
            // TODO unit test for the property 'ToBeBudgeted'
        }
        /// <summary>
        /// Test the property 'AgeOfMoney'
        /// </summary>
        [Test]
        public void AgeOfMoneyTest()
        {
            // TODO unit test for the property 'AgeOfMoney'
        }

    }

}
