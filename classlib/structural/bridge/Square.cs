namespace classlib.structural.bridge
{
    public class Square : BaseShape
    {
        public Square()
        {
            Name = nameof(Square);
        }
        
        public override string ToString()
        {
            return $"The name of the shape is '{Name}' - is it a primary color?: '{Color}'";
        }
    }
}