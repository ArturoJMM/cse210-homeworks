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
        Console.WriteLine($"\nLet's begin with the {_activityName}!\n");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Get ready we begin in: ");
        ShowCountDown(5);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood Job!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed the {_activityName} for {_duration} seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinners = new List<string>{"|", "/", "-", "\\", "|", "/", "-", "\\"};
        for (int i = seconds; i > 0; i--)
        {
            foreach (string s in spinners)
            {
                Console.WriteLine(s);
                Thread.Sleep(800);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void actionTime()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {

        }
    }
}