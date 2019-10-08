using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GitCommentsIntegration.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RestSharp;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GitCommentsIntegration.Controllers
{
    [Route("api/[controller]")]
    public class PullRequestsController : Controller
    {
       
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public int Post([FromBody] PullRequestEvent value)
        { 
            var commentsCount = Comments.GetCommentsCount(value.repository.comments_url);
            return commentsCount;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
