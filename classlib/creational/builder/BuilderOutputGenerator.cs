using System.Collections.Generic;

namespace classlib.creational.builder
{
    public class BuilderOutputGenerator : BaseOutputGenerator
    {
        public override string GetOutput()
        {
            var products = new List<Product>
            {
                new Product {Name = "Product 1", Price = 1},
                new Product {Name = "Product 2", Price = 2},
                new Product {Name = "Product 3", Price = 3}
            };
            var builder = new ProductStockReportBuilder(products);
            var director = new ProductStockReportDirector(builder);
            director.BuildReport();
            var report = builder.GetReport();
            
            return report.ToString();
        }
    }
}