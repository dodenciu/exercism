using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class House
{
    public static string Recite(int verseNumber)
    {
        var poem = new StringBuilder();

        if (verseNumber == 0)
            poem.Append(poemWords.Values.Last());

        poem.Append(poemWords.Values.Last());

        poem = poem.Append("This is the" + Recite(--verseNumber));

        verseNumber--;

        return verses;
    }

    public static string Recite(int startVerse, int endVerse)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    //public static List<string> poem = new List<string>()
    //{
    //    "This is the horse and the hound and the horn",
    //    "that belonged to the farmer sowing his corn",
    //    "that kept the rooster that crowed in the morn",
    //    "that woke the priest all shaven and shorn",
    //    "that married the man all tattered and torn",
    //    "that kissed the maiden all forlorn",
    //    "that milked the cow with the crumpled horn",
    //    "that tossed the dog",
    //    "that worried the cat",
    //    "that killed the rat",
    //    "that ate the malt",
    //    "that lay in the house that Jack built."
    //};

    public static Dictionary<string, string> poemWords = new Dictionary<string, string>()
    {
        {"belonged to", "the farmer sowing his corn" },
        {"kept", "the rooster that crowed in the morn" },
        {"woke", "the priest all shaven and shorn" },
        {"married", "the man all tattered and torn" },
        {"kissed", "the maiden all forlorn" },
        {"milked", "the cow with the crumpled horn" },
        {"tossed", "the dog" },
        {"worried", "the cat" },
        {"killed", "the rat" },
        {"ate", "the malt" },
        {"lay in", "the house that Jack built." }
    };
}