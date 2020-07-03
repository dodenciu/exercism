using System;
using System.Collections.Generic;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {        
        if (number == 0) return true;

        var digits = getNumberDigits(number);

        var sumOfDigits = 0;

        foreach (var digit in digits)
        {
            sumOfDigits += Convert.ToInt32(Math.Pow(digit, digits.Length));
        }        

        return number == sumOfDigits ? true : false;
    }

    private static int[] getNumberDigits(int number)
    {
        var digits = new List<int>();

        while (number > 0)
        {
            digits.Add(number % 10);
            number /= 10;
        }

        digits.Reverse();

        return digits.ToArray();
    }
}