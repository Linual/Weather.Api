namespace Weather.Api.Models
{
    public class Sys
    {
        public int type { get; set; } = 16;
        public int id { get; set; } = 1;
        public string country { get; set; } = "RU";
        public int sunrise { get; set; } = 61;
        public int sunset { get; set; } = 21;
    }
}