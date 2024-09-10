using TunaPiano.Models;

namespace TunaPiano.Data
{
    public class GenreData
    {
        public static List<Genre> Genres = new()
        {
            new() { GenreId = 1, Description = "Rock" },
            new() { GenreId = 2, Description = "Rap" },
            new() { GenreId = 3, Description = "Country" },
            new() { GenreId = 4, Description = "Pop" },
        };
    }
}