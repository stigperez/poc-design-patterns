using System.Collections.Generic;
using System.Text;

namespace classlib.structural.decorator
{
    public class DecoratorOutputGenerator : BaseOutputGenerator
    {
        /*
        * The purpose of the decorator pattern is to "append/decorate" new behavior to a basic object
        * Instead of using inheritance (compile time) you can append new behavior to a minimal object (runtime)
        * The idea is to append new behavior by passing in the object to be decorated into the decorator class
        * Note that the order of decorators is important and may or may not be desireable
        */
        public override string GetOutput()
        {
            StringBuilder stringBuilder = new StringBuilder();
            var products = new List<Product>
            {
                new Product {Name = "Product 1", Price = 1},
                new Product {Name = "Product 2", Price = 2},
                new Product {Name = "Product 3", Price = 3},
            };
            var regularOrder = new RegularOrder(products);
            stringBuilder.AppendLine($"Regular order total: {regularOrder.CalculateTotalOrderPrice()}");

            var preorder = new PreorderDecorator(regularOrder);
            stringBuilder.AppendLine($"Pre-order total: {preorder.CalculateTotalOrderPrice()}");

            var premiumPreorder = new PremiumPreOrderDecorator(preorder);
            stringBuilder.AppendLine($"Premium pre-order total: {premiumPreorder.CalculateTotalOrderPrice()}");

            return stringBuilder.ToString();
        }
    }
}