using System.Configuration;
using System;
//using Microsoft.Extensions.Configuration;

namespace WeatherRequest
{
  class Program
  {
  static void Main(string[] args)
    {
      string cityname = "";
      if (args.Length != 0 && args[0] == "/cityname")
      {
        cityname = args[1];
      }
      
      BussinesLogic.GetWeather(BussinesLogic.GetSelectedCity(cityname));
    }
      
  }
}

