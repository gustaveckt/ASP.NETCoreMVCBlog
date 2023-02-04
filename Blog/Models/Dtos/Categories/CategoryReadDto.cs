namespace Blog.Models.Dtos.Categories
{
    public class CategoryReadDto : BaseDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Icon { get; set; } = null!;
    }
}