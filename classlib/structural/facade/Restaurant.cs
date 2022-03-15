using System.Collections.Generic;

namespace classlib.structural.facade
{
    public class Restaurant
    {
        private readonly IList<Order> _cart;

        public Restaurant()
        {
            _cart = new List<Order>();
        }

        public void AddOrderToCart(Order order) => _cart.Add(order);

        public string CompleteOrders() => $"{_cart.Count} orders completed";
    }
}