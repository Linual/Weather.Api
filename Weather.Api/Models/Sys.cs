using System.ComponentModel.DataAnnotations;

namespace Weather.Api.Models
{
    public class Sys
    {
        [Key]
        public int SysId { get; set; }
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }
}