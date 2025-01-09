using System.ComponentModel.DataAnnotations;

namespace MovieRatingApp.DTOs
{
    public class CategoryDto
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
