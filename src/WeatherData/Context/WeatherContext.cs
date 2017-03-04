using System.Data.Entity;
using WeatherData.Models.Rainfall;

namespace WeatherData.Context
{
    public class WeatherContext : DbContext
    {
        public DbSet<RainfallSensor> RainfallSensors { get; set; }
        public DbSet<RainfallSensorLocation> RainfallSensorLocations { get; set; }
        public DbSet<RainfallSensorReading> RainfallSensorReadings { get; set; }
    }
}
