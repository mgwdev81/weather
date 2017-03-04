using System;

namespace WeatherData.Models.Rainfall
{
    public class RainfallSensorReading
    {
        public int RainfallSensorReadingId { get; set; }
        public DateTime ReadingTime { get; set; }
        public int Amount { get; set; }

        public int RainfallSensorLocationId { get; set; }
        public virtual RainfallSensorLocation RainfallSensorLocation { get; set; }
    }
}
