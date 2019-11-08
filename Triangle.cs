using System;

namespace Shapes
{
    public class Triangle : IShape
    {
        public int SideA { get; }
        public int SideB { get; }
        public int SideC { get; }

        public Triangle(int sideA, int sideB, int sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public double GetSquare()
        {
            var p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }
}
