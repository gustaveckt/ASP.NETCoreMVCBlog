using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public partial class Category
    {
        public Category()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        [Display(Name = "Nom")]
        public string Name { get; set; } = null!;

        [Display(Name = "Slug")]
        public string Slug { get; set; } = null!;

        [Display(Name = "Icone")]
        public string? Icon { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
