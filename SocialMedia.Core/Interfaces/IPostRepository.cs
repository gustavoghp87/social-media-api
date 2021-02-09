using SocialMedia.Core.Data;
//using SocialMedia.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia.Core.Interfaces
{
    public interface IPostRepository
    {
        //Task<IEnumerable<PostDeprecated>> GetPosts();
        Task<IEnumerable<Post>> GetPosts();
        Task<Post> GetPosts(int id);
    }
}
