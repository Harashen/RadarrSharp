using RadarrSharp.Helpers;

using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Profile
{
    /// <summary>
    /// Profile endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.Profile.IProfile" />
    public class Profile : IProfile
    {
        private readonly RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Profile" /> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Profile(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets all quality profiles
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.Profile>> GetProfiles()
        {
            var json = await _radarrClient.ProcessJson("GET", "/profile");
            return await Task.Run(() => JsonSerializer.Deserialize<IList<Models.Profile>>(json, ObjectConverter.Settings));
        }
    }
}
