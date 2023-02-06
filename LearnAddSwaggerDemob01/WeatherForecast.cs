using System;

namespace LearnAddSwaggerDemob01
{
    /// <summary>
    /// Date for weather
    /// </summary>
    public class WeatherForecast
    {


        /// <summary>
        /// Date for weather
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Temperature in C
        /// </summary>
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
