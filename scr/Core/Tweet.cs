using System;
using System.ComponentModel.DataAnnotations;

namespace TweetAdvisor.Core
{
    public class Tweet
    {

        public Guid TweetId { get; set; }
        public Guid UserId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Category { get; set; }
        [Required]
        public decimal Latitude { get; set; }
        [Required]
        public decimal Longitude { get; set; }
        [Required]
        public string TweetText { get; set; }
    }
}
