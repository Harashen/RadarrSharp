using RadarrSharp.Enums;

using System;
using System.Text.Json;

namespace RadarrSharp.Extensions
{
    static class PathStateExtensions
    {
        public static PathState? ValueForString(string str)
        {
            switch (str)
            {
                case "static": return PathState.Static;
                case "dynamic": return PathState.Dynamic;
                default: return null;
            }
        }

        public static PathState ReadJson(Utf8JsonReader reader)
        {
            var str = JsonSerializer.Deserialize<string>(ref reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this PathState value, Utf8JsonWriter writer)
        {
            switch (value)
            {
                case PathState.Static: JsonSerializer.Serialize(writer, "static"); break;
                case PathState.Dynamic: JsonSerializer.Serialize(writer, "dynamic"); break;
            }
        }
    }
}
