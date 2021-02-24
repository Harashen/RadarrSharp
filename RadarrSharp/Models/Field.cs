using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Field
    {
        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>
        /// The order.
        /// </value>
        [JsonPropertyName("order")] public int Order { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonPropertyName("name")] public string Name { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        [JsonPropertyName("label")] public string Label { get; set; }

        /// <summary>
        /// Gets or sets the help link.
        /// </summary>
        /// <value>
        /// The help link.
        /// </value>
        [JsonPropertyName("helpLink")] public string HelpLink { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonPropertyName("value")] public Value? Value { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonPropertyName("type")] public string Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Field"/> is advanced.
        /// </summary>
        /// <value>
        ///   <c>true</c> if advanced; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("advanced")] public bool Advanced { get; set; }

        /// <summary>
        /// Gets or sets the help text.
        /// </summary>
        /// <value>
        /// The help text.
        /// </value>
        [JsonPropertyName("helpText")] public string HelpText { get; set; }

        /// <summary>
        /// Gets or sets the select options.
        /// </summary>
        /// <value>
        /// The select options.
        /// </value>
        [JsonPropertyName("selectOptions")] public List<SelectOption> SelectOptions { get; set; }
    }
}
