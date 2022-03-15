namespace classlib.creational.facetedbuilder
{
    public class CarLocationBuilder : CarBuilderFacade
    {
        public CarLocationBuilder(Car car)
        {
            Car = car;
        }

        public CarLocationBuilder SetAddress(string address)
        {
            Car.Address = address;
            return this;
        }

        public CarLocationBuilder SetCity(string city)
        {
            Car.City = city;
            return this;
        }
    }
}