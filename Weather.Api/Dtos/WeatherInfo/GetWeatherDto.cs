using System;
using System.Collections.Generic;
using Weather.Api.Models;

namespace Weather.Api.Dtos.WeatherInfo
{
    public class GetWeatherDto
    {
        public int idWeather { get; set; }
        public virtual Coord Coord { get; set; }
        public virtual ICollection<Weathers> Weather { get; set; }
        public string Base { get; set; }
        public virtual Main Main { get; set; }
        public int Visibility { get; set; }
        public virtual Wind Wind { get; set; }
        public virtual Clouds Clouds { get; set; }
        public int Dt { get; set; }
        public virtual Sys Sys { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
        public DateTime Date { get; set; }
    }
}
