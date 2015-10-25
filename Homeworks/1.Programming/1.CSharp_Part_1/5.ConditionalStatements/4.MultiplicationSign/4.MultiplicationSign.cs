using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double fNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter first number: ");
        double sNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter first number: ");
        double tNumber = double.Parse(Console.ReadLine());
        if (fNumber == 0 || sNumber == 0 || tNumber == 0)
        {
            Console.WriteLine("0");
        }
        if (fNumber > 0 && sNumber > 0 && tNumber > 0)
        {
            Console.WriteLine("+");
        }
        if (fNumber > 0 && sNumber > 0 && tNumber < 0)
        {
            Console.WriteLine("-");
        }
        if (fNumber > 0 && sNumber < 0 && tNumber < 0)
        {
            Console.WriteLine("+");
        }
        if (fNumber < 0 && sNumber < 0 && tNumber < 0)
        {
            Console.WriteLine("-");
        }
        if (fNumber < 0 && sNumber > 0 && tNumber < 0)
        {
            Console.WriteLine("+");
        }
        if (fNumber < 0 && sNumber > 0 && tNumber > 0)
        {
            Console.WriteLine("-");
        }
    }
}

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.