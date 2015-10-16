using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(firstNumber, secondNumber));
    }
}
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
