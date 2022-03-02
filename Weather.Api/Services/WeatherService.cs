using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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

            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string APIKey = config["OpenWeatherMap:Token"];

            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city, APIKey);
                var json = web.DownloadString(url);
                GetWeatherDto info = JsonConvert.DeserializeObject<GetWeatherDto>(json);
                serviceResponse.Data = info;

                return serviceResponse;
            }
        }

        public async Task<ServiceResponse<List<GetWeatherDto>>> GetWeatherPerDay(string city)
        {
            ServiceResponse<List<GetWeatherDto>> serviceResponse = new ServiceResponse<List<GetWeatherDto>>();
            
            serviceResponse.Data = await _context.Weather
                                        .Include(x => x.Coord)
                                        .Include(x => x.Clouds)
                                        .Include(x => x.Main)
                                        .Include(x => x.Sys)
                                        .Include(x => x.Weather)
                                        .Include(x => x.Wind)
                                        .Where(c => c.Name == city && c.Date <= DateTime.Now.AddDays(-1))
                                        .Select(c => _mapper.Map<GetWeatherDto>(c))
                                        .ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetWeatherDto>>> GetWeatherPerMonth(string city)
        {
            ServiceResponse<List<GetWeatherDto>> serviceResponse = new ServiceResponse<List<GetWeatherDto>>();

            serviceResponse.Data = await _context.Weather
                                        .Include(x => x.Coord)
                                        .Include(x => x.Clouds)
                                        .Include(x => x.Main)
                                        .Include(x => x.Sys)
                                        .Include(x => x.Weather)
                                        .Include(x => x.Wind)
                                        .Where(c => c.Name == city && c.Date <= DateTime.Now.AddDays(-30))
                                        .Select(c => _mapper.Map<GetWeatherDto>(c))
                                        .ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetWeatherDto>>> GetWeatherPerWeek(string city)
        {
            ServiceResponse<List<GetWeatherDto>> serviceResponse = new ServiceResponse<List<GetWeatherDto>>();
            
            serviceResponse.Data = await _context.Weather
                                        .Include(x => x.Coord)
                                        .Include(x => x.Clouds)
                                        .Include(x => x.Main)
                                        .Include(x => x.Sys)
                                        .Include(x => x.Weather)
                                        .Include(x => x.Wind)
                                        .Where(c => c.Name == city && c.Date <= DateTime.Now.AddDays(-7))
                                        .Select(c => _mapper.Map<GetWeatherDto>(c))
                                        .ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetWeatherDto>>> AddCurrentWeather(AddWeatherDto newWeather)
        {
            ServiceResponse<List<GetWeatherDto>> serviceResponse = new ServiceResponse<List<GetWeatherDto>>();
            WeatherModel currentWeather = _mapper.Map<WeatherModel>(newWeather);
            currentWeather.Date = DateTime.Now;
            await _context.Weather.AddAsync(currentWeather);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.Weather
                                        .Select(c => _mapper
                                        .Map<GetWeatherDto>(c))
                                        .ToListAsync();
            return serviceResponse;
        }
    }
}
