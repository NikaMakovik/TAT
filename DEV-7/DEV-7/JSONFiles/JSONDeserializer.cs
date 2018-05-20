using System.Collections.Generic;
using Newtonsoft.Json;

namespace DEV_7
{
    /// <summary>
    /// Deserialize objects from json files.
    /// </summary>
    public class JSONDeserializer
    {
        public string wayToFile;
        List<Options> deserializedListOfOptions;

        public JSONDeserializer(string wayToFile)
        {
            this.wayToFile = wayToFile;
            deserializedListOfOptions = JsonConvert.DeserializeObject<List<Options>>(wayToFile);
        }
        /// <summary>
        /// Gets deserialized list of options.
        /// </summary>
        /// <returns>List of options.</returns>
        public List<Options> GetDeserializedOptions()
        {
            return deserializedListOfOptions;
        }
    }
}
