using RadarrSharp.Enums;
using RadarrSharp.Extensions;
using RadarrSharp.Models;

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RadarrSharp.Helpers
{
	internal class ObjectConverter : JsonConverter<object>
    {
        public override bool CanConvert(Type t) =>
            t == typeof(CoverType) ||
            t == typeof(MinimumAvailability) ||
            t == typeof(ScanType) ||
            t == typeof(PathState) ||
            t == typeof(Status) ||
            t == typeof(SourceType) ||
            t == typeof(Level) ||
            t == typeof(Protocol) ||
            t == typeof(MappingResult) ||
            t == typeof(Value) ||

            t == typeof(CoverType?) ||
            t == typeof(MinimumAvailability?) ||
            t == typeof(ScanType?) ||
            t == typeof(PathState?) ||
            t == typeof(Status?) ||
            t == typeof(SourceType?) ||
            t == typeof(Level?) ||
            t == typeof(Protocol?) ||
            t == typeof(MappingResult?) ||
            t == typeof(Value?);

        public override object Read(ref Utf8JsonReader reader, Type t, JsonSerializerOptions options)
        {
            if (t == typeof(CoverType))
                return CoverTypeExtensions.ReadJson(reader);
            if (t == typeof(MinimumAvailability))
                return MinimumAvailabilityExtensions.ReadJson(reader);
            if (t == typeof(ScanType))
                return ScanTypeExtensions.ReadJson(reader);
            if (t == typeof(PathState))
                return PathStateExtensions.ReadJson(reader);
            if (t == typeof(Status))
                return StatusExtensions.ReadJson(reader);
            if (t == typeof(SourceType))
                return SourceTypeExtensions.ReadJson(reader);
            if (t == typeof(Level))
                return LevelExtensions.ReadJson(reader);
            if (t == typeof(Protocol))
                return ProtocolExtensions.ReadJson(reader);
            if (t == typeof(MappingResult))
                return MappingResultExtensions.ReadJson(reader);
            if (t == typeof(Value) || t == typeof(Value?))
                return new Value(reader);

            if (t == typeof(CoverType?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return CoverTypeExtensions.ReadJson(reader);
            }
            if (t == typeof(MinimumAvailability?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return MinimumAvailabilityExtensions.ReadJson(reader);
            }
            if (t == typeof(ScanType?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return ScanTypeExtensions.ReadJson(reader);
            }
            if (t == typeof(PathState?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return PathStateExtensions.ReadJson(reader);
            }
            if (t == typeof(Status?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return StatusExtensions.ReadJson(reader);
            }
            if (t == typeof(SourceType?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return SourceTypeExtensions.ReadJson(reader);
            }
            if (t == typeof(Level?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return LevelExtensions.ReadJson(reader);
            }
            if (t == typeof(Protocol?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return ProtocolExtensions.ReadJson(reader);
            }
            if (t == typeof(MappingResult?))
            {
                if (reader.TokenType == JsonTokenType.Null) return null;
                return MappingResultExtensions.ReadJson(reader);
            }

            throw new Exception("Unknown type");
        }

        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            var t = value.GetType();

            if (t == typeof(CoverType))
            {
                ((CoverType)value).WriteJson(writer);
                return;
            }
            if (t == typeof(MinimumAvailability))
            {
                ((MinimumAvailability)value).WriteJson(writer);
                return;
            }
            if (t == typeof(ScanType))
            {
                ((ScanType)value).WriteJson(writer);
                return;
            }
            if (t == typeof(PathState))
            {
                ((PathState)value).WriteJson(writer);
                return;
            }
            if (t == typeof(Status))
            {
                ((Status)value).WriteJson(writer);
                return;
            }
            if (t == typeof(SourceType))
            {
                ((SourceType)value).WriteJson(writer);
                return;
            }
            if (t == typeof(Level))
            {
                ((Level)value).WriteJson(writer);
                return;
            }
            if (t == typeof(Protocol))
            {
                ((Protocol)value).WriteJson(writer);
                return;
            }
            if (t == typeof(MappingResult))
            {
                ((MappingResult)value).WriteJson(writer);
                return;
            }
            if (t == typeof(Value))
            {
                ((Value)value).WriteJson(writer);
                return;
            }

            throw new Exception("Unknown type");
        }

        internal static readonly JsonSerializerOptions Settings = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = {
                new ObjectConverter(),
                new TimeSpanConverter()
                //new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
