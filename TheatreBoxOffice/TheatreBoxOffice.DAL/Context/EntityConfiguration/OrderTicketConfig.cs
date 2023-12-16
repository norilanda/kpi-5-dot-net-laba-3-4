using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.DAL.Context.EntityConfiguration;

internal class OrderTicketConfig : IEntityTypeConfiguration<OrderTicket>
{
    public void Configure(EntityTypeBuilder<OrderTicket> builder)
    {
        builder.HasKey(e => new { e.OrderId, e.SeatId, e.TicketPriceTypeId});

        builder.HasOne(e => e.Seat)
            .WithMany(e => e.OrderTickets)
            .HasForeignKey(e => e.SeatId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.Order)
            .WithMany(e => e.OrderTickets)
            .HasForeignKey(e => e.OrderId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.TicketPriceType)
            .WithMany(e => e.OrderTickets)
            .HasForeignKey(e => e.TicketPriceTypeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
