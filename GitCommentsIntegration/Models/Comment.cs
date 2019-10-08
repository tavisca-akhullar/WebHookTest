using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCommentsIntegration.Models
{
    public class Comment
    {
        public string url { get; set; }
        public string html_url { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public User user { get; set; }
        public object position { get; set; }
        public object line { get; set; }
        public object path { get; set; }
        public string commit_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string author_association { get; set; }
        public string body { get; set; }
    }
}
