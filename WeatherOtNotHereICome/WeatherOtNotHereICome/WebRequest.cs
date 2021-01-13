using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherOtNotHereICome
{
    public class WebRequest
    {
        static HttpClient client = new HttpClient();

        public static async Task<Root> GetWeather(string url)
        {
            string response = await client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<Root>(response);
        }
        

    }
}
