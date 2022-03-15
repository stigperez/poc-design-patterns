using System.Text;

namespace classlib.structural.bridge
{
    /*
    * The idea of the builder pattern is to separate additional business logic (color) away from the primary implementation (shape)
    * The pattern eliminates having to exponentially create more classes (redsquare, purplesquare, redtriangle, purpletriangle etc.) as more business logic is introduced
    */
    public class BridgeOutputGenerator : BaseOutputGenerator
    {
        public override string GetOutput()
        {
            var redColor = new Red();
            var purpleColor = new Purple();
            var square = new Square { Color = redColor };
            var triangle = new Triangle { Color = purpleColor };

            var output = new StringBuilder();
            output.AppendLine(square.ToString());
            output.AppendLine(triangle.ToString());

            return output.ToString();
        }
    }
}