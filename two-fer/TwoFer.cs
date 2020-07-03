using System;

public static class TwoFer
{
    #nullable enable
    public static string Speak()
    {
        const string defaultOtherPerson = "you";
        
        return $"One for {defaultOtherPerson}, one for me.";
    }

    public static string Speak(string? otherPerson)
    {        
        if (string.IsNullOrWhiteSpace(otherPerson))
        {
            return Speak();
        }

        return $"One for {otherPerson}, one for me.";
    }
}
