using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter how many numbers: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < number; i++)
        {
            Console.Write("Enter value: ");
            int value = int.Parse(Console.ReadLine());
            sum += value;
        }
        Console.WriteLine(sum);
    }
}