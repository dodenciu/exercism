using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n <= 0 || n > 64)
        {
            throw new ArgumentOutOfRangeException();
        }
        return n == 1 ? 1 : Convert.ToUInt64(Math.Pow(2, n - 1));
    }

    public static double Total() => Math.Pow(2, 64);
}