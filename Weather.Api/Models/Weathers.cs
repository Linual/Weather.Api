using System.ComponentModel.DataAnnotations;

namespace Weather.Api.Models
{
    public class Weathers
    {
        [Key]
        public int WeatherId { get; set; }
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
}