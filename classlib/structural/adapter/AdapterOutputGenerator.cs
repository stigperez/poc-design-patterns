using System;
using System.Collections.Generic;

namespace classlib.structural.adapter
{
    /*
    * The purpose of the adapter pattern is to make two different implementations work together
    * The adapter class is the basic principle; inherit from one interface and keep a reference to the other interface implementation
    * Other variations include a stand-alone adapter class with references to two incompatible interfaces
    */
    public class AdapterOutputGenerator : BaseOutputGenerator
    {
        public override string GetOutput()
        {
            var data = new List<CarManufacturer>
            {
                new CarManufacturer {Name = "Alfa Romeo", Country = "Italy", Year = 2016},
                new CarManufacturer {Name = "Aston Martin", Country = "UK", Year = 2018},
                new CarManufacturer {Name = "Dodge", Country = "USA", Year = 2017},
                new CarManufacturer {Name = "Subary", Country = "Japan", Year = 2016},
                new CarManufacturer {Name = "BMW", Country = "Germany", Year = 2015}
            };
            var adapter = new Adapter(new JsonConverter());
            var convertedData = adapter.GetXml(data);
            string output = convertedData.ToString();
            return output;
        }
    }
}