using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Diskspace
    {
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        [JsonPropertyName("path")] public string Path { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        [JsonPropertyName("label")] public string Label { get; set; }

        /// <summary>
        /// Gets or sets the free space.
        /// </summary>
        /// <value>
        /// The free space.
        /// </value>
        [JsonPropertyName("freeSpace")] public long FreeSpace { get; set; }

        /// <summary>
        /// Gets or sets the total space.
        /// </summary>
        /// <value>
        /// The total space.
        /// </value>
        [JsonPropertyName("totalSpace")] public long TotalSpace { get; set; }
    }
}
