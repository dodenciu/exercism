using System;
using System.Collections.Generic;

public static class NucleotideCount
{    
    public static IDictionary<char, int> Count(string sequence)
    {
        const char NUCLEOTIDE_A = 'A';
        const char NUCLEOTIDE_C = 'C';
        const char NUCLEOTIDE_G = 'G';
        const char NUCLEOTIDE_T = 'T';

        var nucleotides = new Dictionary<char, int>() 
        { 
            { NUCLEOTIDE_A, 0 }, 
            { NUCLEOTIDE_C, 0 }, 
            { NUCLEOTIDE_G, 0 }, 
            { NUCLEOTIDE_T, 0 } 
        };

        foreach (var nucleotide in sequence)
        {            
            if (!nucleotides.ContainsKey(nucleotide))
                throw new ArgumentException();

            nucleotides[nucleotide]++;            
        }

        return nucleotides;
    }
}