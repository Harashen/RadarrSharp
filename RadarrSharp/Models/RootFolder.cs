using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RootFolder
    {
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        [JsonPropertyName("path")] public string Path { get; set; }

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

        /// <summary>
        /// Gets or sets the unmapped folders.
        /// </summary>
        /// <value>
        /// The unmapped folders.
        /// </value>
        [JsonPropertyName("unmappedFolders")] public IList<UnmappedFolder> UnmappedFolders { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")] public int Id { get; set; }
    }
}
