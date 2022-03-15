using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classlib.structural.flyweight
{
    /*
    * The purpose of the flyweight pattern is to reuse objects that does not change in order to save memory
    * It is similar to a lazy-load list
    */
    public class FlyweightOutputGenerator : BaseOutputGenerator
    {
        private static IEnumerable<string> _colors = new List<string> { "Red", "Green", "Blue", "White", "Black" };
        public override string GetOutput()
        {
            var output = new StringBuilder();
            var random = new Random();
            int numberOfCircles = 20;
            for (int i = 0; i < numberOfCircles; i++)
            {
                int randomColorIndex = random.Next(0, _colors.Count());
                string randomColor = _colors.ElementAt(randomColorIndex);
                var circle = ShapeFactory.GetCircle(randomColor);
                circle.X = random.Next() * 100;
                circle.Y = random.Next() * 100;
                circle.Radius = 100;
                output.AppendLine(circle.Draw());
            }
            output.AppendLine($"Number of circles: {numberOfCircles}");
            output.AppendLine($"Number of cached circles: {ShapeFactory.NumberOfFlyweightCircles}");
            return output.ToString();
        }
    }
}