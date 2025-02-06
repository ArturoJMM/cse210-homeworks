using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Start()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 6; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nNow breathe out... ");
            ShowCountDown(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }
        
}