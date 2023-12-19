using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.DAL.Context.EntityConfiguration;

internal class TicketPriceTypeConfig : IEntityTypeConfiguration<TicketPriceType>
{
    public void Configure(EntityTypeBuilder<TicketPriceType> builder)
    {
        var precision = 7;

        builder.Property(t => t.Price)
            .HasColumnType($"decimal({precision},2)");
    }
}
