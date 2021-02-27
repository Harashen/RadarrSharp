using RadarrSharp.Enums;

using System;
using System.Text.Json;

namespace RadarrSharp.Extensions
{
    static class ScanTypeExtensions
    {
        public static ScanType? ValueForString(string str)
        {
            switch (str)
            {
                case "": return ScanType.Empty;
                case "Interlaced": return ScanType.Interlaced;
                case "MBAFF": return ScanType.Mbaff;
                case "Progressive": return ScanType.Progressive;
                default: return null;
            }
        }

        public static ScanType ReadJson(Utf8JsonReader reader)
        {
            var str = JsonSerializer.Deserialize<string>(ref reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ScanType value, Utf8JsonWriter writer)
        {
            switch (value)
            {
                case ScanType.Empty: JsonSerializer.Serialize(writer, ""); break;
                case ScanType.Interlaced: JsonSerializer.Serialize(writer, "Interlaced"); break;
                case ScanType.Mbaff: JsonSerializer.Serialize(writer, "MBAFF"); break;
                case ScanType.Progressive: JsonSerializer.Serialize(writer, "Progressive"); break;
            }
        }
    }
}
