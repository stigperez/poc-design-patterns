namespace classlib.structural.composite
{
    public abstract class BaseGift
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public BaseGift(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract double CalculateTotalPrice();
    }
}