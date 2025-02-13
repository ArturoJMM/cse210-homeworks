using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Console.ResetColor();
        GoalManager manager = new GoalManager(0);
        manager.Start();
    }
}