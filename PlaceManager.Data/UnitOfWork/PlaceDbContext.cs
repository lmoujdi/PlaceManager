using Microsoft.EntityFrameworkCore;
using PlaceManager.Data.Models;

namespace PlaceManager.Data
{
    public class PlaceDbContext : DbContext
    {
        public PlaceDbContext(DbContextOptions<PlaceDbContext> options) : base(options)
        {        }

        public DbSet<Place> Places { get; set; }
        public DbSet<OpeningHour> OpeningHours { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Place>().ToTable("Place");
            modelBuilder.Entity<OpeningHour>().ToTable("OpeningHour");
        }
    }
}