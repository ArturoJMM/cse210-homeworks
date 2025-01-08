using System;

class Program
{
    static void Main(string[] args)
    {   // Core Requirements for the excercise
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        
        //Assigning  Variables and Types
        int grade = int.Parse(userInput);
        
        string letter = "";
        
        int lastDigit = grade % 10;

        // Start of the Conditionals
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge
        string sign = "";
        
        // Stretch Challenge 2 & 3. Conditionals for A and F letters
        if (grade > 60 && grade < 97)
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit <= 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        // Printing the results on the Console
        Console.WriteLine($"Your Grade is: {letter}{sign}");

        if (grade >= 70)
        {
           Console.WriteLine("Congratulation! You passed."); 
        }
        else
        {
            Console.WriteLine("Better luck next time!"); 
        }
  
    }
}