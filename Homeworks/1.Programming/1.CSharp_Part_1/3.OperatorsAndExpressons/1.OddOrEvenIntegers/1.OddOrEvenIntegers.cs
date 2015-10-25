using System;
class Program
{
    static void Main()
    {
        enterNumber:
        Console.Write("Please enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        bool even = false;
        if (number % 2 == 0)
        {
            even = true;
            Console.WriteLine("The number: {0}", number + " is even.");
        }
        else
        {
            even = false;
            Console.WriteLine("The number: {0}", number + " is odd.");
        }
        goto enterNumber;
    }
}