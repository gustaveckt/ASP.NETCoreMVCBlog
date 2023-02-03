namespace Blog.Models.Dtos.Tags
{
    public class TagReadDto : BaseDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string Icon { get; set; } = null!;
    }
}