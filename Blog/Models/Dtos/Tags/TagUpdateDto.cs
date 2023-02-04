using System.ComponentModel.DataAnnotations;

namespace Blog.Models.Dtos.Tags
{
    public class TagUpdateDto : BaseDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        public string? Slug { get; set; }
    }
}