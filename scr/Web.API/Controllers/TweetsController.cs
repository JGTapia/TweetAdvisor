using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TweetAdvisor.Services;
using TweetAdvisor.Core;

namespace TweetAdvisor.Web.API.Web.Controllers
{
    [Route("api/[controller]")]
    public class TweetsController : Controller
    {
        private readonly TweetsContext _context;


        public TweetsController(TweetsContext context)
        {
            _context = context;
        }

        // GET api/Tweet
        [HttpGet]
        public IEnumerable<Tweet> Get()
        {
            return _context.Tweets.ToList();
        }

        // GET api/Tweet/5
        [HttpGet("{id}")]
        public Tweet Get(Guid id)
        {
            return _context.Tweets.ToList().Find(x => x.TweetId == id);
        }

        // POST api/Tweet
        [HttpPost]
        public void Post([FromBody]Tweet tweet)
        {
            _context.Tweets.Add(tweet);
        }

        // PUT api/Tweet/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]Tweet tweet)
        {
            var index = _context.Tweets.ToList().FindIndex(x => x.TweetId == id);
            _context.Tweets.ToList()[index] = tweet;
        }

        // DELETE api/Tweet/5
        [HttpDelete("{id}")]
        public void Delete(Tweet tweet)
        {
            _context.Tweets.Remove(tweet);
        }
    }
}
