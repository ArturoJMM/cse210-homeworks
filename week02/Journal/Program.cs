using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();

        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.WriteLine("Hello World! This is the Journal Project.");

        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");

    }
}