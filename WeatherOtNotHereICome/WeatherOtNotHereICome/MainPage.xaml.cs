using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
            SetItemSource(null, null);
        }
        public void SetItemSource(object sender, EventArgs e)
        {
            List<DummyClass> yeet = new List<DummyClass>();
            for (int i = 0; i < 10; i++)
            {
                yeet.Add(new DummyClass("10:00", "oi", "yeed", "AAAAAA"));
            }
            carouselView.ItemsSource = yeet;
        }
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
