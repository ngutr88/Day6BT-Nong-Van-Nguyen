using Day6BT_Nong_Van_Nguyen.Models;
using Microsoft.EntityFrameworkCore;

namespace Day6BT_Nong_Van_Nguyen.Data;

public static class SeedData
{
    public static async Task InitializeAsync(IServiceProvider services)
    {
        var context = services.GetRequiredService<AppDbContext>();
        if (await context.Genres.AnyAsync() || await context.Movies.AnyAsync()) return;

        var comedy = new Genre { Name = "Comedy" };
        var action = new Genre { Name = "Action" };
        var animation = new Genre { Name = "Animation" };
        context.Genres.AddRange(comedy, action, animation);
        context.Movies.AddRange(
            new Movie { Title = "Ghostbusters", ReleaseDate = new DateTime(1984, 6, 8), Duration = 105, Genre = comedy },
            new Movie { Title = "The Avengers", ReleaseDate = new DateTime(2012, 5, 4), Duration = 143, Genre = action },
            new Movie { Title = "Toy Story", ReleaseDate = new DateTime(1995, 11, 22), Duration = 81, Genre = animation });
        await context.SaveChangesAsync();
    }
}
