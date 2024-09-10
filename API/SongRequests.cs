using TunaPiano.Models;
using Microsoft.EntityFrameworkCore;

namespace TunaPiano.API
{
    public class SongRequests
    {
        public static void Map(WebApplication app)
        {

            //Create Song
            app.MapPost("/songs", (TunaPianoDbContext db, Song song) =>
            {
            db.Songs.Add(song);
            db.SaveChanges();
            return Results.Created($"/songs{song.SongId}", song);
            });

            //Delete Song
            app.MapDelete("/songs/{songId}", (TunaPianoDbContext db, int songId) =>
            {
                Song songToDelete = db.Songs.SingleOrDefault(s => s.SongId == songId);
                if(songToDelete == null)
{
                    return Results.NotFound();
                }
                db.Songs.Remove(songToDelete);
                db.SaveChanges();
                return Results.Ok(db.Songs);
            });


            //Update Song
            app.MapPut("/songs/{songId}", (TunaPianoDbContext db, int SongId, Song song) =>
            {
                Song songToUpdate = db.Songs.SingleOrDefault(song => song.SongId == SongId);
                if (songToUpdate == null)
                {
                    return Results.NotFound();
                }
                songToUpdate.Title = song.Title;
                songToUpdate.ArtistId = song.ArtistId;
                songToUpdate.Album = song.Album;
                songToUpdate.Length = song.Length;


                db.SaveChanges();
                return Results.NoContent();
            });

            //View Songs
            app.MapGet("/songs", (TunaPianoDbContext db) =>
            {
                return db.Songs.ToList();
            });


            //Song Details
            app.MapGet("/songs/{songId}", (TunaPianoDbContext db, int songId) =>
            {
                var song = db.Songs
                .Include(s => s.Genres)

                .Include(s => s.Artist)

                .SingleOrDefault(s => s.SongId == songId);

                if (song == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(song);

            });

        }
    }
}
