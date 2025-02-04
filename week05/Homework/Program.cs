using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInfo());
    }
}