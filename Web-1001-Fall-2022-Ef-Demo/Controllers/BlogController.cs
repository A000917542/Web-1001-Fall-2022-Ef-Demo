using Microsoft.AspNetCore.Mvc;
using Web_1001_Fall_2022_Ef_Demo.Models;

namespace Web_1001_Fall_2022_Ef_Demo.Controllers
{
    public class BlogController : Controller
    {
        public Blog Blog = new Blog() { Title = "Test Blog", Description = "Testing the Blog", PrimaryAuthor = "brent.ritchie@cambriancollege.ca", URL = new Uri("https://localhost/") };

        public IActionResult Index(Blog pBlog)
        {
            if(ModelState.IsValid)
            {
                return View(Blog);
            }

            return View(pBlog);
        }
    }
}
