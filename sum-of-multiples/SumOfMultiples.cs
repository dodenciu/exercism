using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max) =>
        Enumerable.Range(1, max - 1).Where(number => FilterByMultiples(multiples, number)).Distinct().Sum();

    private static bool FilterByMultiples(IEnumerable<int> multiples, int number) =>
        multiples.Where(multiplier => multiplier != 0)
                 .Any(multiplier => number % multiplier == 0);
}