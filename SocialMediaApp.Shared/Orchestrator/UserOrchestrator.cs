using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMediaApp.Domain;
using SocialMediaApp.Shared.Interfaces;
using SocialMediaApp.Shared.ViewModels;
using SocialMediaApp.Domain.Entities;

namespace SocialMediaApp.Shared.Orchestrators
{
    public class UserOrchestrator : IUserOrchestrator
    {
        private socialContext _socialContext;

        public UserOrchestrator()
        {
            _socialContext = new socialContext();
        }
        public async Task<List<UserViewModel>> GetAllUsers()
        {
            var users = await _socialContext.UserInformation.Select(x => new UserViewModel
            {
                userId = x.userId,
                UserName = x.UserName,
                Password = x.Password,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
                City = x.City,
                State = x.State,
                Country = x.Country,
                Major = x.Major,
                UniversityName = x.UniversityName
            }).ToListAsync();

            return users;
        }

        public async Task<int> RegisterUser(UserViewModel user)
        {
            _socialContext.UserInformation.Add(new User
            {
                userId = user.userId,
                UserName = user.UserName,
                Password = user.Password,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                City = user.City,
                State = user.State,
                Country = user.Country,
                Major = user.Major,
                UniversityName = user.UniversityName
            });

            return await _socialContext.SaveChangesAsync();
        }
    }
}

