using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Restriction
    {
        /// <summary>
        /// Gets or sets the ignored.
        /// </summary>
        /// <value>
        /// The ignored.
        /// </value>
        [JsonPropertyName("ignored")] public string Ignored { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>
        /// The tags.
        /// </value>
        [JsonPropertyName("tags")] public List<long> Tags { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")] public int Id { get; set; }

        /// <summary>
        /// Gets or sets the restriction required.
        /// </summary>
        /// <value>
        /// The restriction required.
        /// </value>
        [JsonPropertyName("required")] public string RestrictionRequired { get; set; }
    }
}
