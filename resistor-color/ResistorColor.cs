using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        if (string.IsNullOrWhiteSpace(color))
        {
            throw new ArgumentNullException();
        }

        var supportedColors = Colors();
        var colorCode = Array.IndexOf<string>(supportedColors, color.Trim().ToLower());

        return  colorCode != -1 ? colorCode : throw new ArgumentException("Unsupported color");
    }

    public static string[] Colors() => new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };    
}