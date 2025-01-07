using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieRatingApp.Models;

namespace MovieRatingApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

           
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<MovieCategory>()
                .HasKey(mc => new { mc.MovieID, mc.CategoryID });

            
            modelBuilder.Entity<MovieCategory>()
                .HasOne(mc => mc.Movie)
                .WithMany(m => m.MovieCategories)
                .HasForeignKey(mc => mc.MovieID);

            modelBuilder.Entity<MovieCategory>()
                .HasOne(mc => mc.Category)
                .WithMany(c => c.MovieCategories)
                .HasForeignKey(mc => mc.CategoryID);

            base.OnModelCreating(modelBuilder);
            /*
            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Action", Description = "High energy, lots of stunts" },
                new Category { CategoryID = 2, Name = "Comedy", Description = "Funny and lighthearted" },
                new Category { CategoryID = 3, Name = "Drama", Description = "Serious and emotional stories" }
            );

            // Seed Movies
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieID = 1, Title = "Inception", Description = "A mind-bending thriller", ReleaseYear = 2010},
                new Movie { MovieID = 2, Title = "The Dark Knight", Description = "Batman battles Joker", ReleaseYear = 2008 }
            );
            */
        }




    }
}