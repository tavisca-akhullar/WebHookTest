using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCommentsIntegration.FactoryClasses
{
    public class RedirectFactoryClass
    {
        public static HttpContext GetRedirectRequest(HttpContext httpContext)
        {
            var eventType = httpContext.Request.Headers["X-Github-Event"];
            var path = httpContext.Request.Path.Value;
            switch (eventType)
            {
                case "pull_request_review":
                    httpContext.Request.Path = "/api/PullRequests";
                    break;

                case "commit_comment":
                    httpContext.Request.Path = "/api/Comments";
                    break;
            }
            return httpContext;
        }
    }
}
