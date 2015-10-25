using System;
class Program
{
    static void Main()
    {
        Console.Write("Ente n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if ((i % 3 != 0) && (i % 7 != 0))
            {
                Console.Write(" {0}", i);
            }
        }
        Console.WriteLine();
    }
}

/*Write a program that enters from the console a positive integer n and prints all the numbers
  from 1 to n not divisible by 3 or 7, on a single line, separated by a space.*/