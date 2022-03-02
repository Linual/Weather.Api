using AutoMapper;
using Weather.Api.Dtos.WeatherInfo;
using Weather.Api.Models;
using System.Linq;

namespace Weather.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<WeatherModel, GetWeatherDto>()
                .ForMember(item => item.Coord, exp => exp.MapFrom(item => item.Coord))
                .ForMember(item => item.Weather, exp => exp.MapFrom(item => item.Weather))
                .ForMember(item => item.Main, exp => exp.MapFrom(item => item.Main))
                .ForMember(item => item.Wind, exp => exp.MapFrom(item => item.Wind))
                .ForMember(item => item.Clouds, exp => exp.MapFrom(item => item.Clouds))
                .ForMember(item => item.Sys, exp => exp.MapFrom(item => item.Sys));

            CreateMap<AddWeatherDto, WeatherModel>();

            CreateMap<Coord, GetCoordDto>();

            CreateMap<Clouds, GetCloudsDto>();

            CreateMap<Main, GetMainDto>();

            CreateMap<Sys, GetSysDto>();

            CreateMap<Wind, GetWindDto>();

            CreateMap<Weathers, GetWeathersDto>();
        }
    }
}
