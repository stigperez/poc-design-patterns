namespace classlib.structural.composite
{
    public class SingleGift : BaseGift
    {
        public SingleGift(string name, double price) : base(name, price) {}

        public override double CalculateTotalPrice()
        {
            return Price;
        }
    }
}