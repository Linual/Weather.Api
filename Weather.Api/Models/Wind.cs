namespace Weather.Api.Models
{
    public class Wind
    {
        public int id { get; set; }
        public double speed { get; set; }
        public int deg { get; set; }
        public double gust { get; set; }
    }
}