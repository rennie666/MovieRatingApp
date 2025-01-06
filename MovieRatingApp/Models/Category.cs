using System.ComponentModel.DataAnnotations;

namespace MovieRatingApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        // Navigation Properties
        public ICollection<MovieCategory> MovieCategories { get; set; }
    }
}
