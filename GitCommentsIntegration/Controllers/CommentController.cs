using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GitCommentsIntegration.Models;
using GitCommentsIntegration.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GitCommentsIntegration.Controllers
{
    [Route("api/[controller]")]
    public class CommentController : Controller
    {
        private IRepository _repository;
        public CommentController(IRepository repository)
        {
            _repository = repository;
        }
        // GET: api/<controller>
        [HttpGet]
        [Route("values")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<string> GetComments()
        {
            IEnumerable<CommentEvent> rootObjects = _repository.GetComments();
            List<string> comments = new List<string>();
            foreach(var element in rootObjects)
            {
                comments.Add(element.sender.login +" Commented " +element.comment.body );
            }
            return comments;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        [Route("Add")]
        public string Post([FromBody]CommentEvent value)
        {
            var status = _repository.AddComment(value);
            if (status)
            {
                return value.comment.body;
            }
            else
            {
                return "Failed to add Comment";
            }
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
