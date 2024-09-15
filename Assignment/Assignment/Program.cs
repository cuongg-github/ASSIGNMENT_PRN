using System;
namespace Assignment
{
    internal class Program
    {
        static (double perimeter, double area) Rectangle ( double length, double width )
        {
            return ((length + width) * 2, length * width);
        }

        static (double perimeter, double area) Square ( double length )
        {
            return ((length)*4, length*length);
        }
        static (double perimeter, double area) Triangle (double a, double b, double c)
        {
            double C = (a+b+c)/2;
            double area = Math.Sqrt(C * (C - a) * (C - b) * (C - c));
            return (C*2, area);

        }

        static void Main(string[] args)
        {
            var (perimeter, area) = Rectangle(5, 4);
            Console.WriteLine($"perimeter and area in rectangle is {perimeter} and {area}");
            (perimeter, area) = Square(9);
            Console.WriteLine($"perimeter and area in square is {perimeter} and {area}");
            (perimeter, area) = Triangle(3, 4, 5);
            Console.WriteLine($"perimeter and area in triangle is {perimeter} and {area}");

        }
    }
}