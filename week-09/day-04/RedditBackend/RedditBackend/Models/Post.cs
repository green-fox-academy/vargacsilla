using System.ComponentModel.DataAnnotations;

namespace RedditBackend.Entities
{
    public class Post
    {
        public long id { get; set; }
        public string title { get; set; }
        public DataType timestamp { get; set; }
        public int score { get; set; }
    }
}