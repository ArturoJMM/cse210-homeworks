using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square1 =  new Square("blue", 25);

        string color1 = square1.GetColor();

        double area1 = square1.GetArea();

        Console.WriteLine($"The square of color {color1}, has an area of {area1} cm2");
    }
}