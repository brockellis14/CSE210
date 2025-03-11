using System;

class Fraction
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

    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Error: Denominator cannot be zero.");
        }
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom; 
    }

    public void SetBottom(int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Error: Cannot have a denominator of zero.");
        }
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return _bottom == 1 ? $"{_top}" : $"{_top}/{_bottom}";
    }

    public double DecimalValue()
    {
        return (double)_top / _bottom;
    }
}