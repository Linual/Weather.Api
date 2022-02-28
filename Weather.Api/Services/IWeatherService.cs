using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weather.Api.Dtos.WeatherInfo;
using Weather.Api.Models;

namespace Weather.Api.Services
{
    public interface IWeatherService
    {
        Task<ServiceResponse<GetWeatherDto>> GetCurrectWeather(string city);
        Task<ServiceResponse<List<GetWeatherDto>>> AddCurrentWeather(AddWeatherDto newWeather);
        Task<ServiceResponse<List<GetWeatherDto>>> GetWeatherPerDay(string city);
        Task<ServiceResponse<List<GetWeatherDto>>> GetWeatherPerWeek(string city);
        Task<ServiceResponse<List<GetWeatherDto>>> GetWeatherPerMonth(string city);
    }
}
