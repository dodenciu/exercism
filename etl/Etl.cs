using System;
using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var output = new Dictionary<string, int>();

        foreach (var scrableMapping in old)
        {
            foreach (var letter in scrableMapping.Value)
            {
                output.Add(letter.ToLower(), scrableMapping.Key);
            }
        }

        return output.OrderBy(scrabbleMapping => scrabbleMapping.Key)
                      .ToDictionary(scrabbleMapping => scrabbleMapping.Key, scrabbleMapping => scrabbleMapping.Value);
    }
}