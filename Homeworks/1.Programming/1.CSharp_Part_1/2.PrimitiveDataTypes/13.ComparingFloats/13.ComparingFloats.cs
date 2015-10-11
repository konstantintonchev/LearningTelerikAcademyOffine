using System;
class Program
{
    static void Main()
    {
        double a = 5.3;
        double b = 6.01;
        bool compare = (a == b);
        Console.WriteLine(compare);
        double c = 5.00000001f;
        double d = 5.00000003f;
        bool compare2 = (c == d);
        Console.WriteLine(compare2);
        double e = 5.00000005f;
        double f = 5.00000001f;
        bool compare3 = (e == f);
        Console.WriteLine(compare3);
    }
}