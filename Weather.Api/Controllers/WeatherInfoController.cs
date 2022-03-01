using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Weather.Api.Models;
using Newtonsoft.Json;
using System.Net;
using System.Linq;
using Weather.Api.Dtos.WeatherInfo;
using Weather.Api.Services;

namespace Weather.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WeatherInfoController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherInfoController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }
        
        [HttpGet("{city}")]
        public async Task<IActionResult> GetCurrectWeather(string city)
        {
            return Ok(await _weatherService.GetCurrectWeather(city));
        }

        [HttpPost]
        public async Task<IActionResult> AddCurrentWeather(AddWeatherDto newWeather)
        {
            return Ok(await _weatherService.AddCurrentWeather(newWeather));
        }

        [HttpGet("GetWeatherPerMonth/{city}")]
        public async Task<IActionResult> GetWeatherPerMonth(string city)
        {
            return Ok(await _weatherService.GetWeatherPerMonth(city));
        }

        [HttpGet("GetWeatherPerWeek/{city}")]
        public async Task<IActionResult> GetWeatherPerWeek(string city)
        {
            return Ok(await _weatherService.GetWeatherPerWeek(city));
        }

        [HttpGet("GetWeatherPerDay/{city}")]
        public async Task<IActionResult> GetWeatherPerDay(string city)
        {
            return Ok(await _weatherService.GetWeatherPerDay(city));
        }
    }
}
