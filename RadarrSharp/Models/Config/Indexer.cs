
using System.Text.Json.Serialization;

namespace RadarrSharp.Models.Config
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Indexer
    {
        /// <summary>
        /// Gets or sets the minimum age.
        /// </summary>
        /// <value>
        /// The minimum age.
        /// </value>
        [JsonPropertyName("minimumAge")] public long MinimumAge { get; set; }

        /// <summary>
        /// Gets or sets the maximum size.
        /// </summary>
        /// <value>
        /// The maximum size.
        /// </value>
        [JsonPropertyName("maximumSize")] public long MaximumSize { get; set; }

        /// <summary>
        /// Gets or sets the retention.
        /// </summary>
        /// <value>
        /// The retention.
        /// </value>
        [JsonPropertyName("retention")] public long Retention { get; set; }

        /// <summary>
        /// Gets or sets the RSS synchronize interval.
        /// </summary>
        /// <value>
        /// The RSS synchronize interval.
        /// </value>
        [JsonPropertyName("rssSyncInterval")] public long RssSyncInterval { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [prefer indexer flags].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [prefer indexer flags]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("preferIndexerFlags")] public bool PreferIndexerFlags { get; set; }

        /// <summary>
        /// Gets or sets the availability delay.
        /// </summary>
        /// <value>
        /// The availability delay.
        /// </value>
        [JsonPropertyName("availabilityDelay")] public long AvailabilityDelay { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow hardcoded subs].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow hardcoded subs]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("allowHardcodedSubs")] public bool AllowHardcodedSubs { get; set; }

        /// <summary>
        /// Gets or sets the whitelisted hardcoded subs.
        /// </summary>
        /// <value>
        /// The whitelisted hardcoded subs.
        /// </value>
        [JsonPropertyName("whitelistedHardcodedSubs")] public string WhitelistedHardcodedSubs { get; set; }

        /// <summary>
        /// Gets or sets the parsing leniency.
        /// </summary>
        /// <value>
        /// The parsing leniency.
        /// </value>
        [JsonPropertyName("parsingLeniency")] public string ParsingLeniency { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonPropertyName("id")] public long Id { get; set; }
    }
}
