using System;
using System.Collections;

class Program
{
    static void Main()
    {
        double[] temperaturesArray = { 23.5, 26.8, 24.0, 25.5, 22.7, 27.3, 21.8 };

        Console.WriteLine($"Number of temperatures equal to or greater than 25 degrees: {GreaterCount(temperaturesArray, 25.0)}");
    }

    static int GreaterCount(IEnumerable enumerable, double min)
    {
        int count = 0;

        foreach (var element in enumerable)
        {
            if (element is double && ((double)element) >= min)
            {
                count++;
            }
        }

        return count;
    }
}
