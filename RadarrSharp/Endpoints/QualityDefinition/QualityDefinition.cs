using RadarrSharp.Helpers;

using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.QualityDefinition
{
    /// <summary>
    /// QualityDefinition endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.QualityDefinition.IQualityDefinition" />
    public class QualityDefinition : IQualityDefinition
    {
        private RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityDefinition"/> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public QualityDefinition(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Returns all quality definitions
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Models.QualityDefinition>> GetQualityDefinitions()
        {
            var json = await _radarrClient.ProcessJson("GET", "/qualityDefinition");
            return await Task.Run(() => JsonSerializer.Deserialize<IList<Models.QualityDefinition>>(json, ObjectConverter.Settings));
        }

        /// <summary>
        /// Returns specific quality definition based on given id
        /// </summary>
        /// <returns></returns>
        public async Task<Models.QualityDefinition> GetQualityDefinition(int id)
        {
            var json = await _radarrClient.ProcessJson("GET", $"/qualityDefinition/id={id}");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.QualityDefinition>(json, ObjectConverter.Settings));
        }

        /// <summary>
        /// Update an existing quality definition
        /// </summary>
        /// <param name="qualityDefinition">QualityDefinition to update - Requires all properties of Models.QualityDefinition object</param>
        /// <returns></returns>
        public async Task<Models.QualityDefinition> UpdateQualityDefinition(Models.QualityDefinition qualityDefinition)
        {
            var json = await _radarrClient.ProcessJson("PUT", "/qualityDefinition", JsonSerializer.Serialize(qualityDefinition, ObjectConverter.Settings));
            return await Task.Run(() => JsonSerializer.Deserialize<Models.QualityDefinition>(json, ObjectConverter.Settings));
        }
    }
}
