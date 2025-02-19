using System;
using System.Threading;

public class Activity
{
    private string _activityName;
    private string _description;
    protected int _duration;

    public Activity(string activityName, string description, int duration = 0)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\nLet's begin with the {_activityName}!\n");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(_description);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("Get ready we begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        

    }

    public void DisplayEndingMessage()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nGood Job!");
        Console.WriteLine($"\nYou have completed the {_activityName} for {_duration} seconds.");
        ShowSpinner(3);
        Console.ResetColor();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinners = new List<string>{"|", "/", "-", "\\"};
        for (int i = seconds; i > 0; i--)
        {
            foreach (string s in spinners)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}