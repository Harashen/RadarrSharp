using System;
using System.Collections.Generic;
using System.Text.Json;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial struct Value
    {
        /// <summary>
        /// The bool
        /// </summary>
        public bool? Bool;

        /// <summary>
        /// The integer
        /// </summary>
        public long? Integer;

        /// <summary>
        /// The integer array
        /// </summary>
        public List<object> AnythingArray;

        /// <summary>
        /// The string
        /// </summary>
        public string String;
    }

    public partial struct Value
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Value"/> struct.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <exception cref="Exception">Cannot convert Value</exception>
        public Value(Utf8JsonReader reader)
        {
            Bool = null;
            Integer = null;
            AnythingArray = null;
            String = null;

            switch (reader.TokenType)
            {
                case JsonTokenType.Number:
                    Integer = JsonSerializer.Deserialize<long>(ref reader);
                    return;
                case JsonTokenType.True:
                case JsonTokenType.False:
                    Bool = JsonSerializer.Deserialize<bool>(ref reader);
                    return;
                case JsonTokenType.StartArray:
                    AnythingArray = JsonSerializer.Deserialize<List<object>>(ref reader);
                    return;
                case JsonTokenType.String:
                //case JsonTokenType.Date:
                    String = JsonSerializer.Deserialize<string>(ref reader);
                    return;
            }
            throw new Exception("Cannot convert Value");
        }

        /// <summary>
        /// Writes the json.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <exception cref="Exception">Union must not be null</exception>
        public void WriteJson(Utf8JsonWriter writer)
        {
            if (Bool != null)
            {
                JsonSerializer.Serialize(writer, Bool);
                return;
            }
            if (Integer != null)
            {
                JsonSerializer.Serialize(writer, Integer);
                return;
            }
            if (AnythingArray != null)
            {
                JsonSerializer.Serialize(writer, AnythingArray);
                return;
            }
            if (String != null)
            {
                JsonSerializer.Serialize(writer, String);
                return;
            }
            throw new Exception("Union must not be null");
        }
    }
}
