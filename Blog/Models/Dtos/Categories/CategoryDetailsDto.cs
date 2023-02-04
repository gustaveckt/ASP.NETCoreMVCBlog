namespace Blog.Models.Dtos.Categories
{
    public class CategoryDetailsDto : CategoryReadDto
    {
        public string Slug { get; set; } = null!;
    }
}