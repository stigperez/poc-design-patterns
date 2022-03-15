using System.Collections.Generic;
using Newtonsoft.Json;

namespace classlib.structural.adapter
{
    public class JsonConverter
    {
        public string GetJson(IEnumerable<CarManufacturer> data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            return json;
        }
    }
}