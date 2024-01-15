using System;
class Program
{
    static void Main()
    {
        int num1, num2, num3;

        Console.Write("Enter the first integer: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        num2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the third integer: ");
        num3 = int.Parse(Console.ReadLine());
        int maxNumber = FindMax(num1, num2, num3);

        Console.WriteLine("\nThe maximum number is: " + maxNumber);

    }

    static int FindMax(int a, int b, int c)
    {
        int max = a;

        if (b > max)
            max = b;

        if (c > max)
            max = c;

        return max;
    }
}
