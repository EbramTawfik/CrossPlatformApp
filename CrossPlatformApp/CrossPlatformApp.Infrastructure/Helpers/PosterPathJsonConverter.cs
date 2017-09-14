using Newtonsoft.Json;
using System;

namespace CrossPlatformApp.Infrastructure
{
    class PosterPathJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(string));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return "http://image.tmdb.org/t/p/w185" + reader.Value;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

            throw new NotImplementedException();
        }
    }
}
