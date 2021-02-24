using RadarrSharp.Enums;

using System;
using System.Text.Json;

namespace RadarrSharp.Extensions
{
    static class SourceTypeExtensions
    {
        public static SourceType? ValueForString(string str)
        {
            switch (str)
            {
                case "tmdb": return SourceType.Tmdb;
                case "mappings": return SourceType.Mappings;
                case "user": return SourceType.User;
                case "indexer": return SourceType.Indexer;
                default: return null;
            }
        }

        public static SourceType ReadJson(Utf8JsonReader reader)
        {
            var str = JsonSerializer.Deserialize<string>(ref reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this SourceType value, Utf8JsonWriter writer)
        {
            switch (value)
            {
                case SourceType.Tmdb: JsonSerializer.Serialize(writer, "tmdb"); break;
                case SourceType.Mappings: JsonSerializer.Serialize(writer, "mappings"); break;
                case SourceType.User: JsonSerializer.Serialize(writer, "user"); break;
                case SourceType.Indexer: JsonSerializer.Serialize(writer, "indexer"); break;
            }
        }
    }
}
