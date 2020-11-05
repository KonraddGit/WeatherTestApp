using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models.ForecastApiModel;

namespace WeatherApp.GetWeather
{
    public static class GetTomorrow
    {
        public static string WEATHER_API_ID = "4330022d14c558f535c62753c8d5884c";

        public static ForecastResponse GetWeather(string city, int value)
        {
            if (value == 2)
            {
                var api = $"http://api.openweathermap.org/data/2.5/forecast?q={city}&units=metric&appid={WEATHER_API_ID}&lang=pl&cnt=8";

                var client = new RestClient(api);
                var request = new RestRequest(Method.GET);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    var weatherResponse = JsonConvert.DeserializeObject<ForecastResponse>(response.Content);

                    return weatherResponse;
                }
            }
            
            return null;
        }
    }
}
