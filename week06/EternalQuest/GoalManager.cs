using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(int score)
    {
        _score = score;
    }

    public void Start()
    {
        bool play = true;
        while (play)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nYou have {_score} points\n");

            // Options Menu
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Goal Manager Menu:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goal Details");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Select a choice from the menu: ");
            Console.ResetColor();
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
                play = false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid choice. Please try again.");
                Console.ResetColor();
                return;
            }

        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nPlayer Information:");
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine("Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"- {goal.GetDetailsString()}");
        }
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"- {goal.GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoal Recorded:");
        for (int i = 0; i < _goals.Count; i++)
        {
            foreach (Goal goal in _goals)
            {
                if (i != 0)
                {
                    Console.WriteLine($"{i + 1}. {goal.GetDetailsString()}");
                }
                else
                {
                    Console.WriteLine("Your goal list is empty, go and create one!");
                }
            }
        }

    }
    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Clear();
            Console.Write("What is the name of your Goal? ");
            string shortName = Console.ReadLine();
            Console.Write("Write a short description of your Goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points to earn with this goal? ");
            int points = int.Parse(Console.ReadLine());
            _goals.Add(new SimpleGoal(shortName, description, points));

        }
        else if (choice == "2")
        {
            Console.Clear();
            Console.Write("What is the name of your Goal? ");
            string shortName = Console.ReadLine();
            Console.Write("Write a short description of your Goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points to earn with this goal? ");
            int points = int.Parse(Console.ReadLine());
            _goals.Add(new EternalGoal(shortName, description, points));
        }
        else if (choice == "3")
        {
            Console.Clear();
            Console.Write("What is the name of your Goal? ");
            string shortName = Console.ReadLine();
            Console.Write("Write a short description of your Goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points to earn with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the BONUS for accomplishing it tha many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new CheckListGoal(shortName, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            return;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nAvailable Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{i + 1}. {goal.GetShortName()}");
            }
        }

        Console.Write("Which goal did you accomplished: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice <= _goals.Count)
        {
            Goal selectedGoal = _goals[choice];
            selectedGoal.RecordEvent();

            if (selectedGoal.IsComplete())
            {
                _score += selectedGoal.GetPoints();
                Console.WriteLine($"Congratulations! You earned {selectedGoal.GetPoints()} points");
                Console.WriteLine($"Naow you have {_score} points.");
            }
            else
            {
                Console.WriteLine("Event recorded successfully!");
            }
        }
        else 
        {
            Console.WriteLine("Invalid choice.");
        }

    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? (add the '.txt' at th end) ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved goals file found.");
            return;
        }
        
        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        
        _score = int.Parse(lines[0]);
            
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            if (type == "SimpleGoal")
            {
               string shortName = data[0];
               string description = data[1];
               int points = int.Parse(data[2]);
               bool isComplete = bool.Parse(data[3]);

               Goal goal = new SimpleGoal(shortName, description, points);
               if (isComplete)
               {
                goal.RecordEvent();
                _goals.Add(goal);
               }
            }
            else if (type == "EternalGoal")
            {
                string shortName = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                int timesRecorded = int.Parse(data[3]);

                Goal goal = new EternalGoal(shortName, description, points);
                for (int t = 0; t < timesRecorded; t++)
                {
                    goal.RecordEvent();
                    _goals.Add(goal);
                }
            }
            else if (type == "ChecklistGoal")
            {
                string shortName = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                int bonus = int.Parse(data[3]);
                int target = int.Parse(data[4]);
                int amountCompleted = int.Parse(data[5]);

                Goal goal = new CheckListGoal(shortName, description, points, target, bonus);

                for (int j = 0; j < amountCompleted; j++)
                {
                    goal.RecordEvent();
                    _goals.Add(goal);
                }
            }
        }
        
        Console.WriteLine("Your goals file has been loaded successfully!");
    }
}