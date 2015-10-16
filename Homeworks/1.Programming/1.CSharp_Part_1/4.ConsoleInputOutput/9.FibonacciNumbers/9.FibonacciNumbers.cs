using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        for (int i = 0; i < number; i++)
        {
            int temp = a;
            a = b;
            b = temp + a;
            Console.WriteLine(b);
        }

    }
}