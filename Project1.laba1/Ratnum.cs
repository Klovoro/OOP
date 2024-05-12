using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1;
public class RationalNumber
{
    private readonly int _numerator;
    private readonly int _denominator;

    public int Numerator => _numerator;
    public int Denominator => _denominator;
    public RationalNumber(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero");

        if (numerator == 0)
        {
            _numerator = 0;
            _denominator = 1;
        }
        else
        {
            int gcd = del(Math.Abs(numerator), Math.Abs(denominator));
            _numerator = numerator / gcd;
            _denominator = denominator / gcd;
            if (_denominator < 0)
            {
                _numerator = -_numerator;
                _denominator = -_denominator;
            }
        }
    }
    private int del(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public override string ToString()
    {
        if (Numerator == Denominator)
        {
            return $"1";
        }
        if (Denominator == 1)
        {
            return $"{Numerator}";
        }

        return $"{Numerator}/{Denominator}";
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        int num = r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator;
        int denom = r1.Denominator * r2.Denominator;
        return new RationalNumber(num, denom);
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        int num = r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator;
        int denom = r1.Denominator * r2.Denominator;
        return new RationalNumber(num, denom);
    }

    public static RationalNumber operator -(RationalNumber r)
    {
        return new RationalNumber(-r.Numerator, r.Denominator);
    }

    public static bool operator ==(RationalNumber r1, RationalNumber r2)
    {
        return r1.Numerator == r2.Numerator && r1.Denominator == r2.Denominator;
    }

    public static bool operator !=(RationalNumber r1, RationalNumber r2)
    {
        return !(r1 == r2);
    }

    public static bool operator <(RationalNumber r1, RationalNumber r2)
    {
        return r1.Numerator * r2.Denominator < r2.Numerator * r1.Denominator;
    }

    public static bool operator >(RationalNumber r1, RationalNumber r2)
    {
        return !(r1 < r2) && r1 != r2;
    }

}