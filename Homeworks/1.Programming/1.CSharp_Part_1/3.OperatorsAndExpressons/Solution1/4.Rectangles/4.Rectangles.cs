using System;
class Program
{
    static void Main()
    {
        enterData:
        Console.Write("Pleace enter rectangle width: ");
        int rectangleWidth = int.Parse(Console.ReadLine());
        Console.Write("Pleace enter rectangle height: ");
        int rectangleHeight = int.Parse(Console.ReadLine());
        int perimeter = (2 * (rectangleHeight + rectangleWidth));
        int area = (rectangleWidth * rectangleHeight);
        Console.WriteLine("The rectangle have perimeter: {0}.", perimeter);
        Console.WriteLine("The rectangle have area: {0}.", area);
        goto enterData;
    }
}

//Write an expression that calculates rectangle’s perimeter and area by given width and height.