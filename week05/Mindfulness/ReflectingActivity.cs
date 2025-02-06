using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "> Why was this experience meaningful to you?",
        "> Have you ever done anything like this before?",
        "> How did you get started?",
        "> How did you feel when it was complete?",
        "> What made this time different than other times when you were not as successful?",
        "> What is your favorite thing about this experience?",
        "> What could you learn from this experience that applies to other situations?",
        "> What did you learn about yourself through this experience?",
        "> How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
        
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    
    }

    public void DisplayPrompt(string prompt)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n--- {prompt} ---");
        Console.ResetColor();
    }

    public void DisplayQuestion(string question)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"{question} ");
        Console.ResetColor();
    }

    public void Start()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        for (int i = 0; i < _duration / 10; i++)
        {
            string question = GetRandomQuestion();
            DisplayQuestion(question);
            ShowSpinner(10);
        }
        DisplayEndingMessage();
    }
}