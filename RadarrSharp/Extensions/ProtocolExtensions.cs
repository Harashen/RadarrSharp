using RadarrSharp.Enums;

using System;
using System.Text.Json;

namespace RadarrSharp.Extensions
{
    static class ProtocolExtensions
    {
        public static Protocol? ValueForString(string str)
        {
            switch (str)
            {
                case "usenet": return Protocol.Usenet;
                case "torrent": return Protocol.Torrent;
                default: return null;
            }
        }

        public static Protocol ReadJson(Utf8JsonReader reader)
        {
            var str = JsonSerializer.Deserialize<string>(ref reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Protocol value, Utf8JsonWriter writer)
        {
            switch (value)
            {
                case Protocol.Usenet: JsonSerializer.Serialize(writer, "usenet"); break;
                case Protocol.Torrent: JsonSerializer.Serialize(writer, "torrent"); break;
            }
        }
    }
}
