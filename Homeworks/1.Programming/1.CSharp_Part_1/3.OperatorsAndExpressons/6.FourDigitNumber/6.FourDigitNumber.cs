using System;

class Program
{
    static void Main()
    {
        Console.Write("Pleace enter four digit number: ");
        int number = int.Parse(Console.ReadLine());
        int a = number / 1000;
        int divider = number / 100;
        int b = divider % 10;
        divider = number / 10;
        int c = divider % 10;
        int d = number % 10;

        int sum = a + b + c + d;

        Console.WriteLine("The sum of number {0}", number + " is: " + sum);
        Console.WriteLine("The number in reverce order is: {0}{1}{2}{3}", d, c, b, a);
        int lastDigitFirstPosition = number / 10;
        Console.WriteLine("{0}{1}", d, lastDigitFirstPosition);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}
