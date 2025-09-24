using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;
namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "PG",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Live and Let Die (James Bond)",
                    ReleaseDate = DateTime.Parse("1973-1-1"),
                    Genre = "Action Thriller",
                    Rating = "PG-13",
                    Price = 5.99M
                },
                new Movie
                {
                    Title = "Tomorrow Never Dies (James Bond)",
                    ReleaseDate = DateTime.Parse("1997-9-12"),
                    Genre = "Action Thriller",
                    Rating = "PG-13",
                    Price = 5.99M
                },
                new Movie
                {
                    Title = "How to Train Your Dragon",
                    ReleaseDate = DateTime.Parse("2010-3-26"),
                    Genre = "Animation",
                    Rating = "PG",
                    Price = 6.99M
                }
            );
            context.SaveChanges();
        }
    }
}
