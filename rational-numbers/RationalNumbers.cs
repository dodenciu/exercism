using System;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r) => 
        realNumber == 0 ? 0 : Math.Pow(Math.Pow(realNumber, r.Numerator), 1.0 / r.Denominator);
}

public struct RationalNumber
{    
    public int Numerator { get; private set; }
    public int Denominator { get; private set; }
    public RationalNumber(int numerator, int denominator)
    {
        if (denominator == 0) throw new ArgumentException();
        Numerator = numerator;
        Denominator = denominator;
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2) =>
        new RationalNumber(r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator).Reduce();

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2) =>
        new RationalNumber(r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator).Reduce();


    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2) =>
        new RationalNumber(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator).Reduce();


    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2) =>
        new RationalNumber(r1.Numerator * r2.Denominator, r2.Numerator * r1.Denominator).Reduce();
            
    public RationalNumber Abs() =>    
        new RationalNumber(Math.Abs(Numerator), Math.Abs(Denominator)).Reduce();

    public double Expreal(int baseNumber) => Math.Sqrt(Math.Pow(baseNumber, Numerator) / Denominator);    

    public RationalNumber Exprational(int power)
    {
        if (power > 0)
            return new RationalNumber((int)Math.Pow(Numerator, power), (int)Math.Pow(Denominator, power)).Reduce();

        else return power == 0
            ? new RationalNumber(1, 1)
            : new RationalNumber((int)Math.Pow(Denominator, Math.Abs(power)), (int)Math.Pow(Numerator, Math.Abs(power))).Reduce();
    }

    public RationalNumber Reduce()
    {
        var divider = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
        return AdjustSign(new RationalNumber(Numerator / divider, Denominator / divider));
    }

    private static RationalNumber AdjustSign(RationalNumber r)
    {
        if (r.Denominator < 0)
            return new RationalNumber(-r.Numerator, Math.Abs(r.Denominator));

        return r;
    }

    private static int GCD(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        return a == 0 ? b : a;
    }
}