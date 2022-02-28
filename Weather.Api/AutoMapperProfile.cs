using AutoMapper;
using Weather.Api.Dtos.WeatherInfo;
using Weather.Api.Models;

namespace Weather.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<WeatherModel, GetWeatherDto>();
            CreateMap<AddWeatherDto, WeatherModel>();
        }
    }
}
