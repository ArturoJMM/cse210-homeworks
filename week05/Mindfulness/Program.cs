using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {   
        bool play = true;
        
        while (play)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("---- This is the Mindfulness Project. ----\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please select one of the following choices:\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            string choice = Console.ReadLine();
            Console.Clear();
            
            if (choice == "1")
            {
                BreathingActivity activity1 = new BreathingActivity();
                activity1.Start();
            }

            else if (choice == "2")
            {
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.Start();
            }

            else if (choice == "3")
            {
                ListingActivity activity3 = new ListingActivity();
                activity3.Start();
            }

            else if (choice == "4")
            {
                play = false;
                Console.WriteLine("Goodbye!!");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid choice. Please try again.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();
            }


        }
        

       

    }
}