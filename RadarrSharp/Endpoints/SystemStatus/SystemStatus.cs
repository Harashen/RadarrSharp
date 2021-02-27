using RadarrSharp.Helpers;

using System.Text.Json;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.SystemStatus
{
    /// <summary>
    /// SystemStatus endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.SystemStatus.ISystemStatus" />
    public class SystemStatus : ISystemStatus
    {
        private readonly RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemStatus" /> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public SystemStatus(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Returns system status
        /// </summary>
        /// <returns></returns>
        public async Task<Models.SystemStatus> GetSystemStatus()
        {
            var json = await _radarrClient.ProcessJson("GET", "/system/status");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.SystemStatus>(json, ObjectConverter.Settings));
        }
    }
}
