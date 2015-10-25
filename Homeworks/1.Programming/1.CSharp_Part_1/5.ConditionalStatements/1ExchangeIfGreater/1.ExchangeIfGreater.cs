using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = 0;
        if (firstNumber > secondNumber)
        {
            thirdNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
    }
}