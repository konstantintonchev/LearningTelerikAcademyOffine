using System;
class Program
{
    static void Main()
    {
        for (int i = 1; i < 1001; i++)
        {
            Console.WriteLine((i+1)*Math.Pow(-1, i+1));
        }
    }
}