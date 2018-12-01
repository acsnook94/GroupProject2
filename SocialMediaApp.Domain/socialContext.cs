using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMediaApp.Domain;
using System.Data.Entity;
using SocialMediaApp.Domain.Entities;

namespace SocialMediaApp.Domain
{
    public class socialContext : DbContext
    {
        public DbSet<User> UserInformation { get; set; }
    }
}
