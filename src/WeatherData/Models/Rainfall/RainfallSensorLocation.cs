namespace WeatherData.Models.Rainfall
{
    public class RainfallSensorLocation
    {
        public int RainfallSensorLocationId { get; set; }
        public string GeocodedLocation { get; set; }

        public int RainfallSensorId { get; set; }
        public virtual RainfallSensor RainfallSensor { get; set; }
    }
}
