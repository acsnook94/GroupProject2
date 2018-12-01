using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMediaApp.Api.Models
{
    public class UserModel
    {
        public Guid userId { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string major { get; set; }
        public string universityName { get; set; }
    }
}