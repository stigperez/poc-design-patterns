namespace classlib.creational.facetedbuilder
{
    public class CarInfoBuilder : CarBuilderFacade
    {
        public CarInfoBuilder(Car car)
        {
            Car = car;
        }
        public CarInfoBuilder SetType(string type)
        {
            Car.Type = type;
            return this;
        }

        public CarInfoBuilder SetColor(string color)
        {
            Car.Color = color;
            return this;
        }

        public CarInfoBuilder SetNumberOfDoors(int numberOfDoors)
        {
            Car.NumberOfDoors = numberOfDoors;
            return this;
        }
    }
}