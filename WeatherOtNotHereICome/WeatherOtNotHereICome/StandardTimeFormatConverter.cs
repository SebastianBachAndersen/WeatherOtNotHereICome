using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherOtNotHereICome
{
    class StandardTimeFormatConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string dt = DateTime.Parse(reader.Value.ToString()).ToString("HH:mm");
            return dt;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
