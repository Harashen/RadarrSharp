using RadarrSharp.Helpers;

using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Diskspace
{
    /// <summary>
    /// Diskspace endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.Diskspace.IDiskspace" />
    public class Diskspace : IDiskspace
    {
        private readonly RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Diskspace" /> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Diskspace(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets information about Diskspace
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.Diskspace>> GetDiskspace()
        {
            var json = await _radarrClient.ProcessJson("GET", "/diskspace");
            return await Task.Run(() => JsonSerializer.Deserialize<IList<Models.Diskspace>>(json, ObjectConverter.Settings));
        }
    }
}
