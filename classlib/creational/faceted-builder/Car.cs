namespace classlib.creational.facetedbuilder
{
    public class Car
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        
        public override string ToString()
        {
            return $"Type: {Type}, Color: {Color}, NumberOfDoors: {NumberOfDoors}, Address: {Address}, City: {City}";
        }
    }
}