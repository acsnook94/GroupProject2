using SocialMediaApp.Domain;
using SocialMediaApp.Domain.Entities;
using SocialMediaApp.Shared.Interfaces;
using SocialMediaApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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

        public async Task<int> AddNewPost(NewsPostViewModel post, AppUserViewModel user)
        {
            _socialContext.NewsFeed.Add(new NewsFeedPost
            {
                UserId = user.userId,
                UserName = user.UserName,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                PostTextBody=post.PostTextBody
            });

            return await _socialContext.SaveChangesAsync();
        }

        public async Task<List<NewsPostViewModel>> GetAllPosts()
        {
            var posts = await _socialContext.NewsFeed.Select(x => new NewsPostViewModel
            {
                UserName = x.UserName,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
                PostTextBody = x.PostTextBody
            }).ToListAsync();

            return posts;
        }

    }
}
