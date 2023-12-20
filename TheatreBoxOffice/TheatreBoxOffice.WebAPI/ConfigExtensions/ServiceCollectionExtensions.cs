using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using TheatreBoxOffice.BLL.Interfaces;
using TheatreBoxOffice.BLL.Services;
using TheatreBoxOffice.Common.Options;
using TheatreBoxOffice.DAL.Context;
using TheatreBoxOffice.DAL.Interfaces;
using TheatreBoxOffice.DAL.Repositories;

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

        services
            .AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<TheatreBoxOfficeContext>()
            .AddDefaultTokenProviders();
    }

    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IGenericRepository<>), typeof(EfRepository<>));

        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IPerformanceService, PerformanceService>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<ITicketService, TicketService>();
    }

    public static void AddJwtTokenAuth(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<JwtOptions>(
            new JwtOptions
            {
                Issuer = configuration["Jwt:Issuer"] ?? throw new ArgumentNullException(),
                Audience = configuration["Jwt:Audience"] ?? throw new ArgumentNullException(),
                SecretKey = configuration["Jwt:SecretKey"] ?? throw new ArgumentNullException(),
                Lifetime = 30,
                SecurityAlgorithm = SecurityAlgorithms.HmacSha256
            });

        var signingKey = JwtOptions.GetSymmetricSecurityKey(configuration["Jwt:SecretKey"]!);

        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = configuration["Jwt:Issuer"],

            ValidateAudience = true,
            ValidAudience = configuration["Jwt:Audience"] ,

            ValidateIssuerSigningKey = true,
            IssuerSigningKey = signingKey,

            ValidateLifetime = true
        };

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = tokenValidationParameters;
        });
    }

}
