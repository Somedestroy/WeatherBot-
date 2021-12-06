using System.IO;
using System.Net;
using static System.Console;
using System.Configuration;
using System;

namespace WeatherRequest
{
    public class SearchingData
    {

		public static string ApiKey {get; set;}
        public static string GetListOfCities(string cityName)
            {
                ApiKey = ConfigurationManager.AppSettings["ApiKey"];
                string url = $"http://dataservice.accuweather.com/locations/v1/cities/search?apikey={ApiKey}&q={cityName}";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string responseCity;
                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        responseCity = streamReader.ReadToEnd();
                    }
                    return responseCity;
            }
            public static string GetListOfWeather(int locationKey)
            {
                ApiKey = ConfigurationManager.AppSettings["ApiKey"];
                string urlWeather = $"http://dataservice.accuweather.com/forecasts/v1/daily/5day/{locationKey}?apikey={ApiKey}&language=ru&metric=true";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(urlWeather);
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string responseWeather;
                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    responseWeather = streamReader.ReadToEnd();
                }
                return responseWeather;


            }
                
    }
    
}