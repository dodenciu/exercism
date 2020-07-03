using System;
using System.Collections.Generic;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        var output = new Stack<string>();

        if (subjects.Length > 0)
        {
            output.Push($"And all for the want of a {subjects[0]}.");
        }

        for (int i = subjects.Length - 1; i > 0; i--)
        {
            output.Push($"For want of a {subjects[i - 1]} the {subjects[i]} was lost.");
        }

        return output.ToArray();
    }
}