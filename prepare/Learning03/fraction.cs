using System;

//Fraction.cs
public class Fraction
{
    //private attributes for numerator (top) and denominator (bottem)
    private int _numerator;
    private int _denominator;
//Constructor set 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    public int GetNumerator()
    {
        return _numerator;
    }
    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }
    public int GetDenominator()
    {
        return _denominator;
    }
    public void SetDenominator(int denominator)
    {
        if (denominator != 0)
        {
            _denominator = denominator;
        }
        else
    
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
    }
    //method to string fraction
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}

