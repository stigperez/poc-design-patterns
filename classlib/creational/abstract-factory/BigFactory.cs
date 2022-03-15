using System;

namespace classlib.creational.abstractfactory
{
    public class BigFactory : AbstractFactory
    {
        public override Transportation CreateTransportation()
        {
            return new Truck { Model = "Volvo", Type = "650", Year = 2005 };
        }

        public override Trailer CreateTrailer()
        {
            return new Horsetrailer { Type = "Riley", IsClosed = true, NumberOfWheels = 4, Capacity = 23000 };
        }
    }
}