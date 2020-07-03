using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Raindrops
{    
    public static string Convert(int number)
    {       
        var rainCodes = new Dictionary<int, string>() { { 3, "Pling" }, { 5, "Plang" }, { 7, "Plong" } };

        StringBuilder outputInRainLanguage = new StringBuilder("");
        foreach (var code in rainCodes)
        {
            if (number % code.Key == 0) outputInRainLanguage.Append(code.Value);
        }

        return outputInRainLanguage.Length != 0 ? outputInRainLanguage.ToString() : number.ToString();
    }
}