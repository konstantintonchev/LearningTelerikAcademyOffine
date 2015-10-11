using System;
class Program
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 10;
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        int thirdNumber = firstNumber;
        firstNumber = secondNumber;
        secondNumber = thirdNumber;
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
    }
}