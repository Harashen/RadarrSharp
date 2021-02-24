using RadarrSharp.Enums;

using System;
using System.Text.Json;

namespace RadarrSharp.Extensions
{
    static class MinimumAvailabilityExtensions
    {
        public static MinimumAvailability? ValueForString(string str)
        {
            switch (str)
            {
                case "announced": return MinimumAvailability.Announced;
                case "inCinemas": return MinimumAvailability.InCinemas;
                case "preDB": return MinimumAvailability.PreDb;
                case "released": return MinimumAvailability.Released;
                case "tba": return MinimumAvailability.Tba;
                default: return null;
            }
        }

        public static MinimumAvailability ReadJson(Utf8JsonReader reader)
        {
            var str = JsonSerializer.Deserialize<string>(ref reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this MinimumAvailability value, Utf8JsonWriter writer)
        {
            switch (value)
            {
                case MinimumAvailability.Announced: JsonSerializer.Serialize(writer, "announced"); break;
                case MinimumAvailability.InCinemas: JsonSerializer.Serialize(writer, "inCinemas"); break;
                case MinimumAvailability.PreDb: JsonSerializer.Serialize(writer, "preDB"); break;
                case MinimumAvailability.Released: JsonSerializer.Serialize(writer, "released"); break;
                case MinimumAvailability.Tba: JsonSerializer.Serialize(writer, "tba"); break;
            }
        }
    }
}
