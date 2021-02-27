using RadarrSharp.Helpers;

using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Restriction
{
    /// <summary>
    /// Restriction endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.Restriction.IRestriction" />
    public class Restriction : IRestriction
    {
        private readonly RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Restriction"/> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Restriction(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Returns all configured restrictions (must contain, must not contain)
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.Restriction>> GetRestrictions()
        {
            var json = await _radarrClient.ProcessJson("GET", "/restriction");
            return await Task.Run(() => JsonSerializer.Deserialize<IList<Models.Restriction>>(json, ObjectConverter.Settings));
        }

        /// <summary>
        /// Returns specific restriction based on given id (must contain, must not contain)
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Restriction> GetRestriction(int id)
        {
            var json = await _radarrClient.ProcessJson("GET", $"/restriction/id={id}");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Restriction>(json, ObjectConverter.Settings));
        }

        /// <summary>
        /// Update an existing restriction
        /// </summary>
        /// <param name="restriction">Restriction to update - Requires all properties of Models.Restriction object</param>
        /// <returns></returns>
        public async Task<Models.Restriction> UpdateRestriction(Models.Restriction restriction)
        {
            var json = await _radarrClient.ProcessJson("PUT", "/restriction", JsonSerializer.Serialize(restriction, ObjectConverter.Settings));
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Restriction>(json, ObjectConverter.Settings));
        }

        /// <summary>
        /// Add new must contain restriction
        /// </summary>
        /// <param name="required">The required string.</param>
        /// <returns></returns>
        public async Task<Models.Restriction> AddMustContainRestriction(string required)
        {
            var dictionary = new Dictionary<string, object>
            {
                ["required"] = required
            };

            string parameter = JsonSerializer.Serialize(new Dictionary<string, object>(dictionary));

            var json = await _radarrClient.ProcessJson("POST", "/restriction", parameter);
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Restriction>(json, ObjectConverter.Settings));
        }

        /// <summary>
        /// Add new must not contain restriction
        /// </summary>
        /// <param name="ignored">The ignored string.</param>
        /// <returns></returns>
        public async Task<Models.Restriction> AddMustNotContainRestriction(string ignored)
        {
            var dictionary = new Dictionary<string, object>
            {
                ["ignored"] = ignored
            };

            string parameter = JsonSerializer.Serialize(new Dictionary<string, object>(dictionary));

            var json = await _radarrClient.ProcessJson("POST", "/restriction", parameter);
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Restriction>(json, ObjectConverter.Settings));
        }

        /// <summary>
        /// Delete the restriction with the given ID
        /// </summary>
        /// <param name="id">Restriction ID</param>
        /// <returns></returns>
        public async Task DeleteRestriction(int id)
        {
            await _radarrClient.Delete($"/restriction/id={id}");
        }
    }
}
