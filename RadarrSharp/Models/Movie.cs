using RadarrSharp.Enums;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Movie
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonPropertyName("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the alternative titles.
        /// </summary>
        /// <value>
        /// The alternative titles.
        /// </value>
        [JsonPropertyName("alternativeTitles")] public List<AlternativeTitle> AlternativeTitles { get; set; }

        /// <summary>
        /// Gets or sets the secondary year source identifier.
        /// </summary>
        /// <value>
        /// The secondary year source identifier.
        /// </value>
        [JsonPropertyName("secondaryYearSourceId")] public int SecondaryYearSourceId { get; set; }

        /// <summary>
        /// Gets or sets the sort title.
        /// </summary>
        /// <value>
        /// The sort title.
        /// </value>
        [JsonPropertyName("sortTitle")] public string SortTitle { get; set; }

        /// <summary>
        /// Gets or sets the size on disk.
        /// </summary>
        /// <value>
        /// The size on disk.
        /// </value>
        [JsonPropertyName("sizeOnDisk")] public long SizeOnDisk { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [JsonPropertyName("status")] public Status Status { get; set; }

        /// <summary>
        /// Gets or sets the overview.
        /// </summary>
        /// <value>
        /// The overview.
        /// </value>
        [JsonPropertyName("overview")] public string Overview { get; set; }

        /// <summary>
        /// Gets or sets the in cinemas.
        /// </summary>
        /// <value>
        /// The in cinemas.
        /// </value>
        [JsonPropertyName("inCinemas")] public DateTimeOffset? InCinemas { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        [JsonPropertyName("images")] public List<Image> Images { get; set; }

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        /// <value>
        /// The website.
        /// </value>
        [JsonPropertyName("website")] public string Website { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Movie" /> is downloaded.
        /// </summary>
        /// <value>
        ///   <c>true</c> if downloaded; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("downloaded")] public bool Downloaded { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        [JsonPropertyName("year")] public int Year { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has file.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has file; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("hasFile")] public bool HasFile { get; set; }

        /// <summary>
        /// Gets or sets you tube trailer identifier.
        /// </summary>
        /// <value>
        /// You tube trailer identifier.
        /// </value>
        [JsonPropertyName("youTubeTrailerId")] public string YouTubeTrailerId { get; set; }

        /// <summary>
        /// Gets or sets the studio.
        /// </summary>
        /// <value>
        /// The studio.
        /// </value>
        [JsonPropertyName("studio")] public string Studio { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        [JsonPropertyName("path")] public string Path { get; set; }

        /// <summary>
        /// Gets or sets the profile identifier.
        /// </summary>
        /// <value>
        /// The profile identifier.
        /// </value>
        [JsonPropertyName("profileId")] public int ProfileId { get; set; }

        /// <summary>
        /// Gets or sets the state of the path.
        /// </summary>
        /// <value>
        /// The state of the path.
        /// </value>
        [JsonPropertyName("pathState")] public PathState PathState { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Movie"/> is monitored.
        /// </summary>
        /// <value>
        ///   <c>true</c> if monitored; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("monitored")] public bool Monitored { get; set; }

        /// <summary>
        /// Gets or sets the minimum availability.
        /// </summary>
        /// <value>
        /// The minimum availability.
        /// </value>
        [JsonPropertyName("minimumAvailability")] public MinimumAvailability MinimumAvailability { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is available.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is available; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("isAvailable")] public bool IsAvailable { get; set; }

        /// <summary>
        /// Gets or sets the name of the folder.
        /// </summary>
        /// <value>
        /// The name of the folder.
        /// </value>
        [JsonPropertyName("folderName")] public string FolderName { get; set; }

        /// <summary>
        /// Gets or sets the runtime.
        /// </summary>
        /// <value>
        /// The runtime.
        /// </value>
        [JsonPropertyName("runtime")] public int Runtime { get; set; }

        /// <summary>
        /// Gets or sets the last information synchronize.
        /// </summary>
        /// <value>
        /// The last information synchronize.
        /// </value>
        [JsonPropertyName("lastInfoSync")] public DateTimeOffset LastInfoSync { get; set; }

        /// <summary>
        /// Gets or sets the clean title.
        /// </summary>
        /// <value>
        /// The clean title.
        /// </value>
        [JsonPropertyName("cleanTitle")] public string CleanTitle { get; set; }

        /// <summary>
        /// Gets or sets the imdb identifier.
        /// </summary>
        /// <value>
        /// The imdb identifier.
        /// </value>
        [JsonPropertyName("imdbId")] public string ImdbId { get; set; }

        /// <summary>
        /// Gets or sets the TMDB identifier.
        /// </summary>
        /// <value>
        /// The TMDB identifier.
        /// </value>
        [JsonPropertyName("tmdbId")] public long TmdbId { get; set; }

        /// <summary>
        /// Gets or sets the title slug.
        /// </summary>
        /// <value>
        /// The title slug.
        /// </value>
        [JsonPropertyName("titleSlug")] public string TitleSlug { get; set; }

        /// <summary>
        /// Gets or sets the genres.
        /// </summary>
        /// <value>
        /// The genres.
        /// </value>
        [JsonPropertyName("genres")] public List<object> Genres { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>
        /// The tags.
        /// </value>
        [JsonPropertyName("tags")] public List<object> Tags { get; set; }

        /// <summary>
        /// Gets or sets the added.
        /// </summary>
        /// <value>
        /// The added.
        /// </value>
        [JsonPropertyName("added")] public DateTimeOffset Added { get; set; }

        /// <summary>
        /// Gets or sets the ratings.
        /// </summary>
        /// <value>
        /// The ratings.
        /// </value>
        [JsonPropertyName("ratings")] public Ratings Ratings { get; set; }

        /// <summary>
        /// Gets or sets the quality profile identifier.
        /// </summary>
        /// <value>
        /// The quality profile identifier.
        /// </value>
        [JsonPropertyName("qualityProfileId")] public int QualityProfileId { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")] public int Id { get; set; }

        /// <summary>
        /// Gets or sets the movie file.
        /// </summary>
        /// <value>
        /// The movie file.
        /// </value>
        [JsonPropertyName("movieFile")] public MovieFile MovieFile { get; set; }

        /// <summary>
        /// Gets or sets the physical release.
        /// </summary>
        /// <value>
        /// The physical release.
        /// </value>
        [JsonPropertyName("physicalRelease")] public DateTimeOffset? PhysicalRelease { get; set; }

        /// <summary>
        /// Gets or sets the physical release note.
        /// </summary>
        /// <value>
        /// The physical release note.
        /// </value>
        [JsonPropertyName("physicalReleaseNote")] public string PhysicalReleaseNote { get; set; }

        /// <summary>
        /// Gets or sets the secondary year.
        /// </summary>
        /// <value>
        /// The secondary year.
        /// </value>
        [JsonPropertyName("secondaryYear")] public int? SecondaryYear { get; set; }

        /// <summary>
        /// Gets or sets the remote poster.
        /// </summary>
        /// <value>
        /// The remote poster.
        /// </value>
        [JsonPropertyName("remotePoster")] public string RemotePoster { get; set; }
    }
}
