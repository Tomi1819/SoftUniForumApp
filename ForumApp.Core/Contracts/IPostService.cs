namespace ForumApp.Core.Contracts
{
    using ForumApp.Core.Models;
    public interface IPostService
    {
        Task AddAsync(PostModel model);
        Task<IEnumerable<PostModel>> GetAllPostsAsync();
    }
}
