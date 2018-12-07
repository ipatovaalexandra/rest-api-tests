﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAutomationTestSuite
{
    public static class RestApiHelper
    {
        public static RestClient client;
        public static RestRequest restRequest;
        public static string baseUrl = "https://google.com";

        public static RestClient SetUrl(string endpoint)
        {
            Path.Combine(baseUrl, endpoint); // 
            var url = string.Format("{0}/{1}", baseUrl, endpoint);
            return client = new RestClient(url);
        }

        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
        }
    }
}
