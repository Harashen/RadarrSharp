using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class History
    {
        /// <summary>
        /// Gets or sets the page.
        /// </summary>
        /// <value>
        /// The page.
        /// </value>
        [JsonPropertyName("page")] public int Page { get; set; }

        /// <summary>
        /// Gets or sets the size of the page.
        /// </summary>
        /// <value>
        /// The size of the page.
        /// </value>
        [JsonPropertyName("pageSize")] public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the sort key.
        /// </summary>
        /// <value>
        /// The sort key.
        /// </value>
        [JsonPropertyName("sortKey")] public string SortKey { get; set; }

        /// <summary>
        /// Gets or sets the sort direction.
        /// </summary>
        /// <value>
        /// The sort direction.
        /// </value>
        [JsonPropertyName("sortDirection")] public string SortDirection { get; set; }

        /// <summary>
        /// Gets or sets the total records.
        /// </summary>
        /// <value>
        /// The total records.
        /// </value>
        [JsonPropertyName("totalRecords")] public int TotalRecords { get; set; }

        /// <summary>
        /// Gets or sets the records.
        /// </summary>
        /// <value>
        /// The records.
        /// </value>
        [JsonPropertyName("records")] public List<Record> Records { get; set; }
    }
}
