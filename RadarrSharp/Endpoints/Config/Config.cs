using RadarrSharp.Helpers;

using System.Text.Json;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Config
{
    /// <summary>
    /// Config endpoint client
    /// </summary>
    /// <seealso cref="RadarrSharp.Endpoints.Config.IConfig" />
    public class Config : IConfig
    {
        private readonly RadarrClient _radarrClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="Config" /> class.
        /// </summary>
        /// <param name="radarrClient">The radarr client.</param>
        public Config(RadarrClient radarrClient)
        {
            _radarrClient = radarrClient;
        }

        /// <summary>
        /// Gets the download client configuration.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Config.DownloadClient> GetDownloadClientConfig()
        {
            var json = await _radarrClient.ProcessJson("GET", $"/config/downloadClient");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Config.DownloadClient>(json, ObjectConverter.Settings));
        }

        /// <summary>
        /// Gets the host configuration.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Config.Host> GetHostConfig()
        {
            var json = await _radarrClient.ProcessJson("GET", $"/config/host");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Config.Host>(json, ObjectConverter.Settings));
        }

        /// <summary>
        /// Gets the indexer configuration.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Config.Indexer> GetIndexerConfig()
        {
            var json = await _radarrClient.ProcessJson("GET", $"/config/indexer");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Config.Indexer>(json, ObjectConverter.Settings));
        }

        /// <summary>
        /// Gets the media management configuration.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Config.MediaManagement> GetMediaManagementConfig()
        {
            var json = await _radarrClient.ProcessJson("GET", $"/config/mediaManagement");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Config.MediaManagement>(json, ObjectConverter.Settings));
        }

        /// <summary>
        /// Gets the naming configuration.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Config.Naming> GetNamingConfig()
        {
            var json = await _radarrClient.ProcessJson("GET", $"/config/naming");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Config.Naming>(json, ObjectConverter.Settings));
        }

        /// <summary>
        /// Gets the net import configuration.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Config.NetImport> GetNetImportConfig()
        {
            var json = await _radarrClient.ProcessJson("GET", $"/config/netImport");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Config.NetImport>(json, ObjectConverter.Settings));
        }

        /// <summary>
        /// Gets the UI configuration.
        /// </summary>
        /// <returns></returns>
        public async Task<Models.Config.Ui> GetUiConfig()
        {
            var json = await _radarrClient.ProcessJson("GET", $"/config/ui");
            return await Task.Run(() => JsonSerializer.Deserialize<Models.Config.Ui>(json, ObjectConverter.Settings));
        }
    }
}
