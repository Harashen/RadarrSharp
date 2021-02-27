using RadarrSharp.Helpers;

using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.CustomFormat
{
    /// <summary>
    /// Custom Formats endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.CustomFormat.ICustomFormat" />
    public class CustomFormat : ICustomFormat
    {
        private readonly RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFormat"/> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public CustomFormat(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets the custom formats.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.CustomFormat>> GetCustomFormats()
        {
            var json = await _radarrClient.ProcessJson("GET", $"/customFormat");
            return await Task.Run(() => JsonSerializer.Deserialize<IList<Models.CustomFormat>>(json, ObjectConverter.Settings));
        }
    }
}
