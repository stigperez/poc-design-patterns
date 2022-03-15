using System.Collections.Generic;
using System.Text;

namespace classlib.structural.facade
{
    /*
    * The purpose of the facade pattern is to offer the client a simple entry point to a complex and/or poorly designed module/framework/app
    * Be aware not to turn the facade class into a "God object"
    */
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