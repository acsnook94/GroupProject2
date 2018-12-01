using SocialMediaApp.Api.Models;
using SocialMediaApp.Domain;
using SocialMediaApp.Shared.Orchestrators;
using SocialMediaApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SocialMediaApp.Api.Controllers
{
    [Route("api/v1/users")]
    public class UserController : ApiController
    {
        private UserOrchestrator _userOrchestrator;

        public UserController()
        {
            _userOrchestrator = new UserOrchestrator();
        }

        public async Task<List<UserViewModel>> GetAllUsers()
        {
            var users = await _userOrchestrator.GetAllUsers();

            return users;
        }
    }
}
