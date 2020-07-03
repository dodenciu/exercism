using System;
using System.Collections.Generic;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        if (input == null)
            throw new ArgumentNullException();

        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        var scrabblePoints = new Dictionary<int, IList<char>>()
        {
            { 1, new []{'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' } },
            { 2, new []{'D', 'G' } },            
            { 3, new []{'B', 'C', 'M', 'P' } },
            { 4, new []{'F', 'H', 'V', 'W', 'Y' } },
            { 5, new []{'K' } },
            { 8, new []{'J', 'X' } },
            { 10, new []{'Q', 'Z' } }
        };

        var score = 0;

        foreach(char letter in input.ToUpper())
        {
            foreach(var scrabbleRow in scrabblePoints)
            {
                if (scrabbleRow.Value.Contains(letter))
                {
                    score += scrabbleRow.Key;
                }
            }
        }

        return score;
    }
}