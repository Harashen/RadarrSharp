using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormatTag
    {
        /// <summary>
        /// Gets or sets the raw.
        /// </summary>
        /// <value>
        /// The raw.
        /// </value>
        [JsonPropertyName("raw")] public string Raw { get; set; }

        /// <summary>
        /// Gets or sets the type of the tag.
        /// </summary>
        /// <value>
        /// The type of the tag.
        /// </value>
        [JsonPropertyName("tagType")] public string TagType { get; set; }

        /// <summary>
        /// Gets or sets the tag modifier.
        /// </summary>
        /// <value>
        /// The tag modifier.
        /// </value>
        [JsonPropertyName("tagModifier")] public string TagModifier { get; set; }

        /// <summary>
        /// Gets or sets the format tag value.
        /// </summary>
        /// <value>
        /// The format tag value.
        /// </value>
        [JsonPropertyName("value")] public FormatTagValue FormatTagValue { get; set; }
    }
}
