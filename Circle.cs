using System;

namespace Shapes
{
    public class Circle : IShape
    {
        public int Radius { get; }

        public Circle(int radius)
        {
            Radius = radius;
        }
        public double GetSquare() => Math.PI * Math.Pow(Radius, 2);
    }
}
