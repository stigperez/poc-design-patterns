namespace classlib.creational.abstractfactory
{
    public abstract class Trailer
    {
        public string Type { get; set; }
        public int NumberOfWheels { get; set; }
        public int Capacity { get; set; }
        public bool IsClosed { get; set; }
    }
}