using Microsoft.EntityFrameworkCore;
using TheatreBoxOffice.DAL.Helpers;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.DAL.Context.ModelBuilderExtensions;

internal static class SeedExtensions
{
    public static void Seed (this ModelBuilder modelBuilder)
    {
        var authors = DataGeneratorHelper.GenerateAuthors().ToList();
        var genres = DataGeneratorHelper.GenerateGenres().ToList();
        var performances = DataGeneratorHelper.GeneratePerformances();
        var seats = DataGeneratorHelper.GenerateSeats();

        modelBuilder.Entity<Author>()
            .HasData(authors);

        modelBuilder.Entity<Genre>()
            .HasData(genres);

        modelBuilder.Entity<Performance>()
            .HasData(performances);

        modelBuilder.Entity<Seat>()
            .HasData(seats);
    }
}
