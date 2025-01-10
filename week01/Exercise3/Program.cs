using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random(); 
        int magicNumber = randomGenerator.Next(1, 101);
        int userNumber = 0;
        int count = 0;

        while (userNumber != magicNumber)
        {
            Console.Write("Please guess what is the magic number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            count += count;

            Console.WriteLine($"What is your guess? {userNumber}");

            if (userNumber < magicNumber)
            {
                Console.WriteLine("You need to choose a Higher Number");
            }

            else if (userNumber > magicNumber)
            {
                Console.WriteLine("You need to choose a Lower Number");
            }
        }

        Console.WriteLine($"Great, the magic number was {magicNumber}. You guessed It!");
        Console.WriteLine($"It took you {count} tries to guess It");
        
    }
}