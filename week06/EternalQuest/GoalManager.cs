using System;
using System.Collections.Generic;
using System.Formats.Asn1;
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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("****** EternalQuest Project. ******");
            Console.ResetColor();
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
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Press enter to continue...");
                Console.ResetColor();
                Console.ReadLine();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Press enter to continue...");
                Console.ResetColor();
                Console.ReadLine();
            }
            else if (choice == "3")
            {
                SaveGoals();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Press enter to continue...");
                Console.ResetColor();
                Console.ReadLine();
            }
            else if (choice == "4")
            {
                LoadGoals();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Press enter to continue...");
                Console.ResetColor();
                Console.ReadLine();
            }
            else if (choice == "5")
            {
                RecordEvent();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Press enter to continue...");
                Console.ResetColor();
                Console.ReadLine();
            }
            else if (choice == "6")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("****** Goodbye! ******");
                Console.ResetColor();
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

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"- {goal.GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYour goal list is empty, go and create one!");
            Console.ResetColor();
            return;
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nGoals Recorded:");
        Console.ResetColor();
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetDetailsString()}");
        }
    }
    
    public void CreateGoal()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("The types of Goals are:");
        Console.ResetColor();
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\nWhich type of goal would you like to create? ");
        string choice = Console.ReadLine();

        if (choice != "1" && choice != "2" && choice != "3")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid choice. Please try again.");
        }
        
        else if (choice == "1")
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("What is the name of your Goal? ");
            Console.ResetColor();
            string shortName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Write a short description of your Goal? ");
            Console.ResetColor();
            string description = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("What is the amount of points to earn with this goal? ");
            Console.ResetColor();
            int points = int.Parse(Console.ReadLine());
            _goals.Add(new SimpleGoal(shortName, description, points));

        }
        else if (choice == "2")
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("What is the name of your Goal? ");
            Console.ResetColor();
            string shortName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Write a short description of your Goal? ");
            Console.ResetColor();
            string description = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("What is the amount of points to earn with this goal? ");
            Console.ResetColor();
            int points = int.Parse(Console.ReadLine());
            _goals.Add(new EternalGoal(shortName, description, points));
        }
        else if (choice == "3")
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("What is the name of your Goal? ");
            Console.ResetColor();
            string shortName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Write a short description of your Goal? ");
            Console.ResetColor();
            string description = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("What is the amount of points to earn with this goal? ");
            Console.ResetColor();
            int points = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            Console.ResetColor();
            int target = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("What is the BONUS for accomplishing it tha many times? ");
            Console.ResetColor();
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new CheckListGoal(shortName, description, points, target, bonus));
        }
        
    }

    public void RecordEvent()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nAvailable Goals:");
        Console.ResetColor();
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetShortName()}");
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\nWhich goal did you accomplished: ");
        Console.ResetColor();
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice < 0 || choice > _goals.Count)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid choice.");
            Console.ResetColor();
            return;
        }
        
        Goal selectedGoal = _goals[choice];
        selectedGoal.RecordEvent();

        if (selectedGoal.IsComplete())
        {
            _score += selectedGoal.GetPoints();

            if (selectedGoal is CheckListGoal checklistGoal)
            {
                if (!checklistGoal.IsBonusAwarded())
                {
                    _score += checklistGoal.GetBonus();
                    checklistGoal.SetBonusAwarded(true);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("The bonus for this goal has already been awarded.");
                    Console.ResetColor();
                }
            } 

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nCongratulations! You earned {selectedGoal.GetPoints()} points.");
            Console.ResetColor();
            Console.WriteLine($"Now you have {_score} points.");
        }
        else
        {
            Console.WriteLine("Event recorded successfully!");
        }
    }
    public void SaveGoals()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
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
        Console.WriteLine("\nGoals saved successfully!");
        Console.ResetColor();
    }

    public void LoadGoals()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\nWhat is the filename for the goal file? (add the '.txt' at th end) ");
        Console.ResetColor();
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No saved goals file found.");
            Console.ResetColor();
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
               }
               _goals.Add(goal);
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
                }
                _goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                string shortName = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                int bonus = int.Parse(data[3]);
                int target = int.Parse(data[4]);
                int amountCompleted = int.Parse(data[5]);
                bool bonusAwarded = bool.Parse(data[6]);

                Goal goal = new CheckListGoal(shortName, description, points, target, bonus);

                for (int j = 0; j < amountCompleted; j++)
                {
                    goal.RecordEvent();
                }
                if (goal is CheckListGoal checkListGoal)
                {
                    checkListGoal.SetBonusAwarded(bonusAwarded);
                }
                _goals.Add(goal);
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nYour goals file has been loaded successfully!");
        Console.ResetColor();
    }
}