
using System.Data.Entity;
using SocialMediaApp.Domain.Entities;

namespace SocialMediaApp.Domain
{
    public class socialContext : DbContext
    {
        public socialContext() : base("DefaultConnection")
        {
        }

        public DbSet<User> UserInformation { get; set; }
        public DbSet<NewsFeedPost> NewsFeed {get; set; }

        public static socialContext Create()
        {
            return new socialContext();
        }
    }
}
