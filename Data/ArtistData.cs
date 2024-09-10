using TunaPiano.Models;

namespace TunaPiano.Data
{
    public class ArtistData
    {
        public static List<Artist> Artists = new()
        {
            new() { ArtistId = 1, Name = "Andrew", Age = 20, Bio = "Andrew's Bio" },
            new() { ArtistId = 2, Name = "Taylor", Age = 25, Bio = "Taylor's Bio" },
            new() { ArtistId = 3, Name = "Derek", Age = 30, Bio = "Derek's Bio" },
            new() { ArtistId = 4, Name = "Ross", Age = 35, Bio = "Ross's Bio" },
        };
    }
}
