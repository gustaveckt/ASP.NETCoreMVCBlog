using System.ComponentModel.DataAnnotations;

namespace Blog.Models.Dtos.Categories
{
    public class CategoryUpdateDto : BaseDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        public string? Icon { get; set; }
        public string? Slug { get; set; }

        [StringLength(250)]
        public string? Description { get; set; }
    }
}