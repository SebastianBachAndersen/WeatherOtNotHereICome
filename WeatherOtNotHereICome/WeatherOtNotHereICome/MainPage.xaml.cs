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
            GetWeatherData();
        }

        private void ToHoroscope(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HoroscopeList());
        }
        public async Task<WeatherData> GetWeatherData()
        {
            var location = await Geolocation.GetLastKnownLocationAsync();
            string url = "https://api.openweathermap.org/data/2.5/onecall?lat=" +  $"{location.Latitude}&lon={location.Longitude}&exclude=alerts,minutely&appid=29c7a53dbed814effac1da056c8993eb&units=metric&lang=da";
            WeatherData data = await WebRequest.GetData<WeatherData>(url);
            try
            {
                if (location != null)
                {
                    var placemark = (await Geocoding.GetPlacemarksAsync(data.lat, data.lon)).FirstOrDefault();
                    locationLabel.Text = String.Format("{0}, {1}", placemark.Locality, placemark.CountryName);
                    bigWeatherImage.BindingContext = data.current;
                    bigWeatherLabel.Text = $"{Math.Round(data.current.temp)}°";
                    humidityLabel.Text = $"{data.current.humidity}%";
                    uvLabel.Text = data.current.uvi.ToString();
                    data.hourly.RemoveAt(0);
                    collectionViewHours.ItemsSource = data.hourly.Where((x) => x.dt <= DateTime.Now.Date.AddDays(1));
                    collectionViewDays.ItemsSource = data.daily;
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
