using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter five number: ");
        double e = double.Parse(Console.ReadLine());

        if (a > b && a > c && a>d && a>e)
        {
            Console.WriteLine("The bigger is first number: {0}", a);
        }
        if (b > a && b > c && b>d && b>e)
        {
            Console.WriteLine("The bigger is second number: {0}", b);
        }
        if (c > a && c > b && c>d && c>e)
        {
            Console.WriteLine("The bigger is third number: {0}", c);
        }
        if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine("The bigger is fourth number: {0}", d);
        }
        if (e > a && e > b && e > c && e > d)
        {
            Console.WriteLine("The bigger is five number: {0}", e);
        }
    }
}