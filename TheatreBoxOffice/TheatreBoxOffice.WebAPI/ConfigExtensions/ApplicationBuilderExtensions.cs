using Microsoft.EntityFrameworkCore;
using TheatreBoxOffice.DAL.Context;

namespace TheatreBoxOffice.WebAPI.ConfigExtensions;

public static class ApplicationBuilderExtensions
{
    public static void InitializeDatabase(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
        using var dbContext = scope?.ServiceProvider.GetRequiredService<TheatreBoxOfficeContext>();
        dbContext?.Database.Migrate();
    }
}
