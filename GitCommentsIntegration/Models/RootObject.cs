using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCommentsIntegration.Models
{
    public class CommentEvent
    {
        public string action { get; set; }
        public Comment comment { get; set; }
        public Repository repository { get; set; }
        public Sender sender { get; set; }
    }
}
