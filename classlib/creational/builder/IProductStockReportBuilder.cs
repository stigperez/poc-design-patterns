namespace classlib.creational.builder
{
    public interface IProductStockReportBuilder
    {
        void BuildReportHeader();
        void BuildReportBody();
        void BuildReportFooter();
        ProductStockReport GetReport();
    }
}