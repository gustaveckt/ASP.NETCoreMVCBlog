using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public partial class Category
    {
        public Category()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string? Icon { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
