using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter side a: ");
        int sideA = int.Parse(Console.ReadLine());
        Console.Write("Enter side b: ");
        int sideB = int.Parse(Console.ReadLine());
        Console.Write("Enter height h: ");
        int sideH = int.Parse(Console.ReadLine());
        int area = ((sideA + sideB) / 2) * sideH;
        Console.WriteLine(area);
    }
}