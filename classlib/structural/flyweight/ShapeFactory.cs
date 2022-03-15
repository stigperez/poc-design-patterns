using System;
using System.Collections.Generic;
using System.Linq;

namespace classlib.structural.flyweight
{
    public static class ShapeFactory
    {
        private static IList<Circle> _flyweightCircles = new List<Circle>();
        public static int NumberOfFlyweightCircles => _flyweightCircles.Count();

        public static IShape GetCircle(string color)
        {
            var flyweightCircle = _flyweightCircles.FirstOrDefault(candidate => candidate.Color.Equals(color, StringComparison.OrdinalIgnoreCase));
            if(flyweightCircle == null)
            {
                flyweightCircle = new Circle
                {
                    Color = color
                };
                _flyweightCircles.Add(flyweightCircle);
                Console.WriteLine($"Created new circle with color {color}");
            }
            return flyweightCircle;
        }
    }
}