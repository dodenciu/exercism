using System;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        if (span < 0) throw new ArgumentException();

        if (string.IsNullOrWhiteSpace(digits)) {
            if (span == 0) return 1;
            throw new ArgumentException();
        }              

        if (span == 0) return 1;

        if (span > digits.Length) throw new ArgumentException();

        bool allZero = true;

        foreach (var digit in digits)
        {
            if (!char.IsDigit(digit)) throw new ArgumentException();
            if (int.Parse(digit.ToString()) != 0) allZero = false;
        }

        if (allZero) return 0;

        var maxProduct = 1;
        bool allTempProductsAreZero = true;

        for (int i = 0; i <= digits.Length - span; i++)
        {
            var tempProduct = 1;
            for (int j = i; j < i + span; j++)
            {
                tempProduct *= int.Parse(digits[j].ToString());
            }

            if (tempProduct > maxProduct)
            {
                allTempProductsAreZero = false;
                maxProduct = tempProduct;
            }                
        }

        return allTempProductsAreZero ? 0 : maxProduct;
    }
}