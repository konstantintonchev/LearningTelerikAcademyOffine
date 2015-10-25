using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        if (a>b && a>c)
        {
            if (b>c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
        }
        if (a > b && a > c)
        {
            if (b < c)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
        }
        if (b > a && b > c)
        {
            if (a > c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
        }
        if (b > a && b > c)
        {
            if (a < c)
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
        }
        if (c > a && c > a)
        {
            if (a > b)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
        if (c > a && c > b)
        {
            if (a < b)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
    }
}