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
       
        if (a>b && a>c)
        {
            Console.WriteLine("The bigger is first number: {0}", a);
        }
        if (b>a && b>c)
        {
            Console.WriteLine("The bigger is second number: {0}", b);
        }
        if (c>a && c>b)
        {
            Console.WriteLine("The bigger is third number: {0}", c);
        }        
    }
}