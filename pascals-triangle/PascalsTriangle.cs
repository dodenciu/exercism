using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        if (rows < 0) throw new ArgumentOutOfRangeException();
        if (rows == 0) return Enumerable.Empty<IEnumerable<int>>();

        var triangle = new List<List<int>>() { new List<int>{ 1 } };

        if (rows == 1) return triangle;

        for (int i = 1; i < rows; i++)
        {
            triangle.Add(new List<int>() { });
            for (int j = 0; j <= i; j++)
            {
                int previousLeft, previousRight;
                try
                {
                    previousLeft = triangle[i - 1][j - 1];
                    previousRight = triangle[i - 1][j];
                } catch
                {
                    triangle[i].Add(1);
                    continue;
                }

                triangle[i].Add(previousLeft + previousRight);                
            }
        }

        return triangle;
    }

}