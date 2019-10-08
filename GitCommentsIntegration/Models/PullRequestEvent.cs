namespace GitCommentsIntegration.Models
{
    public class PullRequestEvent
    {
        public string action { get; set; }
        public Review review { get; set; }
        public PullRequest pullRequest { get; set; }
        public Repository repository { get; set; }
        public Sender sender { get; set; }
    }
}
