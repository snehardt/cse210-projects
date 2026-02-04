using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetBottom(int bottom)
    {
        if (bottom != 0) 
        {
            _bottom = bottom;
        }
        else 
        {
            _bottom = 1;
        }
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        SetBottom(bottom);
    }

    public string GetFractionString()
    {
        string fullFraction = $"{_top}/{_bottom}";
        return fullFraction;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
};