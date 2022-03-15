namespace classlib.structural.flyweight
{
    public interface IShape
    {
        string Color { get; set; }
        int X { get; set; }
        int Y { get; set; }
        int Radius { get; set; }
        string Draw();
    }
}