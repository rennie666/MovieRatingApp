using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieRatingApp.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        [Required]
        public int MovieID { get; set; }

        [Required]
        public int ReviewerID { get; set; }

        [Required]
        [MaxLength(500)]
        public string Content { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; }

        // Navigation Properties
        [ForeignKey("MovieID")]
        public Movie Movie { get; set; }

        [ForeignKey("ReviewerID")]
        public Reviewer Reviewer { get; set; }
    }
}