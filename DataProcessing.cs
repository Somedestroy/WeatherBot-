using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace WeatherRequest
{
    public class DataProcessing
    {
        public static ObservableCollection<BasicCityInfo> ReadCitiesData(string citiesJson)
        {
            return JsonConvert.DeserializeObject<ObservableCollection<BasicCityInfo>>(citiesJson);
        }
        public static BasicCityInfo FindIndexOfCity(ObservableCollection<BasicCityInfo> cities, int index)
        {
            return cities[index];
        }
        public static int GetLocationKey(BasicCityInfo city)
        {
            return int.Parse(city.Key);
        }
        public static OutputWeather ReadWeatherData(string weatherJson)
        {
            return JsonConvert.DeserializeObject<OutputWeather>(weatherJson);
        }
    }
}