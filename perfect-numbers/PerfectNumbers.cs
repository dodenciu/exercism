using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1)
        {
            throw new ArgumentOutOfRangeException();
        }

        if (number == SumOfDividers(GetDividersForNumber(number)))
        {
            return Classification.Perfect;
        }

        return number > SumOfDividers(GetDividersForNumber(number)) ? Classification.Deficient : Classification.Abundant;
    }

    private static IReadOnlyList<int> GetDividersForNumber(int number)
    {


        List<int> dividers = new List<int>();
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                dividers.Add(i);
            }
        }

        return dividers;
    }

    private static int SumOfDividers(IReadOnlyList<int> dividers) =>
        dividers.Aggregate(0, (total, next) => total + next);
}
