using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public partial class Comment
    {
        public Comment()
        {
            Answers = new HashSet<Answer>();
        }

        public int Id { get; set; }
        public int PostId { get; set; }
        public string CreatedAt { get; set; } = null!;
        public string Content { get; set; } = null!;
        public bool? IsValid { get; set; }
        public string ApplicationUserId { get; set; } = null!;
        public virtual Post Post { get; set; } = null!;
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ApplicationUser User { get; set; } = null!;
    }
}
