using System;

class Program
{
    static void Main()
    {
        string[] fiveNumbers = Console.ReadLine().Split();
        double a = Convert.ToDouble(fiveNumbers[0]);
        double b = Convert.ToDouble(fiveNumbers[1]);
        double c = Convert.ToDouble(fiveNumbers[2]);
        double d = Convert.ToDouble(fiveNumbers[3]);
        double e = Convert.ToDouble(fiveNumbers[4]);

        double sum = a + b + c + d + e;
        Console.WriteLine(sum);
    }
}