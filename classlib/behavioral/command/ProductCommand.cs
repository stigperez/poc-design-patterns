namespace classlib.behavioral.command
{
    public class ProductCommand : ICommand
    {
        private ProductReceiver _productReceiver;
        private PriceAction _priceAction;
        private double _amount;
        public ProductCommand(ProductReceiver productReceiver, PriceAction priceAction, double amount)
        {
            _productReceiver = productReceiver;
            _priceAction = priceAction;
            _amount = amount;
        }

        public CommandResult ExecuteCommand()
        {
            switch(_priceAction)
            {
                case PriceAction.Increase:
                {
                    return _productReceiver.IncreasePrice(_amount);
                }
                case PriceAction.Decrese:
                {
                    return _productReceiver.DecreasePrice(_amount);
                }
            }
            return new CommandResult {IsSuccessful = false, NewPrice = _amount };
        }

        public CommandResult UndoCommand()
        {
            if(_priceAction == PriceAction.Increase)
            {
                return _productReceiver.DecreasePrice(_amount);
            }
            else
            {
                return _productReceiver.IncreasePrice(_amount);
            }
        }
    }
}