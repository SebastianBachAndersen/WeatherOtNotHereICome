using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeatherOtNotHereICome
{
    public class Daily
    {
        [JsonProperty("dt")]
        [JsonConverter(typeof(UTCDateTimeConverter))]
        public DateTime dt { get; set; }

        [JsonProperty("sunrise")]
        public int sunrise { get; set; }

        [JsonProperty("sunset")]
        public int sunset { get; set; }

        [JsonProperty("temp")]
        //[JsonConverter(typeof(Temperature))]
        public Temperature temp { get; set; }

        [JsonProperty("feels_like")]
        public Temperature feelsLike { get; set; }

        [JsonProperty("pressure")]
        public int pressure { get; set; }

        [JsonProperty("humidity")]
        public int humidity { get; set; }

        [JsonProperty("dew_point")]
        public double dewPoint { get; set; }

        [JsonProperty("wind_speed")]
        public double windSpeed { get; set; }

        [JsonProperty("wind_deg")]
        public int windDeg { get; set; }

        [JsonProperty("weather")]
        public List<Weather> weather { get; set; }

        [JsonProperty("clouds")]
        public int clouds { get; set; }

        [JsonProperty("pop")]
        public double pop { get; set; }

        [JsonProperty("uvi")]
        public double uvi { get; set; }
    }

    public class Temperature
    {
        [JsonProperty("day")]
        public double day { get; set; }

        [JsonProperty("min")]
        public double min { get; set; }

        [JsonProperty("max")]
        public double max { get; set; }

        [JsonProperty("night")]
        public double night { get; set; }

        [JsonProperty("eve")]
        public double eve { get; set; }

        [JsonProperty("morn")]
        public double morn { get; set; }
    }
}
