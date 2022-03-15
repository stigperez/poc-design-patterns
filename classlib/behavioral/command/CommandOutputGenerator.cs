using System.Text;

namespace classlib.behavioral.command
{
    public class CommandOutputGenerator : BaseOutputGenerator
    {
        public override string GetOutput()
        {
            var productReceiver = new ProductReceiver
            {
                Name = "Product 1",
                Price = 1
            };
            var productInvoker = new ProductInvoker();
            var increasePriceProductCommand = new ProductCommand(productReceiver, PriceAction.Increase, 100);
            productInvoker.CurrentProductCommand = increasePriceProductCommand;
            var commandResult = productInvoker.Invoke();
            var newPrice = commandResult.NewPrice;

            increasePriceProductCommand = new ProductCommand(productReceiver, PriceAction.Increase, 50);
            productInvoker.CurrentProductCommand = increasePriceProductCommand;
            commandResult = productInvoker.Invoke();
            newPrice = commandResult.NewPrice;

            var decreasePriceProductCommand = new ProductCommand(productReceiver, PriceAction.Decrese, 25000);
            productInvoker.CurrentProductCommand = decreasePriceProductCommand;
            commandResult = productInvoker.Invoke();
            newPrice = commandResult.NewPrice;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Price of product after updates: {newPrice}");
            var undoCommandResult = productInvoker.Undo();
            stringBuilder.AppendLine($"Price of products after undo: {undoCommandResult.NewPrice}");
            return stringBuilder.ToString();
        }
    }
}