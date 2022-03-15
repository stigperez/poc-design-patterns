namespace classlib.structural.decorator
{
    public class PreorderDecorator : OrderDecorator
    {
        public PreorderDecorator(BaseOrder baseOrderComponent) : base(baseOrderComponent) {}
        public override double CalculateTotalOrderPrice()
        {
            double baseOrderprice = base.CalculateTotalOrderPrice();
            return baseOrderprice * 0.9;
        }
    }
}