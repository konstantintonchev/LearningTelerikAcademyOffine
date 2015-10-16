using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double d = ((b * b) - (4 * a * c));

        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
            if (d == 0)
            {
            double x = ((-b) / (2 * a));
            Console.WriteLine("X = {0}", x);
            }
        else
        {
            double x1 = (((-b) + Math.Sqrt(d)) / (2 * a));
            double x2 = (((-b) - Math.Sqrt(d)) / (2 * a));
            Console.WriteLine("X1 = {0} X2 = {1}", x1, x2);
        }
    }
}