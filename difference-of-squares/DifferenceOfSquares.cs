using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        if (max < 0) throw new ArgumentException();

        var sum = Enumerable.Range(0, max + 1).Sum();

        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        if (max < 0) throw new ArgumentException();

        var sumOfSquares = Enumerable.Range(0, max + 1).Select(number => number * number).Sum();

        return sumOfSquares;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        if (max < 0) throw new ArgumentException();
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}