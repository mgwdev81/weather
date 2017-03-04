using AutoMapper;

namespace WeatherApi.Models
{
    public class AutoMapperInitializer
    {
        public static void InitAutoMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<RainfallSensor, WeatherData.Models.Rainfall.RainfallSensor>();
                cfg.CreateMap<WeatherData.Models.Rainfall.RainfallSensor, RainfallSensor>();
            });
        }
    }
}