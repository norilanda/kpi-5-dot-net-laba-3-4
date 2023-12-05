using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TheatreBoxOffice.DAL.Context;

public class TheatreBoxOfficeContext : IdentityDbContext<IdentityUser>
{
    public TheatreBoxOfficeContext(DbContextOptions<TheatreBoxOfficeContext> options) : base(options)
    {
        
    }
}
