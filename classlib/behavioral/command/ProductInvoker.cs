using System.Collections.Generic;
using System.Linq;

namespace classlib.behavioral.command
{
    public class ProductInvoker
    {
        public ICommand CurrentProductCommand { get; set; }
        public List<ICommand> ProductCommandCollection { get; set; }

        public ProductInvoker()
        {
            ProductCommandCollection = new List<ICommand>();
        }

        public CommandResult Invoke()
        {
            var commandResult = CurrentProductCommand.ExecuteCommand();
            if(commandResult.IsSuccessful)
            {
                ProductCommandCollection.Add(CurrentProductCommand);
            }
            return commandResult;
        }

        public CommandResult Undo()
        {
            CommandResult lastCommandResult = new CommandResult {IsSuccessful = false, NewPrice = 0 };
            var reversedProductCommands = Enumerable.Reverse(ProductCommandCollection).ToList();
            reversedProductCommands.ForEach(productCommand => lastCommandResult = productCommand.UndoCommand());
            return lastCommandResult;
        }
    }
}