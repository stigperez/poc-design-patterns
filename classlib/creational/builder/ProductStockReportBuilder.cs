using System;
using System.Collections.Generic;
using System.Linq;

namespace classlib.creational.builder
{
    public class ProductStockReportBuilder : IProductStockReportBuilder
    {
        private ProductStockReport _productStockReport;
        private readonly IEnumerable<Product> _products;

        public ProductStockReportBuilder(IEnumerable<Product> products)
        {
            _productStockReport = new ProductStockReport();
            _products = products ?? throw new ArgumentNullException(nameof(products));
        }

        public void BuildReportHeader()
        {
            _productStockReport.HeaderPart = $"stock report for all products at {DateTime.Now.ToShortDateString()}".ToUpper();
        }
        public void BuildReportBody()
        {
            _productStockReport.BodyPart = string.Join(Environment.NewLine, _products.Select(product => $"Product name: {product.Name}, Product price: {product.Price}"));
        }

        public void BuildReportFooter()
        {
            _productStockReport.FooterPart = "end of report".ToUpper();
        }

        public ProductStockReport GetReport()
        {
            return _productStockReport;
        }
    }
}