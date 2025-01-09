using System.ComponentModel.DataAnnotations;

namespace MovieRatingApp.DTOs
{
    public class ReviewDto
    {
        public int ReviewID { get; set; }
        public int MovieID { get; set; }
        public int ReviewerID { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
