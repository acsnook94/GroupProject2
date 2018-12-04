using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SocialMediaApp.Domain.Entities;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SocialMediaApp.Domain
{
    //=====================================================================================================================================================
    /*  The old "socialContext" class is now at the bottom of this file. It has replaced "ApplicationDbContext". */
    //=====================================================================================================================================================

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }


        //Custom user properties
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Major { get; set; }
        public string UniversityName { get; set; }
    }

    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    //{
    //    public ApplicationDbContext()
    //        : base("DefaultConnection", throwIfV1Schema: false)
    //    {
    //    }

    //    public static ApplicationDbContext Create()
    //    {
    //        return new ApplicationDbContext();
    //    }
    //}

    public class socialContext : IdentityDbContext<ApplicationUser>
    {
        public socialContext() : base("DefaultConnection")
        {
        }

        public override IDbSet<ApplicationUser> Users { get; set; }
        public DbSet<NewsFeedPost> NewsFeed {get; set; }

        public static socialContext Create()
        {
            return new socialContext();
        }
    }
}
 