using Microsoft.EntityFrameworkCore;
using TweetAdvisor.Core;

namespace TweetAdvisor.Services
{
    public class TweetsContext : DbContext
    {

        public TweetsContext(DbContextOptions<TweetsContext> options) : base(options)
        {
        }

        public DbSet<Tweet> Tweets { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tweet>().ToTable("Tweet");
        }
        
    }
}
