using System;

namespace classlib.creational.abstractfactory
{
    public abstract class AbstractFactory
    {
        public abstract Transportation CreateTransportation();
        public abstract Trailer CreateTrailer();
    }
}