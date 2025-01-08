using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
            Console.WriteLine($"Your Grade is: {letter}");
        }
        else if (grade >= 80)
        {
            letter = "B";
            Console.WriteLine($"Your Grade is: {letter}");
        }
        else if (grade >= 70)
        {
            letter = "C";
            Console.WriteLine($"Your Grade is: {letter}");
        }
        else if (grade >= 60)
        {
            letter = "D";
            Console.WriteLine($"Your Grade is: {letter}");
        }
        else
        {
            letter = "F";
            Console.WriteLine($"Your Grade is: {letter}");
        }

    
    }
}