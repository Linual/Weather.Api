using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Weather.Api.Models;
using Newtonsoft.Json;
using System.Net;

namespace Weather.Api.Controllers
{
    using System.Linq;
    [ApiController]
    [Route("[controller]")]
    public class WeatherInfoController : ControllerBase
    {
        private static List<WeatherModel> weather = new List<WeatherModel>();
        
        [HttpGet("{city}")]
        public IActionResult GetCurrectWeather(string city)
        {
            string APIKey = "3c377bc6d28c8e7452d1c7c416b23f82";
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city, APIKey);
                var json = web.DownloadString(url);
                WeatherModel info = JsonConvert.DeserializeObject<WeatherModel>(json);
                return Ok(info);
            }
        }

        [HttpPost]
        public IActionResult AddCurrentWeather(WeatherModel newWeather)
        {
            //newWeather.Date = DateTime.UtcNow.Date;
            weather.Add(newWeather);
            return Ok(weather);
        }

        [HttpGet("GetWeatherPerMonth/{city}")]
        public IActionResult GetWeatherPerMonth(string city)
        {
            return Ok(weather.Where(w => w.Date <= DateTime.Now.AddDays(-7) && w.Name == city));
        }
    }
}
