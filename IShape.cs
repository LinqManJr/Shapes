using System;

namespace Shapes
{
    public interface IShape
    {
        double GetSquare();
    }

    public class ShapeException : Exception
    {
        public ShapeException(string message) : base(message)
        {
        }

    }
}
