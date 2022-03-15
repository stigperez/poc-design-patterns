using System;

namespace classlib.creational.abstractfactory
{
    public class SmallFactory : AbstractFactory
    {
        public override Transportation CreateTransportation()
        {
            return new Car { Model = "Hyundai", Type = "I20", Year = 2019 };
        }
        public override Trailer CreateTrailer()
        {
            return new GoodsTrailer { Type = "Berger", Capacity = 500, IsClosed = false, NumberOfWheels = 4 };
        }
    }
}