using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TheatreBoxOffice.DAL.Context;

namespace TheatreBoxOffice.WebAPI.ConfigExtensions;

public static class ServiceCollectionExtensions
{
    public static void AddTheatreBoxOfficeDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("TheatreBoxOfficeContext");

        services.AddDbContext<TheatreBoxOfficeContext>(options =>
            options.UseSqlServer(
                connectionString, 
                opt => opt.MigrationsAssembly(typeof(TheatreBoxOfficeContext).Assembly.GetName().Name))
            );

        services.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<TheatreBoxOfficeContext>()
            .AddDefaultTokenProviders();
    }

    public static void AddServices(this IServiceCollection services)
    {

    }
}
