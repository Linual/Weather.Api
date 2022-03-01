using Microsoft.EntityFrameworkCore;
using Weather.Api.Models;

namespace Weather.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            //mb.Entity<WeatherModel>()
            //    .HasOne(b => b.Coord)
            //    .WithMany()
             //   .HasForeignKey(c => c.CoordId);

            //mb.Entity<Coord>()
            //    .HasKey(b => b.CoordId);

            base.OnModelCreating(mb);
        }

        public DbSet<WeatherModel> Weather { get; set; }
        public DbSet<Coord> Coord { get; set; }
    }
}
