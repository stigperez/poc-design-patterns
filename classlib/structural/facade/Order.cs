using Newtonsoft.Json;

namespace classlib.structural.facade
{
    public class Order
    {
        public string DishName { get; set; }
        public decimal DishPrice { get; set; }
        public string Username { get; set; }
        public string ShippingAddress { get; set; }
        public decimal ShippingPrice { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}