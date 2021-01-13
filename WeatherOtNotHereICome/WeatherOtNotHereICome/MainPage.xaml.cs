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
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        public async Task<Root> GetWeatherData()
        {
            var location = await Geolocation.GetLastKnownLocationAsync();
            Root data = await WebRequest.GetWeather("https://api.openweathermap.org/data/2.5/onecall?lat=" + location.Latitude.ToString() + "&lon=" + location.Longitude.ToString() + "&exclude=alerts,minutely,daily&appid=29c7a53dbed814effac1da056c8993eb&units=metric&lang=da");
            try
            {
                

                if (location != null)
                {
                    
                    lblLatitude.Text = "Latitude: " + data.lat;
                    lblLongitude.Text = "Longtitude: " + data.lon;
                    return data;
                }
            }
            catch (FeatureNotSupportedException e)
            {
                await DisplayAlert("fail", e.Message, "ok");
            }
            return data;
        }
        
    }
}
