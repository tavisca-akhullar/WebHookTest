using GitCommentsIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCommentsIntegration.DataAccess
{
    public class RootObjectDao
    {
       private static List<CommentEvent> _rootObjectsList = new List<CommentEvent>();
        public RootObjectDao()
        {
        }

        public IEnumerable<CommentEvent> GetComments()
        {
            return _rootObjectsList;
        }

        public bool AddComment(CommentEvent rootObject)
        {
            _rootObjectsList.Add(rootObject);
            return true;
        }
    }
}
