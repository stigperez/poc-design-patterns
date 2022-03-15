using System;

namespace classlib.behavioral.command
{
    public class ProductReceiver
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public CommandResult IncreasePrice(double amount)
        {
            Price += amount;
            return new CommandResult {IsSuccessful = true, NewPrice = Price };
        }

        public CommandResult DecreasePrice(double amount)
        {
            bool isSuccessful = false;
            if(amount < Price)
            {
                Price -= amount;
                isSuccessful = true;
            }
            return new CommandResult {IsSuccessful = isSuccessful, NewPrice = Price };
        }

        public override string ToString()
        {
            return $"The price for {Name} is {Price}";
        }
    }
}