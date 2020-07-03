using System;
using System.Collections.Generic;
using System.Linq;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int s)
    {
        var triplets = new List<(int a, int b, int c)>();

        int mlimit = (int)Math.Sqrt(s / 2);
        int m;
        for (m = 2; m <= mlimit; m++)
        {
            if ((s / 2) % m == 0)
            { 
                var k = m % 2 == 0 ? m + 1 : m + 2;
                while (k < 2 * m && k <= s / (2 * m))
                {
                    if (s / (2 * m) % k == 0 && GetGreatestCommonDivisor(k, m) == 1)
                    {
                        var d = s / 2 / (k * m);
                        var n = k - m;
                        var a = d * (m * m - n * n);
                        var b = 2 * d * n * m;
                        var c = d * (m * m + n * n);

                        if (s == a + b + c) triplets.Add((a > b) ? (b, a, c) : (a, b, c));
                    }
                    k += 2;
                }
            }
        }
        
        return triplets.OrderBy(triplet => triplet.a);
    }

    private static int GetGreatestCommonDivisor(int a, int b)
    {
        int y;
        int x;
        if (a > b)
        {
            x = a;
            y = b;
        }
        else
        {
            x = b;
            y = a;
        }

        while (x % y != 0)
        {
            int temp = x;
            x = y;
            y = temp % x;
        }
        return y;
    }
}