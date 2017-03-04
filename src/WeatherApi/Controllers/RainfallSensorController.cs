using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeatherApi.Models;
using DataModels = WeatherData.Models.Rainfall;
using WeatherData.Context;
using AutoMapper;

namespace WeatherApi.Controllers
{
    public class RainfallSensorController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage AddSensor(RainfallSensor rainfallSensor)
        {
            var rainfallSensorMapped = Mapper.Map<RainfallSensor, DataModels.RainfallSensor>(rainfallSensor);

            using (var db = new WeatherContext())
            {
                db.RainfallSensors.Add(rainfallSensorMapped);
                db.SaveChanges();
            }
            
            return Request.CreateResponse(HttpStatusCode.Created, "Sensor was added.");
        }

        [HttpGet]
        public HttpResponseMessage GetSensors()
        {
            List<DataModels.RainfallSensor> sensors;

            using (var db = new WeatherContext())
            {
                sensors = db.RainfallSensors.Select(x => x).ToList();
            }

            List<RainfallSensor> sensorsMapped = sensors.Select(x => Mapper.Map<DataModels.RainfallSensor, RainfallSensor>(x)).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, sensorsMapped);
        }
    }
}
