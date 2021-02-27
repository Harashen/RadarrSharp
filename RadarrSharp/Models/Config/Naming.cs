using System.Text.Json.Serialization;

namespace RadarrSharp.Models.Config
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Naming
    {
        /// <summary>
        /// Gets or sets a value indicating whether [rename episodes].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [rename episodes]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("renameEpisodes")] public bool RenameEpisodes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [replace illegal characters].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [replace illegal characters]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("replaceIllegalCharacters")] public bool ReplaceIllegalCharacters { get; set; }

        /// <summary>
        /// Gets or sets the colon replacement format.
        /// </summary>
        /// <value>
        /// The colon replacement format.
        /// </value>
        [JsonPropertyName("colonReplacementFormat")] public string ColonReplacementFormat { get; set; }

        /// <summary>
        /// Gets or sets the standard movie format.
        /// </summary>
        /// <value>
        /// The standard movie format.
        /// </value>
        [JsonPropertyName("standardMovieFormat")] public string StandardMovieFormat { get; set; }

        /// <summary>
        /// Gets or sets the movie folder format.
        /// </summary>
        /// <value>
        /// The movie folder format.
        /// </value>
        [JsonPropertyName("movieFolderFormat")] public string MovieFolderFormat { get; set; }

        /// <summary>
        /// Gets or sets the multi episode style.
        /// </summary>
        /// <value>
        /// The multi episode style.
        /// </value>
        [JsonPropertyName("multiEpisodeStyle")] public long MultiEpisodeStyle { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [include series title].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [include series title]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("includeSeriesTitle")] public bool IncludeSeriesTitle { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [include episode title].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [include episode title]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("includeEpisodeTitle")] public bool IncludeEpisodeTitle { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [include quality].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [include quality]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("includeQuality")] public bool IncludeQuality { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [replace spaces].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [replace spaces]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("replaceSpaces")] public bool ReplaceSpaces { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")] public long Id { get; set; }
    }
}
