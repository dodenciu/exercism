using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        List<long> factors = new List<long>();
        long rest = number;
        long factor = 2;
        while (rest != 1L)
        {
            if (rest % factor == 0)
            {
                factors.Add(factor);
                rest = rest / factor;
            }
            else
            {
                factor++;
            }
        }
        return factors.ToArray();
    }

    private static bool IsPrime(long numberToBePrime)
    {
        for (long i = 2; i * i < numberToBePrime; i++)
        {
            if (numberToBePrime % i == 0) return false;
        }

        return true;
    }

    private static IEnumerable<long> GetPrimesUntil(long n)
    {
        yield return 2;
        for (long i = 3; i <= n / 2; i+=2)
        {
            if (IsPrime(i)) yield return i;
        }
    }
}