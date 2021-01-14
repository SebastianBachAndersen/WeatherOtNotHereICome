using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherOtNotHereICome
{
    public class WeatherData
    {
        [JsonProperty("lat")]
        public double lat { get; set; }

        [JsonProperty("lon")]
        public double lon { get; set; }

        [JsonProperty("timezone")]
        public string timezone { get; set; }

        [JsonProperty("timezone_offset")]
        public int timezone_offset { get; set; }

        [JsonProperty("current")]
        public Current current { get; set; }

        [JsonProperty("hourly")]
        public List<Hourly> hourly { get; set; }

        [JsonProperty("daily")]
        public List<Daily> daily { get; set; }
    }
}
