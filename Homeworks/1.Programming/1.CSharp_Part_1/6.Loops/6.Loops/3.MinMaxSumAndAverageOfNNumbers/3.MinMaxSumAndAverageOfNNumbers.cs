using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter n: ");
        decimal n = decimal.Parse(Console.ReadLine());
        Console.WriteLine();
        decimal sum = 0;
        decimal min = decimal.MaxValue;
        decimal max = decimal.MinValue;
        decimal average = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Number {0}: ", i);
            decimal number = decimal.Parse(Console.ReadLine());
            sum += number;
            average = sum/n;

            if (number <= min)
            {
                min = number;
            }
            if (number >= max)
            {
                max = number;

            }
        }
        Console.WriteLine("Min: {0}", min);
        Console.WriteLine("Max: {0}", max);
        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Avg: {0}", average);
    }
}

/*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
  the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.*/