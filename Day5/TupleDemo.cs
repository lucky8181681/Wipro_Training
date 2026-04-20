using System;

namespace Day5
{
    internal class TupleDemo
    {
        public static (double area, double perimeter) CalculateRectangle(double length, double width)
        {
            double area = length * width;
            double perimeter = 2 * (length + width);

            return (area, perimeter);
        }
    }
}