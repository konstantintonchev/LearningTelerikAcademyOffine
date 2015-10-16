using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        int sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum of three numbers are: {0}", sum);
    }
}
//Write a program that reads 3 real numbers from the console and prints their sum.