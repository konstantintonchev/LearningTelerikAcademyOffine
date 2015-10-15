using System;
class Program
{
    static void Main()
    {
        enterNumber:
        bool divides;
        Console.Write("Please enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        if ((number % 7 == 0) && (number % 5 == 0))
        {
            divides = true;
            Console.WriteLine("The number: {0} ", number + " divides to 7 and 5.");
        }
        else
        {
            divides = false;
            Console.WriteLine("The number: {0} ", number + " isn`t divides to 7 and 5.");
        }
        goto enterNumber;
    }
}

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.