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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<PostModel> model = await postService.GetAllPostsAsync();
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new PostModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(PostModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await postService.AddAsync(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
