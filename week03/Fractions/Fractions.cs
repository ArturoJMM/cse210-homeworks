using System;

public class Fractions
{   
    //Attributes
    private int _topNumber;
    private int _bottomNumber;

    
    // Constructors:
    public Fractions()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fractions(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottomNumber = 1;
    }

    public Fractions(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }
    
    //Getters and Setters

    public int GetTop()
    {
        return _topNumber;
    }

    public void SetTop(int top)
    {
        _topNumber = top;
    }

    public int GetBottom()
    {
        return _bottomNumber;
    }

    public void SetBottom(int bottom)
    {
        _bottomNumber = bottom;
    }

    //Metods
    public string GetFractionString()
    {
        string text = $"{_topNumber}/{_bottomNumber}";
        return text;
    }

    public double GetDecimalValue()
    {
        double result = (double)_topNumber / (double)_bottomNumber;
        return result;
    }
}