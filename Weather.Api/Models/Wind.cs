using System.ComponentModel.DataAnnotations;

namespace Weather.Api.Models
{
    public class Wind
    {
        [Key]
        public int WindId { get; set; }
        public int id { get; set; }
        public double speed { get; set; }
        public int deg { get; set; }
        public double gust { get; set; }
    }
}