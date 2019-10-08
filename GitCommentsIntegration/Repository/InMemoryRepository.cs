using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GitCommentsIntegration.DataAccess;
using GitCommentsIntegration.Models;

namespace GitCommentsIntegration.Repository
{
    public class InMemoryRepository : IRepository
    {
        private RootObjectDao _rootObjectDao;
        public InMemoryRepository()
        {
            _rootObjectDao = new RootObjectDao();
        }
        public bool AddComment(CommentEvent rootObject)
        {
           return _rootObjectDao.AddComment(rootObject);
        }

        public IEnumerable<CommentEvent> GetComments()
        {
          return  _rootObjectDao.GetComments();
        }
    }
}
