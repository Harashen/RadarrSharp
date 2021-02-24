using RadarrSharp.Enums;

using System;
using System.Text.Json;

namespace RadarrSharp.Extensions
{
    static class MappingResultExtensions
    {
        public static MappingResult? ValueForString(string str)
        {
            switch (str)
            {
                case "notParsable": return MappingResult.NotParsable;
                case "success": return MappingResult.Success;
                case "titleNotFound": return MappingResult.TitleNotFound;
                default: return null;
            }
        }

        public static MappingResult ReadJson(Utf8JsonReader reader)
        {
            var str = JsonSerializer.Deserialize<string>(ref reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this MappingResult value, Utf8JsonWriter writer)
        {
            switch (value)
            {
                case MappingResult.NotParsable: JsonSerializer.Serialize(writer, "notParsable"); break;
                case MappingResult.Success: JsonSerializer.Serialize(writer, "success"); break;
                case MappingResult.TitleNotFound: JsonSerializer.Serialize(writer, "titleNotFound"); break;
            }
        }
    }
}
