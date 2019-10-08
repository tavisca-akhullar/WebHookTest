using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GitCommentsIntegration.FactoryClasses;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace GitCommentsIntegration
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RedirectionMiddleware
    {
        private readonly RequestDelegate _next;

        public RedirectionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine(httpContext.Request.Headers["X-Github-Event"]);
            httpContext = RedirectFactoryClass.GetRedirectRequest(httpContext);
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RedirectionMiddlewareExtensions
    {
        public static IApplicationBuilder UseRedirectionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RedirectionMiddleware>();
        }
    }
}
