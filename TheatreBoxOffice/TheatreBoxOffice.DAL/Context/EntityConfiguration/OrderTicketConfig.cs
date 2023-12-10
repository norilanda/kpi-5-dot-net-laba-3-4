using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.DAL.Context.EntityConfiguration;

internal class OrderTicketConfig : IEntityTypeConfiguration<OrderTicket>
{
    public void Configure(EntityTypeBuilder<OrderTicket> builder)
    {
        builder.HasKey(e => new { e.OrderId, e.SeatId, e.TicketPriceTypeId});
    }
}
