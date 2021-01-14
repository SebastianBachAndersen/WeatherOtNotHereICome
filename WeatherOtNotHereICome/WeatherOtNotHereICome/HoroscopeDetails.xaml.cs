using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherOtNotHereICome
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HoroscopeDetails : ContentPage
    {
        public HoroscopeDetails(Horoscope horoscope)
        {
            GetDataAsync(horoscope.HoroscopeImage);
            InitializeComponent();
            Title = horoscope.HoroscopeName;
        }

        public async void GetDataAsync(string horoscopeImage)
        {
            ResponseObject temp = await WebRequest.PostData<ResponseObject>(GetHoroscopeApiString(horoscopeImage));
            stackLayout.BindingContext = temp;
        }



        private string GetHoroscopeApiString(string horoscopeImage)
        {
            string output = "https://aztro.sameerkumar.website?sign=";
            int horoLenght = horoscopeImage.Length;
            horoscopeImage = horoscopeImage.Replace("zodiac_", "");
            horoscopeImage = horoscopeImage.Replace(".png", "");


            output += $"{horoscopeImage}&day=today";
            return output;
        }

        public class ResponseObject
        {
            [JsonProperty("date_range")]
            public string DateRange { get; set; }

            [JsonProperty("current_date")]
            public string CurrentDate { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("compatibility")]
            public string Compatibility { get; set; }

            [JsonProperty("mood")]
            public string Mood { get; set; }

            [JsonProperty("color")]
            public string Color { get; set; }

            [JsonProperty("lucky_number")]
            public string LuckyNumber { get; set; }

            [JsonProperty("lucky_time")]
            public string LuckyTime { get; set; }
        }

    }
}