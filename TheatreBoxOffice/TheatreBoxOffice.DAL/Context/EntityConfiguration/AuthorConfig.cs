using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.DAL.Context.EntityConfiguration;

internal class AuthorConfig : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.Property(a => a.FirstName)
            .HasMaxLength(50);

        builder.Property(a => a.LastName)
            .HasMaxLength(50);
    }
}
