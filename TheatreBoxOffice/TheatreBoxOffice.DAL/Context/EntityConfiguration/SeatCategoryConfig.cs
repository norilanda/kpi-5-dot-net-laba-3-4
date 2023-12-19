using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.DAL.Context.EntityConfiguration;

internal class SeatCategoryConfig
{
    public void Configure(EntityTypeBuilder<SeatCategory> builder)
    {
        builder.HasMany(s => s.Seats)
            .WithOne(s => s.SeatCategory)
            .HasForeignKey(s => s.SeatCategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.TicketPriceTypes)
            .WithOne(s => s.SeatCategory)
            .HasForeignKey(s => s.SeatCategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
