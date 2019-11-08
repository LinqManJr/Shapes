using System;

namespace Shapes
{
    public static class SquareCalculator
    {
        public static double Calculate(IShape shape)
        {
            return shape.GetSquare();
        }
        public static bool IsRightTriangle(this IShape shape)
        {
            if (shape is Triangle)
            {
                var triangle = shape as Triangle;
                return IsRightTriangle(triangle.SideA, triangle.SideB, triangle.SideC);
            }
            throw new ShapeException("This is Not Triangle");

        }
        private static bool IsRightTriangle(int sideA, int sideB, int sideC) =>
                                           sideA == SumOfSquares(sideB, sideC)
                                        || sideB == SumOfSquares(sideA, sideC)
                                        || sideC == SumOfSquares(sideA, sideB);
        private static double SumOfSquares(int sideA, int sideB) => Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
    }
}
