using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string? Image { get; set; }
        public string? YoutubeVideoUrl { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
        public bool? IsPublished { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        [ForeignKey("AuthorId")]
        public string AuthorId { get; set; } = null!;
        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ApplicationUser Author { get; set; } = null!;
    }
}
