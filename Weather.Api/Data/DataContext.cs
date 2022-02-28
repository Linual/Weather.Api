using Microsoft.EntityFrameworkCore;
using Weather.Api.Models;

namespace Weather.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<WeatherModel> Weather { get; set; }
        public DbSet<Coord> Coord { get; set; }
    }
}
