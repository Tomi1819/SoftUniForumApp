namespace ForumApp.Core.Services
{
    using ForumApp.Core.Contracts;
    using ForumApp.Core.Models;
    using ForumApp.Infrastructure.Data;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    public class PostService : IPostService
    {
        private readonly ForumAppDbContext dbContext;

        public PostService(ForumAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<PostModel>> GetAllPostsAsync()
        {
            return await dbContext.Posts
                .Select(p => new PostModel()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content,
                })
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
