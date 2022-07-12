using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Bee Movie",
                        ReleaseDate = DateTime.Parse("05-10-2005"),
                        Genre = "Comédia",
                        Price = 71M,
                        Rating = "Livre"
                    },

                    new Movie
                    {
                        Title = "El Dourado",
                        ReleaseDate = DateTime.Parse("10-05-2002"),
                        Genre = "Aventura",
                        Price = 40M,
                        Rating = "Livre"
                    },

                    new Movie
                    {
                        Title = "Liga da Justiça",
                        ReleaseDate = DateTime.Parse("16-05-2004"),
                        Genre = "Heróis",
                        Price = 59M,
                        Rating = "14 anos"
                    },

                    new Movie
                    {
                        Title = "Norbit",
                        ReleaseDate = DateTime.Parse("14-07-2008"),
                        Genre = "Comédia",
                        Price = 92M,
                        Rating = "14 anos"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
