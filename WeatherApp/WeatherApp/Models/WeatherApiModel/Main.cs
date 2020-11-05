using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models.WeatherApiModel
{
    public class Main
    {
        public double Temp { get; set; }
        public double Feels_Like { get; set; }
        public double Temp_Min { get; set; }
        public double Temp_Max { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
    }
}
