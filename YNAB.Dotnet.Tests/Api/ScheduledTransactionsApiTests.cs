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
    ///  Class for testing ScheduledTransactionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ScheduledTransactionsApiTests
    {
        private ScheduledTransactionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ScheduledTransactionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ScheduledTransactionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ScheduledTransactionsApi
            //Assert.IsInstanceOfType(typeof(ScheduledTransactionsApi), instance, "instance is a ScheduledTransactionsApi");
        }

        
        /// <summary>
        /// Test GetScheduledTransactionById
        /// </summary>
        [Test]
        public void GetScheduledTransactionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? budgetId = null;
            //Guid? scheduledTransactionId = null;
            //var response = instance.GetScheduledTransactionById(budgetId, scheduledTransactionId);
            //Assert.IsInstanceOf<ScheduledTransactionResponse> (response, "response is ScheduledTransactionResponse");
        }
        
        /// <summary>
        /// Test GetScheduledTransactions
        /// </summary>
        [Test]
        public void GetScheduledTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? budgetId = null;
            //var response = instance.GetScheduledTransactions(budgetId);
            //Assert.IsInstanceOf<ScheduledTransactionsResponse> (response, "response is ScheduledTransactionsResponse");
        }
        
    }

}
