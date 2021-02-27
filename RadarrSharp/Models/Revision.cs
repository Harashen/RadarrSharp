using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Revision
    {
        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        [JsonPropertyName("version")] public long Version { get; set; }

        /// <summary>
        /// Gets or sets the real.
        /// </summary>
        /// <value>
        /// The real.
        /// </value>
        [JsonPropertyName("real")] public long Real { get; set; }
    }
}
