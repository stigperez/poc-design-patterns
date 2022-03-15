using System.Collections.Generic;
using System.Text;

namespace classlib.structural.facade
{
    public class FacadeOutputGenerator : BaseOutputGenerator
    {
        public override string GetOutput()
        {
            var output = new StringBuilder();
            var restaurant = new Restaurant();
            var shippingService = new ShippingService();

            var facade = new Facade(restaurant, shippingService);
            var chickenOrder = new Order {DishName = "Chicken", DishPrice = 20.0M, Username = "John Doe", ShippingAddress = "John Doe Street 1"};
            var sushiOrder = new Order {DishName = "Sushi", DishPrice = 52.0M, Username = "John Doe", ShippingAddress = "John Doe Street 1"};
            var orders = new List<Order> { chickenOrder, sushiOrder };

            var receip = facade.OrderFood(orders);
            output.Append(receip);
            return output.ToString();
        }
    }
}