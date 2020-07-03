using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool divisibleBy4 = (year % 4) == 0;
        bool divisibleBy100 = (year % 100) == 0;
        bool divisibleBy400 = (year % 400) == 0;

        if (!divisibleBy4)
            return false;

        if (divisibleBy100)        
            return divisibleBy400;        

        return true;        
    }
}