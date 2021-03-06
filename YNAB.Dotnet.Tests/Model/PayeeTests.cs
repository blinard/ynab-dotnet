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
    ///  Class for testing Payee
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PayeeTests
    {
        // TODO uncomment below to declare an instance variable for Payee
        //private Payee instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Payee
            //instance = new Payee();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Payee
        /// </summary>
        [Test]
        public void PayeeInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Payee
            //Assert.IsInstanceOfType<Payee> (instance, "variable 'instance' is a Payee");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'TransferAccountId'
        /// </summary>
        [Test]
        public void TransferAccountIdTest()
        {
            // TODO unit test for the property 'TransferAccountId'
        }
        /// <summary>
        /// Test the property 'Deleted'
        /// </summary>
        [Test]
        public void DeletedTest()
        {
            // TODO unit test for the property 'Deleted'
        }

    }

}
