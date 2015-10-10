using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your age: ");
        int age = int.Parse(Console.ReadLine());
        int ageAfter = (age + 10);
        Console.Write("Your age after ten years will be: ");
        Console.WriteLine(ageAfter);
    }
}