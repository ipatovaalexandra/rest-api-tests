using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace APIAutomationTestSuite.Steps
{
    [Binding]
    public sealed class APIApplication
    {
        [Given(@"I have a endpoint (.*)")]
        public void GivenIHaveAEndpointEndpoint(string endpoint)
        {
            RestApiHelper.SetUrl(endpoint);
        }

        //[Given(@"I have base url (.*)")]
        //public void GivenIHaveBaseUrl(string baseURL)
        //{
        //    ScenarioContext.Current.Pending();
        //}

        [When(@"I call get method of api")]
        public void WhenICallGetMethodOfApi()
        {
            RestApiHelper.CreateRequest();
        }

        [Then(@"I get API response in json format")]
        public void ThenIGetAPIResponseInJsonFormat()
        {
            var expected = "something";
            var response = RestApiHelper.GetResponse();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.That(response.Content, Is.EqualTo(expected), "Error Message");
            }
        }

    }
}
