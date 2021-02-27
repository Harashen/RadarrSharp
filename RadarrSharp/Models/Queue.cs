using RadarrSharp.Enums;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Queue
    {
        /// <summary>
        /// Gets or sets the movie.
        /// </summary>
        /// <value>
        /// The movie.
        /// </value>
        [JsonPropertyName("movie")] public Movie Movie { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [JsonPropertyName("quality")] public QueueQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [JsonPropertyName("size")] public long Size { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonPropertyName("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the sizeleft.
        /// </summary>
        /// <value>
        /// The sizeleft.
        /// </value>
        [JsonPropertyName("sizeleft")] public long Sizeleft { get; set; }

        /// <summary>
        /// Gets or sets the timeleft.
        /// </summary>
        /// <value>
        /// The timeleft.
        /// </value>
        [JsonPropertyName("timeleft")] public DateTimeOffset Timeleft { get; set; }

        /// <summary>
        /// Gets or sets the estimated completion time.
        /// </summary>
        /// <value>
        /// The estimated completion time.
        /// </value>
        [JsonPropertyName("estimatedCompletionTime")] public DateTimeOffset EstimatedCompletionTime { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [JsonPropertyName("status")] public string Status { get; set; }

        /// <summary>
        /// Gets or sets the tracked download status.
        /// </summary>
        /// <value>
        /// The tracked download status.
        /// </value>
        [JsonPropertyName("trackedDownloadStatus")] public string TrackedDownloadStatus { get; set; }

        /// <summary>
        /// Gets or sets the status messages.
        /// </summary>
        /// <value>
        /// The status messages.
        /// </value>
        [JsonPropertyName("statusMessages")] public List<object> StatusMessages { get; set; }

        /// <summary>
        /// Gets or sets the download identifier.
        /// </summary>
        /// <value>
        /// The download identifier.
        /// </value>
        [JsonPropertyName("downloadId")] public string DownloadId { get; set; }

        /// <summary>
        /// Gets or sets the protocol.
        /// </summary>
        /// <value>
        /// The protocol.
        /// </value>
        [JsonPropertyName("protocol")] public Protocol Protocol { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")] public int Id { get; set; }
    }
}
