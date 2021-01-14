using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Newtonsoft.Json.Serialization;

namespace WeatherOtNotHereICome
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            GetWeatherData();
            //SetItemSource(null, null);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        public void SetItemSource(object sender, EventArgs e)
        {
            List<DummyClass> yeet = new List<DummyClass>();
            for (int i = 0; i < 10; i++)
            {
                yeet.Add(new DummyClass("13:37", "1°", "0%", "Ekstrem"));
            }
            carouselView.ItemsSource = yeet;
        }

        private void ToHoroscope(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HoroscopeList());
        }
        public async Task<Root> GetWeatherData()
        {
            var location = await Geolocation.GetLastKnownLocationAsync();
            Root data = await WebRequest.GetWeather("https://api.openweathermap.org/data/2.5/onecall?lat=" + location.Latitude.ToString() + "&lon=" + location.Longitude.ToString() + "&exclude=alerts,minutely,daily&appid=29c7a53dbed814effac1da056c8993eb&units=metric&lang=da");
            try
            {


                if (location != null)
                {
                    locationLabel.Text = data.timezone;
                    bigWeatherLabel.Text = data.current.temp.ToString();
                    humidityLabel.Text = data.current.humidity.ToString() + "%";
                    uvLabel.Text = data.current.uvi.ToString();

                    List<Hourly> temp = new List<Hourly>();
                    //temp.Add(data.hourly);
                    //carouselView.ItemsSource = temp;
                    return data;
                }
            }
            catch (FeatureNotSupportedException e)
            {
                await DisplayAlert("fail", e.Message, "ok");
            }
            return data;
        }
        public class DummyClass
        {
            public string Time { get; set; }
            public string Temp { get; set; }
            public string Humidity { get; set; }
            public string Uv { get; set; }


            public DummyClass(string time, string temp, string humidity, string uv)
            {
                Time = time;
                Temp = temp;
                Humidity = humidity;
                Uv = uv;
            }
            


        }
    }
}
