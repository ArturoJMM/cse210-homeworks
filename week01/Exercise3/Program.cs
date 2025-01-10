using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 6;

        Console.Write("Please guess what is the magic number: ");
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);

        Console.WriteLine($"What is the magic number? {magicNumber}");
        Console.WriteLine($"What is your guess? {userNumber}");

        if (userNumber < magicNumber)
        {
            Console.WriteLine("You need to choose a Higher Number");
        }

        else if (userNumber > magicNumber)
        {
            Console.WriteLine("You need to choose a Lower Number");
        }

        else
        {
            Console.WriteLine("Great, You guessed It!");
        }

    }
}