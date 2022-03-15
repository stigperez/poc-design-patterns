namespace classlib.creational.facetedbuilder
{
    public class FacetedBuilderOutputGenerator : BaseOutputGenerator
    {
        public override string GetOutput()
        {
            var car = new CarBuilderFacade()
                .CarInfoBuilder
                    .SetType("Hyundai")
                    .SetColor("Phantom Black")
                    .SetNumberOfDoors(4)
                .CarLocationBuilder
                    .SetAddress("Bakkekammen 154")
                    .SetCity("Frederikssund")
            .Build();
            return car.ToString();
        }
    }
}