namespace classlib.structural.decorator
{
    public class OrderDecorator : BaseOrder
    {
        private BaseOrder _baseOrder;
        public OrderDecorator(BaseOrder baseOrder)
        {
            _baseOrder = baseOrder;
        }

        public override double CalculateTotalOrderPrice()
        {
            return _baseOrder.CalculateTotalOrderPrice();
        }
    }
}