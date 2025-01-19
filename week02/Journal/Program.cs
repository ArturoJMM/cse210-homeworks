using System;
using System.Collections.Generic; 
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                Entry entry = new Entry(DateTime.Now, prompt, response);
                journal.AddEntry(entry);
                entry.Display();
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.WriteLine("Enter the filename to SAVE the journal: ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine("Your Journal have been saved successfully.");
            }

            else if (choice == 4)
            {
                Console.WriteLine("Enter the filename to LOAD the journal: ");
                string fileName = Console.ReadLine();
                journal.LoadFormFile(fileName);
                Console.WriteLine("Journal loaded successfully.");
            }

            else if (choice == 5)
            {
                quit = true;
                Console.WriteLine("GoodBye!");
            }

        }

    }
}