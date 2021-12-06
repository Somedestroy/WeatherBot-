using System.Collections.Generic;

namespace WeatherRequest
{
    public class OutputWeather
    {
        public Headline Headline { get; set; } 
        public List<DailyForecast> DailyForecasts { get; set; } 
    }
}