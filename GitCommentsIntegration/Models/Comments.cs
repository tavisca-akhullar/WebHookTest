using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace GitCommentsIntegration.Models
{
    public class Comments
    {
        private static readonly string _accessToken = "23ef4102b03648cc5b8e1393c61878777e50ec23";
        public string href { get; set; }
        public static int GetCommentsCount(string url)
        {

            string review_comments_url = url;
            RestClient restClient = new RestClient(review_comments_url.Split('{')[0]);
            RestRequest restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Authorization", $"Bearer {_accessToken}");
            IRestResponse response = restClient.Execute(restRequest);
            JObject commentsJson = JObject.Parse("{ 'comments':" + response.Content + "}");
            var commentsCount = commentsJson.SelectToken("comments").Count(); ;
            return commentsCount;
        }
    }

   
}
