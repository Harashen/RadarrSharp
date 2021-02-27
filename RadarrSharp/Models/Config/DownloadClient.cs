
using System.Text.Json.Serialization;

namespace RadarrSharp.Models.Config
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DownloadClient
    {
        /// <summary>
        /// Gets or sets the downloaded movies folder.
        /// </summary>
        /// <value>
        /// The downloaded movies folder.
        /// </value>
        [JsonPropertyName("downloadedMoviesFolder")] public string DownloadedMoviesFolder { get; set; }

        /// <summary>
        /// Gets or sets the download client working folders.
        /// </summary>
        /// <value>
        /// The download client working folders.
        /// </value>
        [JsonPropertyName("downloadClientWorkingFolders")] public string DownloadClientWorkingFolders { get; set; }

        /// <summary>
        /// Gets or sets the downloaded movies scan interval.
        /// </summary>
        /// <value>
        /// The downloaded movies scan interval.
        /// </value>
        [JsonPropertyName("downloadedMoviesScanInterval")] public long DownloadedMoviesScanInterval { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [enable completed download handling].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable completed download handling]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("enableCompletedDownloadHandling")] public bool EnableCompletedDownloadHandling { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [remove completed downloads].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [remove completed downloads]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("removeCompletedDownloads")] public bool RemoveCompletedDownloads { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [automatic redownload failed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [automatic redownload failed]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("autoRedownloadFailed")] public bool AutoRedownloadFailed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [remove failed downloads].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [remove failed downloads]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("removeFailedDownloads")] public bool RemoveFailedDownloads { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")] public long Id { get; set; }
    }
}
