using Microsoft.AspNetCore.Mvc;
using Web_1001_Fall_2022_Ef_Demo.Data;
using Web_1001_Fall_2022_Ef_Demo.Models;

namespace Web_1001_Fall_2022_Ef_Demo.Controllers
{
    public class BlogController : Controller
    {
        // public Blog Blog = new Blog() { Title = "Test Blog", Description = "Testing the Blog", PrimaryAuthor = "brent.ritchie@cambriancollege.ca", URL = new Uri("https://localhost/") };
        public BlogContext _db;

        public BlogController(BlogContext ctx)
        {
            _db = ctx;
        }

        public IActionResult Index(Blog pBlog)
        {

            var blog = _db.Blogs.ToList();

            if(ModelState.IsValid)
            {
                _db.Blogs.Add(pBlog);
                _db.SaveChanges();

                return View(pBlog);
            }

            return View(new Blog());
        }
    }
}
