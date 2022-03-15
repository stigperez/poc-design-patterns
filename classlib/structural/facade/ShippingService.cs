namespace classlib.structural.facade
{
    public class ShippingService
    {
        private Order _order;

        public void AcceptOrder(Order order) => _order = order;

        public void CalculateShippingExpense() => _order.ShippingPrice = 15.5M;

        public string ShipOrder() => "Order is being shipped";
    }
}