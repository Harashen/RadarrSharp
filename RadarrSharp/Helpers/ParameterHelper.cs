using System.Collections.Generic;
using System.Linq;

namespace RadarrSharp.Helpers
{
    internal class ParameterHelper
    {
        /// <summary>
        /// Builds the parameter string.
        /// </summary>
        /// <param name="keyValuePairs">The key value pairs.</param>
        /// <returns></returns>
        internal static string BuildParameterString(Dictionary<string, object> keyValuePairs)
        {
            if (keyValuePairs.Count == 0) return null;

            return "?" + string.Join("&", keyValuePairs.Select(pair => pair.Key + "=" + pair.Value));
        }
    }
}
