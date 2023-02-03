using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Blog.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Answers = new HashSet<Answer>();
            Comments = new HashSet<Comment>();
            Posts = new HashSet<Post>();
        }

        [Display(Name = "Prenom")]
        public string? FirstName { get; set; }
        [Display(Name = "Nom de famille")]
        public string? LastName { get; set; } = null!;
        [Display(Name = "Pseudonyme")]
        public string Pseudonym { get; set; } = null!;
        [Display(Name = "Photo de profile")]
        public string? ProfilePhoto { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
