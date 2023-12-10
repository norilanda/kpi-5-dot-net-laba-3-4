using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.DAL.Context.EntityConfiguration;

internal class OrderConfig : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        var precision = 8;

        builder.Property(t => t.Price)
            .HasColumnType($"decimal({precision},2)");
    }
}
