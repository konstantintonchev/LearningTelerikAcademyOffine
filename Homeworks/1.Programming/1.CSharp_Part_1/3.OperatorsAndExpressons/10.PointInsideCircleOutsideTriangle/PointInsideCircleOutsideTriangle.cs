using System;

class InsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Console.Write("Enter X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y: ");
        double y = double.Parse(Console.ReadLine());
        if (((Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2)) <= Math.Pow(1.5, 2)) && (x>=-0.5 && x<=2.5) && (y >= 1 && y <= 2.5))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}