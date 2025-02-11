using System;
using System.Reflection.Metadata;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square1 =  new Square("blue", 25);
        string color1 = square1.GetColor();
        double area1 = square1.GetArea();

        Circle circle1 = new Circle("black", 12);
        string color2 = circle1.GetColor();
        double area2 = circle1.GetArea();

        Rectangle rect1 = new Rectangle("green", 16, 9);
        string color3 = rect1.GetColor();
        double area3 = rect1.GetArea();

       
        Console.WriteLine($"The shape of color {color1}, has an area of {area1} cm2");
        Console.WriteLine($"The shape of color {color2}, has an area of {area2} cm2");
        Console.WriteLine($"The shape of color {color3}, has an area of {area3} cm2");
    }
}