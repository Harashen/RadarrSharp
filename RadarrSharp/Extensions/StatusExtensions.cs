using RadarrSharp.Enums;

using System;
using System.Text.Json;

namespace RadarrSharp.Extensions
{
    static class StatusExtensions
    {
        public static Status? ValueForString(string str)
        {
            switch (str)
            {
                case "announced": return Status.Announced;
                case "inCinemas": return Status.InCinemas;
                case "released": return Status.Released;
                case "tba": return Status.Tba;
                default: return null;
            }
        }

        public static Status ReadJson(Utf8JsonReader reader)
        {
            var str = JsonSerializer.Deserialize<string>(ref reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Status value, Utf8JsonWriter writer)
        {
            switch (value)
            {
                case Status.Announced: JsonSerializer.Serialize(writer, "announced"); break;
                case Status.InCinemas: JsonSerializer.Serialize(writer, "inCinemas"); break;
                case Status.Released: JsonSerializer.Serialize(writer, "released"); break;
                case Status.Tba: JsonSerializer.Serialize(writer, "tba"); break;
            }
        }
    }
}
