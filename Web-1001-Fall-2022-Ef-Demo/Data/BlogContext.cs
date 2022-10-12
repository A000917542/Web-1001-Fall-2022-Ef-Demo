using Microsoft.EntityFrameworkCore;
using Web_1001_Fall_2022_Ef_Demo.Models;

namespace Web_1001_Fall_2022_Ef_Demo.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
            Blogs = Set<Blog>();
            Posts = Set<BlogPost>();
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogPost> Posts { get; set; }
    }
}
