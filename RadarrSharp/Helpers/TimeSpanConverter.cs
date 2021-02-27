using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RadarrSharp.Helpers
{
	internal class TimeSpanConverter : JsonConverter<TimeSpan>
	{
		public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var str = reader.GetString();
			return TimeSpan.ParseExact(str, "c", System.Globalization.CultureInfo.InvariantCulture);
		}

		public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
		{
			throw new NotImplementedException();
		}
	}
}
