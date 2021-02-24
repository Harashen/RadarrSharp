using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReleaseQuality
    {
        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [JsonPropertyName("quality")] public QualityQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the revision.
        /// </summary>
        /// <value>
        /// The revision.
        /// </value>
        [JsonPropertyName("revision")] public Revision Revision { get; set; }

        /// <summary>
        /// Gets or sets the hardcoded subs.
        /// </summary>
        /// <value>
        /// The hardcoded subs.
        /// </value>
        [JsonPropertyName("hardcodedSubs")] public string HardcodedSubs { get; set; }
    }
}
