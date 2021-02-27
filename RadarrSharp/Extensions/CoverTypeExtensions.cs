using RadarrSharp.Enums;

using System;
using System.Text.Json;

namespace RadarrSharp.Extensions
{
    static class CoverTypeExtensions
    {
        public static CoverType? ValueForString(string str)
        {
            switch (str)
            {
                case "banner": return CoverType.Banner;
                case "poster": return CoverType.Poster;
                case "fanart": return CoverType.FanArt;
                default: return null;
            }
        }

        public static CoverType ReadJson(Utf8JsonReader reader)
        {
            var str = JsonSerializer.Deserialize<string>(ref reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this CoverType value, Utf8JsonWriter writer)
        {
            switch (value)
            {
                case CoverType.Banner: JsonSerializer.Serialize(writer, "banner"); break;
                case CoverType.Poster: JsonSerializer.Serialize(writer, "poster"); break;
                case CoverType.FanArt: JsonSerializer.Serialize(writer, "fanart"); break;
            }
        }
    }
}
