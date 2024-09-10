using Microsoft.EntityFrameworkCore;
using TunaPiano.Models;
using TunaPiano.Data;

public class TunaPianoDbContext : DbContext
{

    public DbSet<Artist> Artists { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Song> Songs { get; set; }

    public TunaPianoDbContext(DbContextOptions<TunaPianoDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Artist>().HasData(ArtistData.Artists);
        modelBuilder.Entity<Genre>().HasData(GenreData.Genres);
        modelBuilder.Entity<Song>().HasData(SongData.Songs);

        modelBuilder.Entity<Song>()
            .HasMany(song => song.Genres)
            .WithMany(genre => genre.Songs)
            .UsingEntity(songGenre => songGenre.ToTable("SongGenre").HasData(
                    new { SongsSongId = 1, GenresGenreId = 1 },
                    new { SongsSongId = 2, GenresGenreId = 4 },
                    new { SongsSongId = 3, GenresGenreId = 2 },
                    new { SongsSongId = 4, GenresGenreId = 3 },
                    new { SongsSongId = 5, GenresGenreId = 2 }
                    ));
    }
}

