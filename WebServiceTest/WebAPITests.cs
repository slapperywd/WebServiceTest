using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using NUnit.Framework;
using RestSharp;
using WebServiceTest.Entities;
using WebServiceTest.Utils;

namespace WebServiceTest
{
    [TestFixture]
    public class WebAPITests
    {
        private string url = "https://jsonplaceholder.typicode.com/users";
        private RestRequest request;
        private IRestResponse<List<User>> response;

        [OneTimeSetUp]
        public void FixtureSetup()
        {
           request = new RestRequest(Method.GET);
           request.AddHeader("Cache-Control", "no-cache");
           response = RestHelper.ExecuteRequest<List<User>>(request, url);
        }

        [Test]
        public void StatusResponseCodeShouldBe200()
        {
            Assert.IsTrue(response.StatusCode == HttpStatusCode.OK);
        }

        [Test]
        public void VerifyContentTypeExistence()
        {
            Assert.IsTrue(response.Headers.Any(x => x.Name.ToLower().Contains("content-type")));
            Assert.IsTrue(response.Headers.Any(x => x.Value.ToString().Contains("application/json; charset=utf-8")));
        }

        [Test]
        public void VerifyThatResponseContaintAtLeast10Users()
        {
            Assert.IsTrue(response.Data.Count >= 10);
        }
    }
}
