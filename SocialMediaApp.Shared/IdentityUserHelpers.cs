using System.Security.Claims;
 
namespace SocialMediaApp.Shared
{
    public static class IdentityUserHelpers
    {
        public static string getUserId(this ClaimsPrincipal user)
        {
            if (!user.Identity.IsAuthenticated)
                return null;
 
            ClaimsPrincipal currentUser = user;
            return currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
 
    }
}