using System;

namespace WeatherRequest
{
    public class Headline 
    {
        public DateTime EffectiveDate { get; set; } 
        public int EffectiveEpochDate { get; set; } 
        public int Severity { get; set; } 
        public string Text { get; set; } 
        public string Category { get; set; } 
        public DateTime EndDate { get; set; } 
        public int EndEpochDate { get; set; } 
        public string MobileLink { get; set; } 
        public string Link { get; set; } 
    }
}