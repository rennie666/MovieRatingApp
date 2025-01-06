using Microsoft.EntityFrameworkCore;
using MovieRatingApp.Models;
using System.Reflection.Emit;

namespace MovieRatingApp.Data
{
    public class Seed
    {
        private readonly ApplicationDbContext dataContext;
        public Seed(ApplicationDbContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            // Seed Categories

            new Category { CategoryID = 1, Name = "Action", Description = "High energy, lots of stunts" };
            new Category { CategoryID = 2, Name = "Comedy", Description = "Funny and lighthearted" };
            new Category { CategoryID = 3, Name = "Drama", Description = "Serious and emotional stories" };
            new Category { CategoryID = 4, Name = "Thriller", Description = "Mind-bending" };


            // Seed Movies
            new Movie { MovieID = 1, Title = "Inception", Description = "A mind-bending thriller", ReleaseYear = 2010 };
            new Movie { MovieID = 2, Title = "The Dark Knight", Description = "Batman battles Joker", ReleaseYear = 2008 };
            
        }
        
    }
}
