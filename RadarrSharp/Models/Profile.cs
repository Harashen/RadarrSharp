using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Profile
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonPropertyName("name")] public string Name { get; set; }

        /// <summary>
        /// Gets or sets the cutoff.
        /// </summary>
        /// <value>
        /// The cutoff.
        /// </value>
        [JsonPropertyName("cutoff")] public Cutoff Cutoff { get; set; }

        /// <summary>
        /// Gets or sets the preferred tags.
        /// </summary>
        /// <value>
        /// The preferred tags.
        /// </value>
        [JsonPropertyName("preferredTags")] public string PreferredTags { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        [JsonPropertyName("items")] public List<Item> Items { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        [JsonPropertyName("language")] public string Language { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")] public int Id { get; set; }
    }
}
