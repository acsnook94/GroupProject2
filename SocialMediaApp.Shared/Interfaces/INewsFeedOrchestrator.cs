using SocialMediaApp.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMediaApp.Shared.Interfaces
{
    interface INewsFeedOrchestrator
    {
        Task<List<NewsPostViewModel>> GetAllPosts();
        Task<int> AddNewPost(NewsPostViewModel post);
    }
}
