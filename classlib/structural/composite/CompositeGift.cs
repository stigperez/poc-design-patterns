using System.Collections.Generic;

namespace classlib.structural.composite
{
    public class CompositeGift : BaseGift, IGiftOperation
    {
        private List<BaseGift> _gifts;
        public CompositeGift(string name, double price) : base(name, price)
        {
            _gifts = new List<BaseGift>();
        }
        public void Add(BaseGift gift)
        {
            _gifts.Add(gift);
        }

        public void Remove(BaseGift gift)
        {
            _gifts.Remove(gift);
        }

        public override double CalculateTotalPrice()
        {
            double totalPrice = 0;
            _gifts.ForEach(gift => totalPrice += gift.CalculateTotalPrice());
            return totalPrice;
        }
    }
}