using Microsoft.EntityFrameworkCore;
using Weather.Api.Models;

namespace Weather.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder mb) { }

        public DbSet<WeatherModel> Weather { get; set; }
        public DbSet<Coord> Coord { get; set; }
        public DbSet<Clouds> Clouds { get; set; }
        public DbSet<Main> Main { get; set; }
        public DbSet<Sys> Sys { get; set; }
        public DbSet<Wind> Wind { get; set; }
        public DbSet<Weathers> Weathers { get; set; }
    }
}
