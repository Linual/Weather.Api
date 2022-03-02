using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Weather.Api.Dtos.WeatherInfo
{
    public class GetCoordDto
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }
}
