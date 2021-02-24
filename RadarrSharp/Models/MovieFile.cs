using System;
using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MovieFile
    {
        /// <summary>
        /// Gets or sets the movie identifier.
        /// </summary>
        /// <value>
        /// The movie identifier.
        /// </value>
        [JsonPropertyName("movieId")] public int MovieId { get; set; }

        /// <summary>
        /// Gets or sets the relative path.
        /// </summary>
        /// <value>
        /// The relative path.
        /// </value>
        [JsonPropertyName("relativePath")] public string RelativePath { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [JsonPropertyName("size")] public long Size { get; set; }

        /// <summary>
        /// Gets or sets the date added.
        /// </summary>
        /// <value>
        /// The date added.
        /// </value>
        [JsonPropertyName("dateAdded")] public DateTimeOffset DateAdded { get; set; }

        /// <summary>
        /// Gets or sets the name of the scene.
        /// </summary>
        /// <value>
        /// The name of the scene.
        /// </value>
        [JsonPropertyName("sceneName")] public string SceneName { get; set; }

        /// <summary>
        /// Gets or sets the release group.
        /// </summary>
        /// <value>
        /// The release group.
        /// </value>
        [JsonPropertyName("releaseGroup")] public string ReleaseGroup { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [JsonPropertyName("quality")] public MovieFileQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the edition.
        /// </summary>
        /// <value>
        /// The edition.
        /// </value>
        [JsonPropertyName("edition")] public string Edition { get; set; }

        /// <summary>
        /// Gets or sets the media information.
        /// </summary>
        /// <value>
        /// The media information.
        /// </value>
        [JsonPropertyName("mediaInfo")] public MediaInfo MediaInfo { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")] public int Id { get; set; }
    }
}
