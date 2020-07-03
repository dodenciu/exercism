using System;
using System.Collections.Generic;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if (word == null)
        {
            throw new ArgumentNullException();
        }

        var wordLowerAsArray = word.ToLower().ToCharArray().Where(c => c != '-' && c != ' ');
        
        return wordLowerAsArray.Count() == wordLowerAsArray.Distinct().Count();
    }
}
