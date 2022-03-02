using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Weather.Api.Models;

namespace Weather.Api.Dtos.WeatherInfo
{
    public class GetWeatherDto
    {
        public GetCoordDto Coord { get; set; }
        public ICollection<GetWeathersDto> Weather { get; set; }
        public string Base { get; set; }
        public GetMainDto Main { get; set; }
        public int Visibility { get; set; }
        public GetWindDto Wind { get; set; }
        public GetCloudsDto Clouds { get; set; }
        public int Dt { get; set; }
        public GetSysDto Sys { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
        public DateTime Date { get; set; }
    }
}
