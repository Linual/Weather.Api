using System.ComponentModel.DataAnnotations;

namespace Weather.Api.Models
{
    public class Main
    {
        [Key]
        public int MainId { get; set; }
        public int id { get; set; }
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public int sea_level { get; set; }
        public int grnd_level { get; set; }
    }
}