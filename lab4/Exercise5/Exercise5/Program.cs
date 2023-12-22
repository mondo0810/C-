using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Factorials of integers from 1 to 20:");

        for (int i = 1; i <= 20; i++)
        {
            long factorial = CalculateFactorial(i);
            Console.WriteLine($"Factorial of {i} is: {factorial}");
        }
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
