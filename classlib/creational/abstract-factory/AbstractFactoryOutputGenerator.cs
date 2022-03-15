using System;
using System.Collections.Generic;
using System.Text;

namespace classlib.creational.abstractfactory
{
    public class AbstractFactoryOutputGenerator : BaseOutputGenerator
    {
        public override string GetOutput()
        {
            AbstractFactory smallFactory = new SmallFactory();
            AbstractFactory bigFactory = new BigFactory();

            // consider extracting the factory initialization into a client class
            Trailer smallFactoryTrailer = smallFactory.CreateTrailer();
            Transportation smallFactoryTransportation = smallFactory.CreateTransportation();

            Trailer bigFactoryTrailer = bigFactory.CreateTrailer();
            Transportation bigFactoryTransportation = bigFactory.CreateTransportation();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Created {smallFactoryTransportation.Model} with {smallFactoryTrailer.Type}");
            stringBuilder.AppendLine($"Created {bigFactoryTransportation.Model} with {bigFactoryTrailer.Type}");
            return stringBuilder.ToString();
        }
    }
}