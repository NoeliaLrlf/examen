using System;

namespace ConsoleApp1
{
    public class Circle : AbstractGeometricFigure
    {
        public int circleRadius;

        public Circle(int radius) => circleRadius = radius;

        public override double GetArea() => Math.PI * Math.Pow(circleRadius, 2);
    }
}