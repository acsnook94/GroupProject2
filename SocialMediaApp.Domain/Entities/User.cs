using System;

namespace SocialMediaApp.Domain.Entities
{
    public class User
    {
        public Guid userId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        
    }
}
