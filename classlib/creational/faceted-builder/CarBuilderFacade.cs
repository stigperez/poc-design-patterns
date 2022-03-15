namespace classlib.creational.facetedbuilder
{
    public class CarBuilderFacade
    {
        protected Car Car {get; set;}

        public CarBuilderFacade()
        {
            Car = new Car();
        }

        public Car Build() => Car;
        public CarInfoBuilder CarInfoBuilder => new CarInfoBuilder(Car);
        public CarLocationBuilder CarLocationBuilder => new CarLocationBuilder(Car);
    }
}