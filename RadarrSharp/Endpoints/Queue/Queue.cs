using RadarrSharp.Helpers;

using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Queue
{
    /// <summary>
    /// Queue endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.Queue.IQueue" />
    public class Queue : IQueue
    {
        private readonly RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Queue"/> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Queue(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets currently downloading info
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.Queue>> GetQueue()
        {
            var json = await _radarrClient.ProcessJson("GET", $"/queue");
            return await Task.Run(() => JsonSerializer.Deserialize<IList<Models.Queue>>(json, ObjectConverter.Settings));
        }

        /// <summary>
        /// Deletes an item from the queue and download client.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="blacklist">if set to <c>true</c> blacklist item after deletion.</param>
        /// <returns></returns>
        public async Task DeleteFromQueue(int id, [Optional] bool blacklist)
        {
            var param = new Dictionary<string, object>
            {
                { "blacklist", blacklist }
            };

            await _radarrClient.Delete($"/queue/id={id}{ParameterHelper.BuildParameterString(param)}");
        }
    }
}
