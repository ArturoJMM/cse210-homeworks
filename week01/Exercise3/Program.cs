using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        bool playAgain = true;

        while (playAgain)
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
                count++; // Stretch Callenge N°1 Keep track of how many guesses the user has made

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
            Console.WriteLine($"It took you {count} tries to guess It"); // how many guesses the user has made and inform them of it at the end of the game.

            Console.Write("/n Do you want to play again (yes/no): ");
            string playAgainInput = Console.ReadLine().ToLower();

            if (playAgainInput != "yes")
            {
                playAgain = false;
            }
        
        }

        Console.WriteLine("Thanks for play, Good Bye!");
    }
}