namespace classlib.creational.builder
{
    public class ProductStockReportDirector
    {
        private readonly IProductStockReportBuilder _builder;
        public ProductStockReportDirector(IProductStockReportBuilder builder)
        {
            _builder = builder;
        }

        public void BuildReport()
        {
            _builder.BuildReportHeader();
            _builder.BuildReportBody();
            _builder.BuildReportFooter();
        }
    }
}