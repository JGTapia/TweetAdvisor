using System;
using System.Linq;
using TweetAdvisor.Core;

namespace TweetAdvisor.Services
{
    public static class DbInitializer
    {
        public static void Initialize(TweetsContext context)
        {
            context.Database.EnsureCreated();

            // Look for any tweets.
            if (context.Tweets.Any())
            {
                return;   // DB has been seeded
            }
            var tweets = new Tweet[]
            {
            new Tweet
            {
                TweetId = new Guid("0f8fad5b-d9cb-469f-a165-708677289501"),
                UserId = new Guid("0f8fad5b-d9cb-469f-a165-708677289503"),
                Date = new DateTime(2017,10,24,21,46,00),
                Latitude = 11111111111,
                Longitude = 11111111111,
                Category = 1,
                TweetText = "the test tweet text"
            },
            new Tweet
            {
                TweetId = new Guid("0f8fad5b-d9cb-469f-a165-708677289502"),
                UserId = new Guid("0f8fad5b-d9cb-469f-a165-708677289504"),
                Date = new DateTime(2017,10,24,21,47,00),
                Latitude = 22222222222,
                Longitude = 22222222222,
                Category = 2,
                TweetText = "test tweet text two"
            }
        };
            foreach (Tweet s in tweets)
            {
                context.Tweets.Add(s);
            }
            context.SaveChanges();

           
        }
    }
}