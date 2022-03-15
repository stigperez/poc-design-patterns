using System.Collections.Generic;

namespace classlib.structural.decorator
{
    public abstract class BaseOrder
    {
        protected IEnumerable<Product> Products { get; set; }

        public abstract double CalculateTotalOrderPrice();
    }
}