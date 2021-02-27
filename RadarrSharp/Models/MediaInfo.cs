using RadarrSharp.Enums;

using System;
using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MediaInfo
    {
        /// <summary>
        /// Gets or sets the video codec.
        /// </summary>
        /// <value>
        /// The video codec.
        /// </value>
        [JsonPropertyName("videoCodec")] public string VideoCodec { get; set; }

        /// <summary>
        /// Gets or sets the video bitrate.
        /// </summary>
        /// <value>
        /// The video bitrate.
        /// </value>
        [JsonPropertyName("videoBitrate")] public long VideoBitrate { get; set; }

        /// <summary>
        /// Gets or sets the video bit depth.
        /// </summary>
        /// <value>
        /// The video bit depth.
        /// </value>
        [JsonPropertyName("videoBitDepth")] public int VideoBitDepth { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        [JsonPropertyName("width")] public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        [JsonPropertyName("height")] public int Height { get; set; }

        /// <summary>
        /// Gets or sets the audio format.
        /// </summary>
        /// <value>
        /// The audio format.
        /// </value>
        [JsonPropertyName("audioFormat")] public string AudioFormat { get; set; }

        /// <summary>
        /// Gets or sets the audio bitrate.
        /// </summary>
        /// <value>
        /// The audio bitrate.
        /// </value>
        [JsonPropertyName("audioBitrate")] public long AudioBitrate { get; set; }

        /// <summary>
        /// Gets or sets the run time.
        /// </summary>
        /// <value>
        /// The run time.
        /// </value>
        [JsonPropertyName("runTime")] public TimeSpan RunTime { get; set; }

        /// <summary>
        /// Gets or sets the audio stream count.
        /// </summary>
        /// <value>
        /// The audio stream count.
        /// </value>
        [JsonPropertyName("audioStreamCount")] public int AudioStreamCount { get; set; }

        /// <summary>
        /// Gets or sets the audio channels.
        /// </summary>
        /// <value>
        /// The audio channels.
        /// </value>
        [JsonPropertyName("audioChannels")] public int AudioChannels { get; set; }

        /// <summary>
        /// Gets or sets the audio channel positions.
        /// </summary>
        /// <value>
        /// The audio channel positions.
        /// </value>
        [JsonPropertyName("audioChannelPositions")] public string AudioChannelPositions { get; set; }

        /// <summary>
        /// Gets or sets the audio channel positions text.
        /// </summary>
        /// <value>
        /// The audio channel positions text.
        /// </value>
        [JsonPropertyName("audioChannelPositionsText")] public string AudioChannelPositionsText { get; set; }

        /// <summary>
        /// Gets or sets the audio profile.
        /// </summary>
        /// <value>
        /// The audio profile.
        /// </value>
        [JsonPropertyName("audioProfile")] public string AudioProfile { get; set; }

        /// <summary>
        /// Gets or sets the video FPS.
        /// </summary>
        /// <value>
        /// The video FPS.
        /// </value>
        [JsonPropertyName("videoFps")] public double VideoFps { get; set; }

        /// <summary>
        /// Gets or sets the audio languages.
        /// </summary>
        /// <value>
        /// The audio languages.
        /// </value>
        [JsonPropertyName("audioLanguages")] public string AudioLanguages { get; set; }

        /// <summary>
        /// Gets or sets the subtitles.
        /// </summary>
        /// <value>
        /// The subtitles.
        /// </value>
        [JsonPropertyName("subtitles")] public string Subtitles { get; set; }

        /// <summary>
        /// Gets or sets the type of the scan.
        /// </summary>
        /// <value>
        /// The type of the scan.
        /// </value>
        [JsonPropertyName("scanType")] public ScanType ScanType { get; set; }

        /// <summary>
        /// Gets or sets the schema revision.
        /// </summary>
        /// <value>
        /// The schema revision.
        /// </value>
        [JsonPropertyName("schemaRevision")] public long SchemaRevision { get; set; }
    }
}
