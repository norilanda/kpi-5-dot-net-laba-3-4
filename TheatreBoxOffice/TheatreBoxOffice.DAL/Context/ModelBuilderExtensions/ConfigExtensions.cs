using Microsoft.EntityFrameworkCore;
using TheatreBoxOffice.DAL.Context.EntityConfiguration;

namespace TheatreBoxOffice.DAL.Context.ModelBuilderExtensions;

internal static class ConfigExtensions
{
    public static void Configure(this ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AuthorConfig).Assembly);
    }
}
