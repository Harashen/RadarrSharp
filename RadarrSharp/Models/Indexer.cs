using RadarrSharp.Enums;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Indexer
    {
        /// <summary>
        /// Gets or sets a value indicating whether [enable RSS].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable RSS]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("enableRss")] public bool EnableRss { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [enable search].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable search]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("enableSearch")] public bool EnableSearch { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [supports RSS].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [supports RSS]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("supportsRss")] public bool SupportsRss { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [supports search].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [supports search]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("supportsSearch")] public bool SupportsSearch { get; set; }

        /// <summary>
        /// Gets or sets the protocol.
        /// </summary>
        /// <value>
        /// The protocol.
        /// </value>
        [JsonPropertyName("protocol")] public Protocol Protocol { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonPropertyName("name")] public string Name { get; set; }

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        [JsonPropertyName("fields")] public List<Field> Fields { get; set; }

        /// <summary>
        /// Gets or sets the name of the implementation.
        /// </summary>
        /// <value>
        /// The name of the implementation.
        /// </value>
        [JsonPropertyName("implementationName")] public string ImplementationName { get; set; }

        /// <summary>
        /// Gets or sets the implementation.
        /// </summary>
        /// <value>
        /// The implementation.
        /// </value>
        [JsonPropertyName("implementation")] public string Implementation { get; set; }

        /// <summary>
        /// Gets or sets the configuration contract.
        /// </summary>
        /// <value>
        /// The configuration contract.
        /// </value>
        [JsonPropertyName("configContract")] public string ConfigContract { get; set; }

        /// <summary>
        /// Gets or sets the information link.
        /// </summary>
        /// <value>
        /// The information link.
        /// </value>
        [JsonPropertyName("infoLink")] public string InfoLink { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")] public int Id { get; set; }
    }
}
