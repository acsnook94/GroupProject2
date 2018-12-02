
using System.Data.Entity;
using SocialMediaApp.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SocialMediaApp.Domain
{
    public class socialContext : IdentityDbContext<AppUser>
    {
        public DbSet<User> UserInformation { get; set; }
    }
}
