namespace ForumApp.Core.Services
{
    using ForumApp.Core.Contracts;
    using ForumApp.Core.Models;
    using ForumApp.Infrastructure.Data;
    using ForumApp.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;

    public class PostService : IPostService
    {
        private readonly ForumAppDbContext dbContext;
        private readonly ILogger logger;

        public PostService(
            ForumAppDbContext dbContext,
            ILogger<PostService> logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }

        public async Task AddAsync(PostModel model)
        {
            var entity = new Post()
            {
                Title = model.Title,
                Content = model.Content
            };

            try
            {
                await dbContext.Posts.AddAsync(entity);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                logger.LogError(e, "PostService.AddAsync");

                throw new ApplicationException("Operation failed. Please, try again..");
            }
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
