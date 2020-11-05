using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models.WeatherApplicationModel
{
    public class ApplicationWeather
    {
        [Display(Name = "City:")]
        public string Name { get; set; }

        [Display(Name = "Temperature:")]
        public double Temp { get; set; }

        [Display(Name = "Weather Condition:")]
        public string Weather { get; set; }

        [Display(Name = "City Name")]
        public string CityName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
