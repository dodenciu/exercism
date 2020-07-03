using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        if (string.IsNullOrWhiteSpace(phrase))
            throw new ArgumentNullException();

        var acronym = "";

        var az = Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToList();
        az.Add('\'');

        var phraseLowered = phrase.ToLower().ToCharArray();

        for(int i = 0, j = -1; i < phraseLowered.Length; i++)
        {
            if (az.Contains(phraseLowered[i]))
            {
                // get first char that is a letter
                if (j == -1)
                {
                    j = i;
                    continue;
                }                

                // if previous character was special then store letter
                if (!az.Contains(phraseLowered[i-1]))
                {
                    acronym += phraseLowered[j].ToString().ToUpper();
                    j = i;
                }

                // if it is the final character add latest letter
                if (i == phraseLowered.Length - 1)
                {
                    acronym += phraseLowered[j].ToString().ToUpper();
                    break;
                }
            }
        }

        return acronym;
    }
}