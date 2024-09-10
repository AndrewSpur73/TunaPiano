using TunaPiano.Models;

namespace TunaPiano.Data
{
    public class SongData
    {
        public static List<Song> Songs = new()
        {
            new() { SongId = 1, Title = "Rock Song", ArtistId = 1, Album = "Rock Album", Length = 3 },
            new() { SongId = 2, Title = "Pop Song", ArtistId = 2, Album = "Pop Album", Length = 4 },
            new() { SongId = 3, Title = "Rap Song", ArtistId = 3, Album = "Rap Album", Length = 5 },
            new() { SongId = 4, Title = "Country Song", ArtistId = 1, Album = "Country Album", Length = 3 },
            new() { SongId = 5, Title = "Rap Song 2", ArtistId = 3, Album = "Derek's Rap Party", Length = 5 },
        };
    }
}