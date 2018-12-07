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
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have base url (.*)")]
        public void GivenIHaveBaseUrl(string baseURL)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I call get method of api")]
        public void WhenICallGetMethodOfApi()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I get API response in json format")]
        public void ThenIGetAPIResponseInJsonFormat()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
