using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class QueueQuality
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
    }
}
