using System;
using System.Linq;
using System.Text;

public static class RnaTranscription
{
    public static string ToRna(string strand)
    {
        if (strand == null)
        {
            throw new ArgumentNullException();
        }

        var transformed = new StringBuilder("");
        
        foreach(char nucleotide in strand.ToUpper().ToCharArray())
        {
            transformed.Append(Convert(nucleotide));
        }

        return transformed.ToString();
    }

    private static char Convert(char nucleotide) => nucleotide switch
    {
        'G' => 'C',
        'C' => 'G',
        'T' => 'A',
        'A' => 'U',
        _ => throw new ArgumentOutOfRangeException(),
    };
}