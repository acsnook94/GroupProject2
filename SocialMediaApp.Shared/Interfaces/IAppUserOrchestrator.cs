using SocialMediaApp.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMediaApp.Shared.Interfaces
{
    interface IAppUserOrchestrator
    {
        Task<List<AppUserViewModel>> GetAllUsers();
    }
}
