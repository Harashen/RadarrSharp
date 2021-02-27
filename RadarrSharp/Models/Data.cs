using System;
using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Data
    {
        /// <summary>
        /// Gets or sets the indexer.
        /// </summary>
        /// <value>
        /// The indexer.
        /// </value>
        [JsonPropertyName("indexer")] public string Indexer { get; set; }

        /// <summary>
        /// Gets or sets the NZB information URL.
        /// </summary>
        /// <value>
        /// The NZB information URL.
        /// </value>
        [JsonPropertyName("nzbInfoUrl")] public string NzbInfoUrl { get; set; }

        /// <summary>
        /// Gets or sets the release group.
        /// </summary>
        /// <value>
        /// The release group.
        /// </value>
        [JsonPropertyName("releaseGroup")] public string ReleaseGroup { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        [JsonPropertyName("age")] public string Age { get; set; }

        /// <summary>
        /// Gets or sets the age hours.
        /// </summary>
        /// <value>
        /// The age hours.
        /// </value>
        [JsonPropertyName("ageHours")] public string AgeHours { get; set; }

        /// <summary>
        /// Gets or sets the age minutes.
        /// </summary>
        /// <value>
        /// The age minutes.
        /// </value>
        [JsonPropertyName("ageMinutes")] public string AgeMinutes { get; set; }

        /// <summary>
        /// Gets or sets the published date.
        /// </summary>
        /// <value>
        /// The published date.
        /// </value>
        [JsonPropertyName("publishedDate")] public DateTimeOffset? PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets the download client.
        /// </summary>
        /// <value>
        /// The download client.
        /// </value>
        [JsonPropertyName("downloadClient")] public string DownloadClient { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [JsonPropertyName("size")] public string Size { get; set; }

        /// <summary>
        /// Gets or sets the download URL.
        /// </summary>
        /// <value>
        /// The download URL.
        /// </value>
        [JsonPropertyName("downloadUrl")] public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        [JsonPropertyName("guid")] public string Guid { get; set; }

        /// <summary>
        /// Gets or sets the TVDB identifier.
        /// </summary>
        /// <value>
        /// The TVDB identifier.
        /// </value>
        [JsonPropertyName("tvdbId")] public string TvdbId { get; set; }

        /// <summary>
        /// Gets or sets the tv rage identifier.
        /// </summary>
        /// <value>
        /// The tv rage identifier.
        /// </value>
        [JsonPropertyName("tvRageId")] public string TvRageId { get; set; }

        /// <summary>
        /// Gets or sets the protocol.
        /// </summary>
        /// <value>
        /// The protocol.
        /// </value>
        [JsonPropertyName("protocol")] public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the torrent information hash.
        /// </summary>
        /// <value>
        /// The torrent information hash.
        /// </value>
        [JsonPropertyName("torrentInfoHash")] public string TorrentInfoHash { get; set; }

        /// <summary>
        /// Gets or sets the dropped path.
        /// </summary>
        /// <value>
        /// The dropped path.
        /// </value>
        [JsonPropertyName("droppedPath")] public string DroppedPath { get; set; }

        /// <summary>
        /// Gets or sets the imported path.
        /// </summary>
        /// <value>
        /// The imported path.
        /// </value>
        [JsonPropertyName("importedPath")] public string ImportedPath { get; set; }

        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        /// <value>
        /// The reason.
        /// </value>
        [JsonPropertyName("reason")] public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        [JsonPropertyName("message")] public string Message { get; set; }
    }
}
