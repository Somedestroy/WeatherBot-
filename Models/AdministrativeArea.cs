namespace WeatherRequest
{
    public class AdministrativeArea
    {
        public string ID {get; set;}
        public string LocalizedName {get; set;}
        public string EnglishName {get; set;}
        public int Level { get; set; } 
        public string LocalizedType { get; set; } 
        public string EnglishType { get; set; } 
        public string CountryID { get; set; } 
    }
}