using System;
class Program
{
    static void Main()
    {
        inputNumber:
        bool prime = true;
        Console.Write("Enter positive integer number: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("The number is not positive!");
        }
        for (int divider = 2; divider <= Math.Sqrt(number); divider++)
        {
            if (number % divider == 0)
            {
                prime = false;
                Console.WriteLine(prime);
                break;
            }
        }
        goto inputNumber;
    }
}