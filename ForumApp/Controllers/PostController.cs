namespace ForumApp.Controllers
{
    using ForumApp.Core.Contracts;
    using ForumApp.Core.Models;
    using Microsoft.AspNetCore.Mvc;

    public class PostController : Controller
    {
        private readonly IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<PostModel> model = await postService.GetAllPostsAsync();
            return View(model);
        }
    }
}
