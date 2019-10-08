namespace GitCommentsIntegration.Models
{
    public class Head
    {
        public string label { get; set; }
        public string @ref { get; set; }
        public string sha { get; set; }
        public User user { get; set; }
        public Repository repo { get; set; }
    }
}
