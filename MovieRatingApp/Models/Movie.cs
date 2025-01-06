using System.ComponentModel.DataAnnotations;

namespace MovieRatingApp.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public int ReleaseYear { get; set; }

        // Navigation Properties
        public ICollection<Review> Reviews { get; set; }
        public ICollection<MovieCategory> MovieCategories { get; set; }
    }
}
