using SocialMediaApp.Domain;
using SocialMediaApp.Domain.Entities;
using SocialMediaApp.Shared.Interfaces;
using SocialMediaApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMediaApp.Shared.Orchestrator
{
    public class NewsFeedOrchestrator : INewsFeedOrchestrator
    {
        private socialContext _socialContext;

        public NewsFeedOrchestrator()
        {
            _socialContext = new socialContext();
        }

        public Task<int> AddNewPost(NewsPostViewModel post)
        {
            _socialContext.NewsFeed.Add(new NewsFeedPost
            {
                UserId = User.Identity
            }
        }

        public Task<List<NewsPostViewModel>> GetAllPosts()
        {
            throw new NotImplementedException();
        }
    }
}
