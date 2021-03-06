﻿using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        int f = 1;
        double sum = 1;

        for (int i = 0; i <= n; i++)
        {
            f *= i;
            sum += (f / Math.Pow(x, i));
        }
        Console.WriteLine(sum);
    }
}


/*Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop.Print the result with 5 digits after the decimal point.
*/
