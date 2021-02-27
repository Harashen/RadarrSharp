using System;
using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class LogFile
    {
        /// <summary>
        /// Gets or sets the filename.
        /// </summary>
        /// <value>
        /// The filename.
        /// </value>
        [JsonPropertyName("filename")] public string Filename { get; set; }

        /// <summary>
        /// Gets or sets the last write time.
        /// </summary>
        /// <value>
        /// The last write time.
        /// </value>
        [JsonPropertyName("lastWriteTime")] public DateTimeOffset LastWriteTime { get; set; }

        /// <summary>
        /// Gets or sets the contents URL.
        /// </summary>
        /// <value>
        /// The contents URL.
        /// </value>
        [JsonPropertyName("contentsUrl")] public string ContentsUrl { get; set; }

        /// <summary>
        /// Gets or sets the download URL.
        /// </summary>
        /// <value>
        /// The download URL.
        /// </value>
        [JsonPropertyName("downloadUrl")] public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")] public int Id { get; set; }
    }
}
