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
        //static HttpClient client = new HttpClient();

        public static async Task<T> GetData<T>(string url) where T : class
        {
            T res = null;
            using(HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        res = JsonConvert.DeserializeObject<T>(content);
                    }
                    catch (Exception e)
                    {

                        throw;
                    }
                }
                return res;

            }
        }

        public static async Task<T> PostData<T>(string url, HttpContent data = null) where T : class
        {
            T res = null;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(url, data);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(content);
                }
                return res;
            }
        }


    }
}
