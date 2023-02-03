using System.ComponentModel.DataAnnotations;

namespace Blog.Models.Dtos.Tags
{
    public class TagCreateDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
    }
}