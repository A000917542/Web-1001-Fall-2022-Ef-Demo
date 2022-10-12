using System.ComponentModel.DataAnnotations;

namespace Web_1001_Fall_2022_Ef_Demo.Models
{
    public class Blog
    {
        public string Title { get; set; } = String.Empty;

        [MaxLength(512)]
        public string? Description { get; set; }

        [EmailAddress]
        public string? PrimaryAuthor { get; set; }

        [Required]
        public Uri? URL { get; set; }

        public ICollection<BlogPost> Posts { get; set; } = new List<BlogPost>();
    }
}
