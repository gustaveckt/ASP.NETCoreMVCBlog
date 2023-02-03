namespace Blog.Models.Dtos.Posts
{
    public class PostReadDto : BaseDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string Image { get; set; } = null!;
    }
}