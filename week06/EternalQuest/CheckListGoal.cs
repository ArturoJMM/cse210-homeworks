using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _bonusAwarded;

    public CheckListGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
        _bonusAwarded = false;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
        if (_amountCompleted >= _target && !_bonusAwarded)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nWell Done! You completed the checklist goal and earned a bonus of {_bonus} points!");
            Console.ResetColor();
            
        }
        else if (_bonusAwarded)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The bonus has already been awarded for this goal.");
            Console.ResetColor();
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status;
        if (_amountCompleted >= _target)
        {
            status = "[X]";
        }
        else
        {
            status = "[ ]";
        }
        return $"{status} {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted},{_bonusAwarded}";
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public bool IsBonusAwarded()
    {
        return _bonusAwarded;
    }

    public void SetBonusAwarded(bool value)
    {
        _bonusAwarded = value;
    }
}