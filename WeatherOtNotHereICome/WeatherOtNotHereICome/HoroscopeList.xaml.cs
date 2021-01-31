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
                horoscopeName: "Aries",
                horoscopeImage: "zodiac_aries.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Taurus",
                horoscopeImage: "zodiac_taurus.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Gemini",
                horoscopeImage: "zodiac_gemini.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Cancer",
                horoscopeImage: "zodiac_cancer.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Leo",
                horoscopeImage: "zodiac_leo.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Virgo",
                horoscopeImage: "zodiac_virgo.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Libra",
                horoscopeImage: "zodiac_libra.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Scorpio",
                horoscopeImage: "zodiac_scorpio.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Sagittarius",
                horoscopeImage: "zodiac_sagittarius.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Capricorn",
                horoscopeImage: "zodiac_capricorn.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Aquarius",
                horoscopeImage: "zodiac_aquarius.png"
            ));
            horoscopes.Add(new Horoscope(
                horoscopeName: "Pisces",
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