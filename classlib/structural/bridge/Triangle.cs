namespace classlib.structural.bridge
{
    public class Triangle : BaseShape
    {
        public Triangle()
        {
            Name = nameof(Triangle);
        }
        
        public override string ToString()
        {
            return $"The name of the shape is '{Name}' - is it a primary color?: '{Color}'";
        }
    }
}