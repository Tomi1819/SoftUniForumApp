namespace ForumApp.Infrastructure.Data.Configuration
{
    using ForumApp.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        private readonly Post[] initialPosts = new Post[]
        {
            new Post()
            {
                Id = 1,
                Title = "First post",
                Content = "This is my first content."
            },

            new Post()
            {
                Id = 2,
                Title = "Second post",
                Content = "This is my second content."
            },

            new Post()
            {
                Id = 3,
                Title = "Third post",
                Content = "This is my third content."
            }
        };

        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(initialPosts);
        }
    }
}
