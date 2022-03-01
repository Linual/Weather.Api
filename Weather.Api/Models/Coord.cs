using System.ComponentModel.DataAnnotations;

namespace Weather.Api.Models
{
    public class Coord
    {
        [Key]
        public int? CoordId { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
    }
}