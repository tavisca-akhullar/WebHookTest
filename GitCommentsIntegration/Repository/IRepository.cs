using GitCommentsIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCommentsIntegration.Repository
{
    public interface IRepository
    {
        IEnumerable<CommentEvent> GetComments();
        bool AddComment(CommentEvent rootObject);
    }   
}
