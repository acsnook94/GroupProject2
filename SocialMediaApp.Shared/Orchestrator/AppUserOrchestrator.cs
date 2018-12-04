using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialMediaApp.Domain;
using SocialMediaApp.Shared.Interfaces;
using SocialMediaApp.Shared.ViewModels;
using System.Data.Entity;

namespace SocialMediaApp.Shared.Orchestrators
{
    public class AppUserOrchestrator : IAppUserOrchestrator
    {
        private socialContext _socialContext;

        public AppUserOrchestrator()
        {
            _socialContext = new socialContext();
        }
        public async Task<List<AppUserViewModel>> GetAllUsers()
        {
            var users = await _socialContext.Users.Select(x => new AppUserViewModel
            {
                userId = x.Id,
                UserName = x.UserName,
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

    }
}

