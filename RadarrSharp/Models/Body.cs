﻿using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Body
    {
        /// <summary>
        /// Gets or sets a value indicating whether [send updates to client].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [send updates to client]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("sendUpdatesToClient")] public bool SendUpdatesToClient { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [update scheduled task].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [update scheduled task]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("updateScheduledTask")] public bool UpdateScheduledTask { get; set; }

        /// <summary>
        /// Gets or sets the completion message.
        /// </summary>
        /// <value>
        /// The completion message.
        /// </value>
        [JsonPropertyName("completionMessage")] public string CompletionMessage { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonPropertyName("name")] public string Name { get; set; }

        /// <summary>
        /// Gets or sets the trigger.
        /// </summary>
        /// <value>
        /// The trigger.
        /// </value>
        [JsonPropertyName("trigger")] public string Trigger { get; set; }
    }
}
