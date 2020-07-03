using System;
using System.Collections.Generic;
using System.Linq;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if (outputBase <= 1 || inputBase <= 1) throw new ArgumentException();

        foreach(var digit in inputDigits)
        {
            if (digit < 0 || digit >= inputBase) throw new ArgumentException();
        }

        var initialNumber = inputDigits.Reverse().Select((digit, index) => digit *= (int)Math.Pow(inputBase, index)).Sum();

        if (initialNumber == 0) return new int[1] { 0 };

        List<int> outputNumber = new List<int>();

        while (initialNumber > 0)
        {
            outputNumber.Add(initialNumber % outputBase);
            initialNumber /= outputBase; 
        }

        outputNumber.Reverse();

        return outputNumber.ToArray();
    }
    
}