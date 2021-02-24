using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Item
    {
        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [JsonPropertyName("quality")] public Cutoff Quality { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Item"/> is allowed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if allowed; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("allowed")] public bool Allowed { get; set; }
    }
}
