using RadarrSharp.Helpers;

using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Notification
{
    /// <summary>
    /// Notification endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.Notification.INotification" />
    public class Notification : INotification
    {
        private readonly RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Notification(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Returns all configured notification agents
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.Notification>> GetNotificationAgents()
        {
            var json = await _radarrClient.ProcessJson("GET", "/notification");
            return await Task.Run(() => JsonSerializer.Deserialize<IList<Models.Notification>>(json, ObjectConverter.Settings));
        }
    }
}
