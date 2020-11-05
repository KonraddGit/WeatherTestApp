using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;
using WeatherApp.GetWeather;
using WeatherApp.Models;
using WeatherApp.Models.ForecastApiModel;
using WeatherApp.Models.WeatherApiModel;
using WeatherApp.Models.WeatherApplicationModel;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static string WEATHER_API_ID = "4330022d14c558f535c62753c8d5884c";
        public string api = "";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult TodayWeather(ApplicationWeather model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home", new { city = model.CityName , value = 1 });
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult TomorrowWeather(ApplicationWeather model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home", new { city = model.CityName, value = 2 });
            }
            return View(model);
        }

        public IActionResult Index(string city, int value)
        {
            var viewModel = new ApplicationWeather();

            if (value == 1)
            {
                var weatherResponse = GetNow.GetWeather(city, 1);

                if (weatherResponse != null)
                {
                    viewModel.CityName = weatherResponse.Name;
                    viewModel.Temp = weatherResponse.Main.Temp;
                    viewModel.Weather = weatherResponse.Weather[0].Main;
                    viewModel.Description = weatherResponse.Weather[0].Description;
                }
                return View(viewModel);
            }

            else if (value == 2)
            {
                var weatherResponse = GetTomorrow.GetWeather(city, 2);

                if (weatherResponse != null)
                {
                    viewModel.CityName = weatherResponse.city.name;
                    viewModel.Temp = weatherResponse.list[6].main.temp;
                    viewModel.Weather = weatherResponse.list[6].weather[0].main;
                    viewModel.Description = weatherResponse.list[6].weather[0].description;
                }
                return View(viewModel);
            }

            return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
