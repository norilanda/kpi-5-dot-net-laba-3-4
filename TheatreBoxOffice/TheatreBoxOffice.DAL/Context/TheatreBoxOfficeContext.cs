using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheatreBoxOffice.DAL.Context.ModelBuilderExtensions;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.DAL.Context;

public class TheatreBoxOfficeContext : IdentityDbContext<IdentityUser>
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderTicket> OrderTickets { get; set; }
    public DbSet<Performance> Performances { get; set; }
    public DbSet<Seat> Seats { get; set; }
    public DbSet<Order> ticketPriceTypes { get; set; }

    public TheatreBoxOfficeContext(DbContextOptions<TheatreBoxOfficeContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Configure();
        modelBuilder.Seed();
    }
}
