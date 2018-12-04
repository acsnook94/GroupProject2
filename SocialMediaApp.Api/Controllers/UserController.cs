using SocialMediaApp.Shared.Orchestrators;
using SocialMediaApp.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace SocialMediaApp.Api.Controllers
{
    [Route("api/v1/users")]
    public class UserController : ApiController
    {
        private AppUserOrchestrator _appUserOrchestrator;

        public UserController()
        {
            _appUserOrchestrator = new AppUserOrchestrator();
        }

        public async Task<List<AppUserViewModel>> GetAllUsers()
        {
            var users = await _appUserOrchestrator.GetAllUsers();

            return users;
        }
    }
}
