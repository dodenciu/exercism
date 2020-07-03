using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public static class Pangram
{    
    public static bool IsPangram(string input)
    {
        var s = new Stopwatch();
        s.Start();
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }
            
        var alphabet = new LinkedList<char>(Enumerable.Range('a', 'z' - 'a' + 1).Select(el => (char)el));
        var inputInLowerCase = input.ToLower().ToCharArray();

        foreach (char c in inputInLowerCase)
        {
            alphabet.Remove(c);
                
        }

        s.Stop();
        Console.WriteLine(s.ElapsedMilliseconds);

        return alphabet.Count == 0;                
    }
}
