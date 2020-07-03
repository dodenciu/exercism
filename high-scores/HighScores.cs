using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly IEnumerable<int> _highscores;
    public HighScores(List<int> list)
    {
        if (list == null) throw new ArgumentNullException();
        if (list.Count == 0) throw new ArgumentException();

        _highscores = new List<int>(list);        
    }

    public List<int> Scores() => _highscores.ToList<int>();
    public int Latest() => _highscores.Last();
    public int PersonalBest() => _highscores.Max();    
    public List<int> PersonalTopThree() => _highscores.OrderByDescending(score => score).Take(3).ToList();
}