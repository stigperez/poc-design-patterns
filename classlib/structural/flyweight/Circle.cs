namespace classlib.structural.flyweight
{
    public class Circle : IShape
    {
        public string Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public string Draw()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}