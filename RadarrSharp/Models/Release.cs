using RadarrSharp.Enums;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Release
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        [JsonPropertyName("guid")] public string Guid { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        /// <value>
        /// The quality.
        /// </value>
        [JsonPropertyName("quality")] public ReleaseQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the quality weight.
        /// </summary>
        /// <value>
        /// The quality weight.
        /// </value>
        [JsonPropertyName("qualityWeight")] public long QualityWeight { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        [JsonPropertyName("age")] public long Age { get; set; }

        /// <summary>
        /// Gets or sets the age hours.
        /// </summary>
        /// <value>
        /// The age hours.
        /// </value>
        [JsonPropertyName("ageHours")] public double AgeHours { get; set; }

        /// <summary>
        /// Gets or sets the age minutes.
        /// </summary>
        /// <value>
        /// The age minutes.
        /// </value>
        [JsonPropertyName("ageMinutes")] public double AgeMinutes { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [JsonPropertyName("size")] public long Size { get; set; }

        /// <summary>
        /// Gets or sets the indexer identifier.
        /// </summary>
        /// <value>
        /// The indexer identifier.
        /// </value>
        [JsonPropertyName("indexerId")] public int IndexerId { get; set; }

        /// <summary>
        /// Gets or sets the indexer.
        /// </summary>
        /// <value>
        /// The indexer.
        /// </value>
        [JsonPropertyName("indexer")] public string Indexer { get; set; }

        /// <summary>
        /// Gets or sets the release hash.
        /// </summary>
        /// <value>
        /// The release hash.
        /// </value>
        [JsonPropertyName("releaseHash")] public string ReleaseHash { get; set; }

        /// <summary>
        /// Gets or sets the edition.
        /// </summary>
        /// <value>
        /// The edition.
        /// </value>
        [JsonPropertyName("edition")] public string Edition { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonPropertyName("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [full season].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [full season]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("fullSeason")] public bool FullSeason { get; set; }

        /// <summary>
        /// Gets or sets the season number.
        /// </summary>
        /// <value>
        /// The season number.
        /// </value>
        [JsonPropertyName("seasonNumber")] public int SeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        [JsonPropertyName("language")] public string Language { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        [JsonPropertyName("year")] public long Year { get; set; }

        /// <summary>
        /// Gets or sets the movie title.
        /// </summary>
        /// <value>
        /// The movie title.
        /// </value>
        [JsonPropertyName("movieTitle")] public string MovieTitle { get; set; }

        /// <summary>
        /// Gets or sets the episode numbers.
        /// </summary>
        /// <value>
        /// The episode numbers.
        /// </value>
        [JsonPropertyName("episodeNumbers")] public List<object> EpisodeNumbers { get; set; }

        /// <summary>
        /// Gets or sets the absolute episode numbers.
        /// </summary>
        /// <value>
        /// The absolute episode numbers.
        /// </value>
        [JsonPropertyName("absoluteEpisodeNumbers")] public List<object> AbsoluteEpisodeNumbers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Release"/> is approved.
        /// </summary>
        /// <value>
        ///   <c>true</c> if approved; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("approved")] public bool Approved { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [temporarily rejected].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [temporarily rejected]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("temporarilyRejected")] public bool TemporarilyRejected { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Release"/> is rejected.
        /// </summary>
        /// <value>
        ///   <c>true</c> if rejected; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("rejected")] public bool Rejected { get; set; }

        /// <summary>
        /// Gets or sets the TVDB identifier.
        /// </summary>
        /// <value>
        /// The TVDB identifier.
        /// </value>
        [JsonPropertyName("tvdbId")] public long TvdbId { get; set; }

        /// <summary>
        /// Gets or sets the tv rage identifier.
        /// </summary>
        /// <value>
        /// The tv rage identifier.
        /// </value>
        [JsonPropertyName("tvRageId")] public long TvRageId { get; set; }

        /// <summary>
        /// Gets or sets the rejections.
        /// </summary>
        /// <value>
        /// The rejections.
        /// </value>
        [JsonPropertyName("rejections")] public List<string> Rejections { get; set; }

        /// <summary>
        /// Gets or sets the publish date.
        /// </summary>
        /// <value>
        /// The publish date.
        /// </value>
        [JsonPropertyName("publishDate")] public DateTimeOffset PublishDate { get; set; }

        /// <summary>
        /// Gets or sets the comment URL.
        /// </summary>
        /// <value>
        /// The comment URL.
        /// </value>
        [JsonPropertyName("commentUrl")] public string CommentUrl { get; set; }

        /// <summary>
        /// Gets or sets the download URL.
        /// </summary>
        /// <value>
        /// The download URL.
        /// </value>
        [JsonPropertyName("downloadUrl")] public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets the information URL.
        /// </summary>
        /// <value>
        /// The information URL.
        /// </value>
        [JsonPropertyName("infoUrl")] public string InfoUrl { get; set; }

        /// <summary>
        /// Gets or sets the mapping result.
        /// </summary>
        /// <value>
        /// The mapping result.
        /// </value>
        [JsonPropertyName("mappingResult")] public MappingResult MappingResult { get; set; }

        /// <summary>
        /// Gets or sets the release weight.
        /// </summary>
        /// <value>
        /// The release weight.
        /// </value>
        [JsonPropertyName("releaseWeight")] public long ReleaseWeight { get; set; }

        /// <summary>
        /// Gets or sets the suspected movie identifier.
        /// </summary>
        /// <value>
        /// The suspected movie identifier.
        /// </value>
        [JsonPropertyName("suspectedMovieId")] public long SuspectedMovieId { get; set; }

        /// <summary>
        /// Gets or sets the indexer flags.
        /// </summary>
        /// <value>
        /// The indexer flags.
        /// </value>
        [JsonPropertyName("indexerFlags")] public List<string> IndexerFlags { get; set; }

        /// <summary>
        /// Gets or sets the magnet URL.
        /// </summary>
        /// <value>
        /// The magnet URL.
        /// </value>
        [JsonPropertyName("magnetUrl")] public string MagnetUrl { get; set; }

        /// <summary>
        /// Gets or sets the information hash.
        /// </summary>
        /// <value>
        /// The information hash.
        /// </value>
        [JsonPropertyName("infoHash")] public string InfoHash { get; set; }

        /// <summary>
        /// Gets or sets the seeders.
        /// </summary>
        /// <value>
        /// The seeders.
        /// </value>
        [JsonPropertyName("seeders")] public int Seeders { get; set; }

        /// <summary>
        /// Gets or sets the leechers.
        /// </summary>
        /// <value>
        /// The leechers.
        /// </value>
        [JsonPropertyName("leechers")] public int Leechers { get; set; }

        /// <summary>
        /// Gets or sets the protocol.
        /// </summary>
        /// <value>
        /// The protocol.
        /// </value>
        [JsonPropertyName("protocol")] public Protocol Protocol { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is daily.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is daily; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("isDaily")] public bool IsDaily { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is absolute numbering.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is absolute numbering; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("isAbsoluteNumbering")] public bool IsAbsoluteNumbering { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is possible special episode.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is possible special episode; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("isPossibleSpecialEpisode")] public bool IsPossibleSpecialEpisode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Release"/> is special.
        /// </summary>
        /// <value>
        ///   <c>true</c> if special; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("special")] public bool Special { get; set; }

        /// <summary>
        /// Gets or sets the release group.
        /// </summary>
        /// <value>
        /// The release group.
        /// </value>
        [JsonPropertyName("releaseGroup")] public string ReleaseGroup { get; set; }
    }
}
