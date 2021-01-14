using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace WeatherOtNotHereICome
{
    public class GetIcon : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string output = "";

            if (value is int val)
            {
                switch (val)
                {
                    case int n when (200 <= n && n <= 232):
                        output = "thunder.png";
                        break;
                    case int n when (300 <= n && n <= 321):
                        output = "rain.png";
                        break;
                    case int n when ((500 <= n && n <= 504) || (520 <= n && n <= 531)):
                        output = "rainy.png";
                        break;
                    case int n when (n == 511):
                        output = "snow.png";
                        break;
                    case int n when (600 <= n && n <= 622):
                        output = "snowy.png";
                        break;
                    case int n when (701 <= n && n <= 771):
                        output = "mist.png";
                        break;
                    case int n when (n == 781):
                        output = "tornado.png";
                        break;
                    case int n when n == 800:
                        output = "sun.png";
                        break;
                    case int n when (801 <= n && n <= 802):
                        output = "cloud.png";
                        break;
                    case int n when (803 <= n && n <= 804):
                        output = "cloudy.png";
                        break;
                    default:
                        break;
                }
                return output;
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
