using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand == null || secondStrand == null)
        {
            throw new ArgumentException();
        }

        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException();
        }

        var distance = 0;

        for (int i = 0; i < firstStrand.Length; i++)
        {
            if (firstStrand.ToUpper()[i] != secondStrand.ToUpper()[i])
            {
                distance++;
            }
        }

        return distance;        
    }
}