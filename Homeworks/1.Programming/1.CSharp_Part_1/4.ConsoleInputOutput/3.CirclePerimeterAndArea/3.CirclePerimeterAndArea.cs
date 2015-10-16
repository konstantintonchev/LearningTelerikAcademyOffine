using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter radius: ");
        double circleRadius = double.Parse(Console.ReadLine());
        double circleArea = 2 * Math.PI * (circleRadius * circleRadius);
        double circlePerimeter = Math.PI * circleRadius;
        Console.WriteLine("The area of the circle is: {0: 0.00}", circleArea);
        Console.WriteLine("The perimeter of the circle is: {0: 0.00}", circlePerimeter);
    }
}

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.