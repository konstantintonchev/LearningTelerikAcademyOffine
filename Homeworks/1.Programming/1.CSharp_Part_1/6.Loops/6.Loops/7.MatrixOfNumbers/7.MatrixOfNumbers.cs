using System;
class Program
{
    static void Main()
    {
        Console.Write("Ënter n: ");
        int n = int.Parse(Console.ReadLine());
        if (n > 1 && n < 20)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n + i; j++)
                {
                    Console.Write("{0,2} ", j);
                }
                Console.WriteLine();
            }
        }
        //Console.ReadLine();
        else
        {
            Console.WriteLine("Enter n between 1 and 20 !!!");
        }
    }
}

//Write a program that reads from the console a positive integer number n(1 ≤ n ≤ 20) and prints a matrix like in the examples below.Use two nested loops.
/*
if n=2

    12
    23

if n =3

    123
    234
    345

    */
