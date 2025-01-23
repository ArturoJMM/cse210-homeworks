using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Console.ResetColor();
        Console.WriteLine();

        Fractions fraction1 = new Fractions();
        Console.WriteLine($"Get Top Number: {fraction1.GetTop()}");
        Console.WriteLine($"Get Bottom Number: {fraction1.GetBottom()}");
        Console.WriteLine($"This is the fraction expresion: {fraction1.GetFractionString()}");
        Console.WriteLine($"This is the Fraction Result: {fraction1.GetDecimalValue()}");
        Console.WriteLine("Please enter the new top Number: ");
        int top = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the new bottom Number: ");
        int bottom = int.Parse(Console.ReadLine());
        fraction1.SetTop(top);
        fraction1.SetBottom(bottom);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"This is the NEW fraction expresion: {fraction1.GetFractionString()}");
        Console.WriteLine($"This is the NEW Fraction Result: {fraction1.GetDecimalValue()}");
        Console.ResetColor();
        Console.WriteLine();


        Fractions fraction2 = new Fractions(6);
        Console.WriteLine($"Get Top Number: {fraction2.GetTop()}");
        Console.WriteLine($"Get Bottom Number: {fraction2.GetBottom()}");
        Console.WriteLine($"This is the fraction expresion: {fraction2.GetFractionString()}");
        Console.WriteLine($"This is the Fraction Result: {fraction2.GetDecimalValue()}");
        Console.WriteLine("Please enter the new top Number: ");
        top = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the new bottom Number: ");
        bottom = int.Parse(Console.ReadLine());
        fraction2.SetTop(top);
        fraction2.SetBottom(bottom);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"This is the NEW fraction expresion: {fraction2.GetFractionString()}");
        Console.WriteLine($"This is the NEW Fraction Result: {fraction2.GetDecimalValue()}");
        Console.ResetColor();
        Console.WriteLine();


        Fractions fraction3 = new Fractions(6 , 7);
        Console.WriteLine($"Get Top Number: {fraction3.GetTop()}");
        Console.WriteLine($"Get Bottom Number: {fraction3.GetBottom()}");
        Console.WriteLine($"This is the fraction expresion: {fraction3.GetFractionString()}");
        Console.WriteLine($"This is the Fraction Result: {fraction3.GetDecimalValue()}");
        Console.WriteLine("Please enter the new top Number: ");
        top = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the new bottom Number: ");
        bottom = int.Parse(Console.ReadLine());
        fraction3.SetTop(top);
        fraction3.SetBottom(bottom);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"This is the NEW fraction expresion: {fraction3.GetFractionString()}");
        Console.WriteLine($"This is the NEW Fraction Result: {fraction3.GetDecimalValue()}");
        Console.ResetColor();
        Console.WriteLine();


        Fractions fraction4 = new Fractions(3 , 4);
        Console.WriteLine($"Get Top Number: {fraction4.GetTop()}");
        Console.WriteLine($"Get Bottom Number: {fraction4.GetBottom()}");
        Console.WriteLine($"This is the fraction expresion: {fraction4.GetFractionString()}");
        Console.WriteLine($"This is the Fraction Result: {fraction4.GetDecimalValue()}");
        Console.WriteLine("Please enter the new top Number: ");
        top = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the new bottom Number: ");
        bottom = int.Parse(Console.ReadLine());
        fraction4.SetTop(top);
        fraction4.SetBottom(bottom);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"This is the NEW fraction expresion: {fraction4.GetFractionString()}");
        Console.WriteLine($"This is the NEW Fraction Result: {fraction4.GetDecimalValue()}");
        Console.ResetColor();
    }
}