using Microsoft.EntityFrameworkCore;

namespace ParksLookupApi.Models
{
  public class ParksLookupApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }
    public ParksLookupApiContext(DbContextOptions<ParksLookupApiContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Crater Lake National Park", Type = "National", Location = "Oregon" },
          new Park { ParkId = 2, Name = "Champoeg State Park", Type = "State", Location = "Oregon" },
          new Park { ParkId = 3, Name = "Zion National Park", Type = "National", Location = "Utah" },
          new Park { ParkId = 4, Name = "Arches National Park", Type = "National", Location = "Utah" },
          new Park { ParkId = 5, Name = "Yosemite National Park", Type = "National", Location = "California" }
        );
    }
  }
}