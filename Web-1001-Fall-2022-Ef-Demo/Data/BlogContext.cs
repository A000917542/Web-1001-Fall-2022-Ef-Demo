using Microsoft.EntityFrameworkCore;
using Web_1001_Fall_2022_Ef_Demo.Models;

namespace Web_1001_Fall_2022_Ef_Demo.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {}

        public DbSet<Blog> Blogs => Set<Blog>();
        public DbSet<BlogPost> Posts => Set<BlogPost>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Blog>()
                .HasMany(b => b.Posts)
                .WithOne(p => p.Blog)
                .HasConstraintName("FK_BlogsToPosts");

            builder.Entity<BlogPost>().ToTable("abcdef");

            builder.Entity<BlogPost>().HasIndex(p => new { p.URL, p.Title }).HasDatabaseName("IX_BlogPost_Url_Title");
        }
    }
}
