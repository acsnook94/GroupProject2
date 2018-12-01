using SocialMediaApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp.Shared.Interfaces
{
    interface IUserOrchestrator
    {
        Task<List<UserViewModel>> GetAllUsers();
        Task<int> RegisterUser(UserViewModel user);
    }
}
