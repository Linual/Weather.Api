using System.ComponentModel.DataAnnotations;

namespace Weather.Api.Models
{
    public class Clouds
    {
        [Key]
        public int CloudsId { get; set; }
        public int id { get; set; }
        public int all { get; set; }
    }
}