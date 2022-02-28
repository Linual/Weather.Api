using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Weather.Api.Data;
using Weather.Api.Dtos.WeatherInfo;
using Weather.Api.Models;

namespace Weather.Api.Services
{
    public class WeatherService : IWeatherService
    {
        private static List<WeatherModel> weathers = new List<WeatherModel>()
        {
            new WeatherModel()
        };
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public WeatherService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<GetWeatherDto>> GetCurrectWeather(string city)
        {
            ServiceResponse<GetWeatherDto> serviceResponse = new ServiceResponse<GetWeatherDto>();
            string APIKey = "3c377bc6d28c8e7452d1c7c416b23f82";
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city, APIKey);
                var json = web.DownloadString(url);
                GetWeatherDto info = JsonConvert.DeserializeObject<GetWeatherDto>(json);
                info.Date = DateTime.Now.Date;

                serviceResponse.Data = info;
                return serviceResponse;
            }
        }

        public async Task<ServiceResponse<List<GetWeatherDto>>> GetWeatherPerDay(string city)
        {
            ServiceResponse<List<GetWeatherDto>> serviceResponse = new ServiceResponse<List<GetWeatherDto>>();
            List<WeatherModel> dbWeather = await _context.Weather.ToListAsync();
            serviceResponse.Data = (dbWeather.Select(c => _mapper.Map<GetWeatherDto>(c))).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetWeatherDto>>> GetWeatherPerMonth(string city)
        {
            ServiceResponse<List<GetWeatherDto>> serviceResponse = new ServiceResponse<List<GetWeatherDto>>();
            serviceResponse.Data = (weathers.Select(c => _mapper.Map<GetWeatherDto>(c))).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetWeatherDto>>> GetWeatherPerWeek(string city)
        {
            ServiceResponse<List<GetWeatherDto>> serviceResponse = new ServiceResponse<List<GetWeatherDto>>();
            //weathers.Where(w => w.Date <= DateTime.Now.AddDays(-7));
            serviceResponse.Data = (weathers.Select(c => _mapper.Map<GetWeatherDto>(c))).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetWeatherDto>>> AddCurrentWeather(AddWeatherDto newWeather)
        {
            ServiceResponse<List<GetWeatherDto>> serviceResponse = new ServiceResponse<List<GetWeatherDto>>();
            WeatherModel currentWeather = _mapper.Map<WeatherModel>(newWeather);
            //currentWeather.idWeather = weathers.Max(c => c.idWeather) + 1;
            //currentWeather.Date = DateTime.UtcNow.Date;
            await _context.Weather.AddAsync(currentWeather);
            await _context.SaveChangesAsync();
            serviceResponse.Data = (_context.Weather.Select(c => _mapper.Map<GetWeatherDto>(c))).ToList();
            return serviceResponse;
        }
    }
}
