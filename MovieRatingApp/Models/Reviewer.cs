using System.ComponentModel.DataAnnotations;

namespace MovieRatingApp.Models
{
    public class Reviewer
    {
        [Key]
        public int ReviewerID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Navigation Properties
        public ICollection<Review> Reviews { get; set; }
    }
}