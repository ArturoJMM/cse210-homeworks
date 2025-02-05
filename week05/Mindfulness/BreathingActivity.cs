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
            Console.WriteLine("Breathe in... ");
            ShowCountDown(3);
            Console.WriteLine("Breathe out... ");
            ShowCountDown(3);
        }

        DisplayEndingMessage();

    }
        
}