using System.ComponentModel.DataAnnotations;

namespace Blog.Models.Dtos.Posts
{
    public class PostUpdateDto : BaseDto
    {
        [Required]
        [StringLength(250)]
        public string Title { get; set; } = null!;
        [Required]
        public int CategoryId { get; set; }
        public string? Content { get; set; } = null!;
        [StringLength(250)]
        public string? Description { get; set; } = null!;
        public string? YoutubeVideoUrl { get; set; } = null!;
        public IFormFile? Image { get; set; }
    }
}