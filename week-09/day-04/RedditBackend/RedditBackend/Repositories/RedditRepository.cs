using RedditBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Repositories
{
    public class RedditRepository
    {
        RedditContext RedditContext;

        public RedditRepository(RedditContext redditContext)
        {
            RedditContext = redditContext;
        }
    }
}
