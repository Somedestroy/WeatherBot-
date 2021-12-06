using System;
using static System.Console;
namespace WeatherRequest
{
    public class BussinesLogic
    {

        public static BasicCityInfo GetSelectedCity(string inputCity = "")
        {
            if (inputCity == "")
            {
                Write("Введите название города\n");
                inputCity = ReadLine();
            }
            var cities = DataProcessing.ReadCitiesData(SearchingData.GetListOfCities(inputCity));
            int numberInList= 0;
            foreach (var item in cities)
            {
                WriteLine($"Номер в списке: {numberInList.ToString()}\n" + $"Название в оригинале: {item.EnglishName}\n"
                + $"В переводе:  {item.LocalizedName} \n" + $"Страна: {item.Country.LocalizedName}\n" + $"Административный округ: {item.AdministrativeArea.LocalizedName}\n"
                + $"Тип: {item.AdministrativeArea.LocalizedType}\n");
                numberInList++;
            }
            Write("Введите номер города, который добавить в мониторинг\n");
            int number = Convert.ToInt32(ReadLine());
            while (number > cities.Count-1 || number < 0)
            {
                Write("Число выбрано не верно, введите число заново");
                number = Convert.ToInt32(ReadLine());
            }
            return cities[number];
        }
        public static void GetWeather(BasicCityInfo city)
        {
            var weather = DataProcessing.ReadWeatherData(SearchingData.GetListOfWeather(DataProcessing.GetLocationKey(city)));
            foreach (var element in weather.DailyForecasts)
            {
                WriteLine($"Дата: {element.Date}\n" + $"Температура минимальная: {element.Temperature.Minimum.Value}\n"
            +$"Температура максимальная: {element.Temperature.Maximum.Value}\n" + $"Примечание на день: {element.Day.IconPhrase}\n" + $"Примечание на ночь: {element.Night.IconPhrase}\n");
            }
        }
    }
}