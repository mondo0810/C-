using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> temperatures = new List<double> { 23.5, 26.8, 24.0, 25.5, 22.7, 27.3, 21.8 };

        Console.WriteLine($"Number of temperatures equal to or greater than 25 degrees: {GreaterCount(temperatures, 25.0)}");
    }

    static int GreaterCount(List<double> list, double min)
    {
        int count = 0;

        foreach (var temperature in list)
        {
            if (temperature >= min)
            {
                count++;
            }
        }

        return count;
    }
}
