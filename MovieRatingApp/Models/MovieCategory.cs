using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieRatingApp.Models
{
    public class MovieCategory
    {
        [Required]
        public int MovieID { get; set; }

        [Required]
        public int CategoryID { get; set; }

        // Navigation Properties
        [ForeignKey("MovieID")]
        public Movie Movie { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
    }
}