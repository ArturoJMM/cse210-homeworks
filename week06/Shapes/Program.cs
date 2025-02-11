using System;
using System.Reflection.Metadata;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shapes> shapes = new List<Shapes>();

        Square sh1 = new Square("Orange", 23.5);
        Rectangle sh2 = new Rectangle("Green", 22, 13);
        Circle sh3 = new Circle("Red", 16);

        shapes.Add(sh1);
        shapes.Add(sh2);
        shapes.Add(sh3);

        foreach (Shapes shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The shape of color {color}, has an area of {area} cm2");
        }
            
        
    }
}