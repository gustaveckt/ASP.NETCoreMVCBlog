using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public partial class Answer
    {
        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public int CommentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? IsValid { get; set; }
        public string ApplicationUserId { get; set; } = null!;
        public virtual Comment Comment { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;
    }
}
