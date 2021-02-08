using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Data;
//using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly SocialMediaContext _context;
        public PostRepository(SocialMediaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Publicacion>> GetPosts()
        {
            var posts = await _context.Publicacion.ToListAsync();
            //var posts = Enumerable.Range(1, 10).Select(x => new Post
            //{
            //    PostId = x,
            //    Description = $"Description {x}",
            //    Date = DateTime.Now,
            //    Image = $"https://misapis.com/{x}",
            //    UserId = x*2
            //});
            //await Task.Delay(10);
            return posts;
        }
    }
}
