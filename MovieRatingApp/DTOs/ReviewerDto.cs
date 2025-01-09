using System.ComponentModel.DataAnnotations;

namespace MovieRatingApp.DTOs
{
    public class ReviewerDto
    {
        public int ReviewerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
