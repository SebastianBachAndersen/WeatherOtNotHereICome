﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherOtNotHereICome
{
    public class Current
    {
        [JsonProperty("dt")]
        public int dt { get; set; }

        [JsonProperty("sunrise")]
        public int sunrise { get; set; }

        [JsonProperty("sunset")]
        public int sunset { get; set; }

        [JsonProperty("temp")]
        public double temp { get; set; }

        [JsonProperty("feels_like")]
        public double feels_like { get; set; }

        [JsonProperty("pressure")]
        public int pressure { get; set; }

        [JsonProperty("humidity")]
        public int humidity { get; set; }

        [JsonProperty("dew_point")]
        public double dew_point { get; set; }

        [JsonProperty("uvi")]
        public double uvi { get; set; }

        [JsonProperty("clouds")]
        public int clouds { get; set; }

        [JsonProperty("visibility")]
        public int visibility { get; set; }

        [JsonProperty("wind_speed")]
        public double wind_speed { get; set; }

        [JsonProperty("wind_deg")]
        public int wind_deg { get; set; }

        [JsonProperty("weather")]
        public List<Weather> weather { get; set; }
    }
}
