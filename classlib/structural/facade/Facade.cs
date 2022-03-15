using System.Collections.Generic;
using System.Text;

namespace classlib.structural.facade
{
    public class Facade
    {
        private readonly Restaurant _restaurant;
        private readonly ShippingService _shippingService;

        public Facade(Restaurant restaurant, ShippingService shippingService)
        {
            _restaurant = restaurant;
            _shippingService = shippingService;
        }

        public string OrderFood(List<Order> orders)
        {
            var receip = new StringBuilder();
            orders.ForEach(order => _restaurant.AddOrderToCart(order));
            _restaurant.CompleteOrders();
            orders.ForEach(order => 
            {
                _shippingService.AcceptOrder(order);
                _shippingService.CalculateShippingExpense();
                _shippingService.ShipOrder();
                receip.AppendLine(order.ToString());
            });
            return receip.ToString();
        }
    }
}