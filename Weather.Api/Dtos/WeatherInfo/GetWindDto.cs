using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather.Api.Dtos.WeatherInfo
{
    public class GetWindDto
    {
        public int id { get; set; }
        public double speed { get; set; }
        public int deg { get; set; }
        public double gust { get; set; }
    }
}
