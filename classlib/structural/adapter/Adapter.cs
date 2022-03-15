using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace classlib.structural.adapter
{
    public class Adapter : IXmlConverter
    {
        private readonly JsonConverter _jsonConverter;

        public Adapter(JsonConverter jsonConverter)
        {
            _jsonConverter = jsonConverter;
        }

        public XDocument GetXml(IEnumerable<CarManufacturer> data)
        {
            var jsonString = _jsonConverter.GetJson(data);
            var json = JsonConvert.DeserializeObject<IEnumerable<CarManufacturer>>(jsonString);
            var xDocument = new XDocument();
            var xElement = new XElement("CarManufacturers");
            var xAttributes = json.Select(d => new XElement(nameof(CarManufacturer), new XAttribute("Name", d.Name), new XAttribute("Country", d.Country), new XAttribute("Year", d.Year)));
            xElement.Add(xAttributes);
            xDocument.Add(xElement);
            return xDocument;
        }
    }
}