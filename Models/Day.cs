namespace WeatherRequest
{
    public class Day
    {
        public int Icon { get; set; } 
        public string IconPhrase { get; set; } 
        public bool HasPrecipitation { get; set; } 
        public string PrecipitationType { get; set; } 
        public string PrecipitationIntensity { get; set; } 
    }
}