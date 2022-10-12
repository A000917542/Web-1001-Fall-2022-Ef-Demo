namespace Web_1001_Fall_2022_Ef_Demo.Models
{
    public class BlogPost
    {
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Content { get; set; } = String.Empty;
        public Uri? URL { get; set; }
        public Blog? Blog { get; set; }
    }
}
