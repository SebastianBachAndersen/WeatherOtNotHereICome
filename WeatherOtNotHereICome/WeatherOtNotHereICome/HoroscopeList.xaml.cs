using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherOtNotHereICome
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HoroscopeList : ContentPage
    {
        public HoroscopeList()
        {
            List<Horoscope> horoscopes = new List<Horoscope>();

            horoscopes.Add(new Horoscope(
                horoscopeName: "Vædder",
                horoscopeImage: "zodiac_aries.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Tyr",
                horoscopeImage: "zodiac_taurus.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Tvilling",
                horoscopeImage: "zodiac_gemini.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Krebs",
                horoscopeImage: "zodiac_cancer.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Løve",
                horoscopeImage: "zodiac_leo.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Jomfru",
                horoscopeImage: "zodiac_virgo.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Vægt",
                horoscopeImage: "zodiac_libra.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Skorpion",
                horoscopeImage: "zodiac_scorpio.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Skytte",
                horoscopeImage: "zodiac_sagittarius.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Stenbuk",
                horoscopeImage: "zodiac_capricorn.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Vandmand",
                horoscopeImage: "zodiac_aquarius.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Fisk",
                horoscopeImage: "zodiac_pisces.png"
            ));


            InitializeComponent();
            collectionView.ItemsSource = horoscopes;
        }

        private void ToDetailsPage(object sender, EventArgs e)
        {
            Frame frame = sender as Frame;
            Navigation.PushAsync(new HoroscopeDetails(frame.BindingContext as Horoscope));
        }
    }

    public class Horoscope
    {
        public string HoroscopeName { get; set; }
        public string HoroscopeImage { get; set; }

        public Horoscope(string horoscopeName, string horoscopeImage)
        {
            HoroscopeName = horoscopeName;
            HoroscopeImage = horoscopeImage;
        }
    }
}