namespace classlib.structural.composite
{
    /*
    * The purpose of the composite pattern is to represent a hierarchy of objects that inherit the same interface
    * A good example would be a navigation menu where all menu items inherit from the same interface
    * It is similar to a "recursive" hierarchy of objects where all work is delegated to the child objects
    */
    public class CompositeOutputGenerator : BaseOutputGenerator
    {
        public override string GetOutput()
        {
            var compositeGift = new CompositeGift("RootBox", 0);
            var singleGift = new SingleGift("Phone", 1);
            var singleGift2 = new SingleGift("TruckToy", 2);
            var singleGift3 = new SingleGift("PlainToy", 3);
            compositeGift.Add(singleGift2);
            compositeGift.Add(singleGift3);
            var childCompositeGift = new CompositeGift("ChildBox", 0);
            var singleGift4 = new SingleGift("SoldierToy", 4);
            childCompositeGift.Add(singleGift4);
            compositeGift.Add(childCompositeGift);

            double totalPrice = singleGift.CalculateTotalPrice();
            totalPrice += compositeGift.CalculateTotalPrice();
            return $"Total price for all gifts: {totalPrice}";
        }
    }
}