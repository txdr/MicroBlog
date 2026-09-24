using MicroBlog.Models;
using MicroBlog.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MicroBlog.Pages
{
    public class DetailsModel : PageModel
    {

        public readonly PostStore _store;
        public DetailsModel(PostStore store) => _store = store;
        public Post? Post { get; private set; }


        public IActionResult OnGet(int id)
        {
            Post = _store.GetPostById(id);
            if (Post is null) return NotFound();
            return Page();
        }
    }
}
