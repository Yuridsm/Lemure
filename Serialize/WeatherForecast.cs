using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.Serialize
{
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
        public ComplexWrap Anyone { get; set; }
        public WeatherForecast()
        {
            string j = "Yuri";
        }
    }
}
