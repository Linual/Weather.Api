using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weather.Api.Models;

namespace Weather.Api.Services
{
    public interface IWeatherService
    {
        WeatherModel GetCurrectWeather();
        List<WeatherModel> AddCurrentWeather(WeatherModel newWeather);
        List<WeatherModel> GetWeatherPerDay();
        List<WeatherModel> GetWeatherPerWeek();
        List<WeatherModel> GetWeatherPerMonth();
    }
}
