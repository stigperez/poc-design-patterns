using System.Collections.Generic;
using System.Xml.Linq;

namespace classlib.structural.adapter
{
    public interface IXmlConverter
    {
        XDocument GetXml(IEnumerable<CarManufacturer> data);
    }
}