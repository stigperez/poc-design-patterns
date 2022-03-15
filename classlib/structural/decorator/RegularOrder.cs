using System.Collections.Generic;
using System.Linq;

namespace classlib.structural.decorator
{
    public class RegularOrder : BaseOrder
    {
        public RegularOrder(IEnumerable<Product> products)
        {
            Products = products;
        }
        public override double CalculateTotalOrderPrice()
        {
            return Products.Sum(product => product.Price);
        }
    }
}