using System;
using System.Collections.Generic;
using System.IO;

public class EternalGoal : Goal
{
    private int _timesRecorded;
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _timesRecorded = 0;
    }

    public override void RecordEvent()
    {
        _timesRecorded++;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        string status = "[ ]";
        if (_timesRecorded == 1)
        {
            return $"{status} {GetShortName()} ({GetDescription()}) - Done by {_timesRecorded} time";
        }
        else
        {
            return $"{status} {GetShortName()} ({GetDescription()}) - Done by {_timesRecorded} times";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetShortName()},({GetDescription()}),{GetPoints()},{_timesRecorded}";
    }
}