using System.Collections.Generic;

namespace WeatherApp.Models.WeatherApiModel
{
   
    public class WeatherResponse
    {
        public Clouds Clouds { get; set; }
        public Coord Coord { get; set; }
        public Main Main { get; set; }
        public Sys Sys { get; set; }
        public List<Weather> Weather { get; set; }
        public Wind Wind { get; set; }
        public string Base { get; set; }
        public int Visibility { get; set; }
        public int Dt { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
    }
}
