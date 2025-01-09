using System.ComponentModel.DataAnnotations;

namespace MovieRatingApp.DTOs
{
    public class MovieDto
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
    }
}
