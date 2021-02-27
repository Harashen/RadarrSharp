using RadarrSharp.Helpers;

using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Release
{
    /// <summary>
    /// Release endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.Release.IRelease" />
    public class Release : IRelease
    {
        private readonly RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Release"/> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Release(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets releases from Radarr's search cache (30 minute cache)
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.Release>> GetReleases()
        {
            var json = await _radarrClient.ProcessJson("GET", $"/release");
            return await Task.Run(() => JsonSerializer.Deserialize<IList<Models.Release>>(json, ObjectConverter.Settings));
        }

        /// <summary>
        /// Adds a previously searched release to the download client, if the release is still in Radarr's search cache (30 minute cache)
        /// </summary>
        /// <param name="guid">Release GUID</param>
        /// <returns></returns>
        public async Task<IList<Models.Release>> AddRelease(string guid)
        {
            string parameter = JsonSerializer.Serialize(new Dictionary<string, object>
            {
                ["guid"] = guid
            });

            var json = await _radarrClient.ProcessJson("POST", $"/release", parameter);
            return await Task.Run(() => JsonSerializer.Deserialize<IList<Models.Release>>(json, ObjectConverter.Settings));
        }
    }
}
