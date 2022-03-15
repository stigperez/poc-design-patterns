namespace classlib.structural.bridge
{
    public abstract class BaseShape
    {
        public string Name { get; set; }
        public IColor Color { get; set; }
    }
}