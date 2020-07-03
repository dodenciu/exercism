using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (string.IsNullOrWhiteSpace(numbers))
        {
            throw new ArgumentException();
        }

        foreach(var number in numbers)
        {
            if (!char.IsDigit(number))
            {
                throw new ArgumentException();
            }
        }

        if (sliceLength <= 0)
        {
            throw new ArgumentException();
        }

        if (numbers.Length < sliceLength)
        {
            throw new ArgumentException();
        }

        List<string> slices = new List<string>();

        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            slices.Add(numbers.Substring(i, sliceLength));
        }

        return slices.ToArray();
    }
}