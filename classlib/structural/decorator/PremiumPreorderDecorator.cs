namespace classlib.structural.decorator
{
    public class PremiumPreOrderDecorator : OrderDecorator
    {
        public PremiumPreOrderDecorator(BaseOrder baseOrderComponent) : base(baseOrderComponent) {}

        public override double CalculateTotalOrderPrice()
        {
            double preOrderPrice = base.CalculateTotalOrderPrice();
            return preOrderPrice * 0.9;
        }
    }
}