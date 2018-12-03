using System;

namespace SocialMediaApp.Domain.Entities
{
    public class User
    {
        public Guid userId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Major { get; set; }
        public string UniversityName { get; set; }
    }
}
