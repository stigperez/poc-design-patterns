namespace classlib.behavioral.observer
{
    public class CompanyObserver : Observer
    {
        public string Name { get; set; }
        public StockSubject StockSubject { get; set; }
        public double TotalStockValue { get; set; }
        public CompanyObserver(StockSubject stockSubject)
        {
            StockSubject = stockSubject;
        }
        public override bool Update()
        {
            TotalStockValue = StockSubject.Value;
            return true;
        }
    }
}