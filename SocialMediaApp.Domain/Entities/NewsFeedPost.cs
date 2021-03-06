﻿using System.ComponentModel.DataAnnotations;

namespace SocialMediaApp.Domain.Entities
{
    public class NewsFeedPost
    {
        [Key]
        public string UserId {get; set;}
        public string UserName {get; set;}
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PostTextBody {get; set;}
    }
}
